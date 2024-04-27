using Domain.Entities.PaymentAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.PurchaseAggregate
{
    public class PurchaseDtoResult
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PaymentId { get; set; }
        public StatusPurchase Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
