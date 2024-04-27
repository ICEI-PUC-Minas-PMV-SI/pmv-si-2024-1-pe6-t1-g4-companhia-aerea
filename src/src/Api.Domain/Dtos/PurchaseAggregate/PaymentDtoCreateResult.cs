using Domain.Entities.PaymentAggregate;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.PurchaseAggregate
{
    public class PaymentDtoCreateResult
    {
        public Guid Id { get; set; }
        public Guid? OfferId { get; set; }
        public string PaymentCode { get; set; }
        public int TypePayment { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
