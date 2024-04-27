using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.PaymentAggregate
{
    public class PaymentEntity : BaseEntity
    {
        public Guid? OfferId { get; set; }
        public string PaymentCode { get; set; }
        public StatusPayment StatusId { get; set; }
        public TypesPayment TypePayment { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public static string GeneratePaymentCode()
        {
            long currentUnixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            string timeStr = currentUnixTime.ToString();
            string hashValue = CalculateMD5Hash(timeStr);
            string truncatedHash = hashValue.Substring(0, 12);

            return truncatedHash;
        }

        private static string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Converter bytes do hash para uma string hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }

    public enum TypesPayment
    {
        Cash = 1,
        CreditCard = 2,
        DebitCard = 3,
        Pix = 4
    }

    public enum StatusPayment
    {
        Active = 1,
        Inactive = 2,
        Blocked = 3
    }


}
