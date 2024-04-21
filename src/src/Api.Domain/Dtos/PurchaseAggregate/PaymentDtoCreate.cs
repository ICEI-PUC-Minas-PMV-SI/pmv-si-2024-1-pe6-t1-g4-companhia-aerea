using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.PurchaseAggregate
{
    public class PaymentDtoCreate
    {
        public Guid? OfferId { get; set; }

        [Required(ErrorMessage = "Tipo de Pagamento é um campo obrigatório")]
        public int TypePayment { get; set; }

        [Required(ErrorMessage = "Ocorreu um erro inesperado e o Subtotal não pode ser calculado")]
        public decimal SubTotal { get; set; }

        [Required(ErrorMessage = "Ocorreu um erro inesperado e o Total não pode ser calculado")]
        public decimal Total { get; set; }
    }
}
