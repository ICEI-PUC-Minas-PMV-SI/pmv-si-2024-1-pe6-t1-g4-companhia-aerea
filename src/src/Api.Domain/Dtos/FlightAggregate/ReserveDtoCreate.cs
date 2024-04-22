using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class ReserveDtoCreate
    {
        [Required(ErrorMessage = "Bagagem extra é um campo obrigatório")]
        public bool ExtraLuggage { get; set; }

        [Required(ErrorMessage = "Voo é um campo obrigatório")]
        public Guid FlightId { get; set; }

        [Required(ErrorMessage = "Cliente é um campo obrigatório")]
        public Guid CustomerId { get; set; }
    }
}
