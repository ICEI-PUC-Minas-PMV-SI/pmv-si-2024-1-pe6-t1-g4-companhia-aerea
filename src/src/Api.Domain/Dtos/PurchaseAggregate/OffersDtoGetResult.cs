using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.PurchaseAggregate
{
    public class OffersDtoGetResult
    {
        public Guid Id { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PromotionalCode { get; set; }
        public decimal Discount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
