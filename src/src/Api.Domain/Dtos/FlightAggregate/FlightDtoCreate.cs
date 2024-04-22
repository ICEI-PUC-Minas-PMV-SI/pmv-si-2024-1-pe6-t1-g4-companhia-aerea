using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightDtoCreate
    {
        [Required(ErrorMessage = "Data do voo é um campo obrigatório")]
        public Guid FlightIntineraryId { get; set; }

        [Required(ErrorMessage = "Poltrona do voo é um campo obrigatório")]
        public Guid SeatsAvailableId { get; set; }

        [Required(ErrorMessage = "Código do voo é um campo obrigatório")]
        public string FlightCode { get; set; }
    }
}
