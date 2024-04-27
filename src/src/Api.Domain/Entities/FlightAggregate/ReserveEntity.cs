using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.FlightAggregate
{
    public class ReserveEntity : BaseEntity
    {
        public string ReserveCode { get; set; }
        public bool ExtraLuggage { get; set; }

        public Guid FlightId { get; set; }
        public Guid CustomerId { get; set; }

        public static string GenerateReserveCode()
        {
            string currentDate = DateTime.Now.ToString("yyyyMMdd");
            string ReserveCode = currentDate + GenerateRandomPart();

            return ReserveCode;
        }

        private static string GenerateRandomPart()
        {
            Random random = new Random();
            const string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] randomPart = new char[6];

            for (int i = 0; i < randomPart.Length; i++)
            {
                randomPart[i] = allowedCharacters[random.Next(allowedCharacters.Length)];
            }

            return new string(randomPart);
        }

    }
}
