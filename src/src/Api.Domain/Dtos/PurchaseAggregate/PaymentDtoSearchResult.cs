using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.PurchaseAggregate
{
    public class PaymentDtoSearchResult
    {
        public Guid Id { get; set; }
        public Guid? OfferId { get; set; }
        public string PaymentCode { get; set; }
        public int TypePayment { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}
