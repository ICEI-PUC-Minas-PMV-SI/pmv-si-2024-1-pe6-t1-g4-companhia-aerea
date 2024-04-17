using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.PurchaseAggregate
{
    public class OffersDtoCreate
    {
        [Required(ErrorMessage = "Data Inicial é um campo obrigatório")]
        public DateTime InitialDate { get; set; }

        [Required(ErrorMessage = "Data de Expiração  é um campo obrigatório")]
        public DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage = "Código Promocional é um campo obrigatório")]
        public string PromotionalCode { get; set; }

        [Required(ErrorMessage = "Desconto é um campo obrigatório")]
        public decimal Discount { get; set; }
    }
}
