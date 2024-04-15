using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
