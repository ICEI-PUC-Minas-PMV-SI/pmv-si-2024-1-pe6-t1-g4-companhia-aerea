using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.PaymentAggregate
{
    public class PaymentCreateDto
    {
        [Required(ErrorMessage = "C é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Sobrenome deve ter no máximo {1} caracteres.")]
        public string PaymentCode { get; set; }

    }
}
