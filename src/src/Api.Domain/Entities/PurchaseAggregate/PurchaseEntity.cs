using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.PaymentAggregate
{
    public class PurchaseEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid PaymentId { get; set; }
        public StatusPurchase Status { get; set; }

    }

    public enum StatusPurchase
    {
        Active = 1,
        Inactive = 2,
        Blocked = 3
    }
}
