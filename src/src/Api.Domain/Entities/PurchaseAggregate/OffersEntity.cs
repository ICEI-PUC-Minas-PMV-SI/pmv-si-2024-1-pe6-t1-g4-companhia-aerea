using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.PurchaseAggregate
{
    public class OffersEntity : BaseEntity
    {
        public DateTime InitialDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PromotionalCode { get; set; }
        public decimal Discount { get; set; }
    }   
}
