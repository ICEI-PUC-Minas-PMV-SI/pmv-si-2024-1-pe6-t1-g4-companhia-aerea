using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.ReserveAggregate
{
    public class ReserveDtoUpdate
    {
        [Required(ErrorMessage ="O campo Id é obrigatório!")]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="O campo Status é obrigatório! ")]
        public ReserveStatus Status { get; set; }
        [Required(ErrorMessage = "O campo bagagem extra é obrigatório!")]
        public bool ExtraLuggage { get; set; }
    }
}
