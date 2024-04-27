using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.PurchaseAggregate
{
    public class OffersDtoCreateResult
    {
        public Guid Id { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PromotionalCode { get; set; }
        public decimal Discount { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
