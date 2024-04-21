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
        [Required(ErrorMessage = "Código de Vôo é um campo obrigatório")]
        public string FlightCode { get; set; }
        [Required(ErrorMessage = "Rota de Vôo é um campo obrigatório")]
        public Guid FlightIntineraryId { get; set; }
        [Required(ErrorMessage = "Status de Vôo é um campo obrigatório")]
        public int FlightStatusId { get; set; }
        public Guid SeatsAvailableId { get; set; }
    }
}
