using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightIntineraryDtoUpdate
    {
        [Required(ErrorMessage = "Id é um campo obrigatório")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Descricao é um campo obrigatório")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Disponivel é um campo obrigatório")]
        public bool Available { get; set; }
        [Required(ErrorMessage = "Horario de partida é um campo obrigatório")]
        public DateTime LeaveDate { get; set; }
        [Required(ErrorMessage = "Horario de chegada é um campo obrigatório")]
        public DateTime ArriveDate { get; set; }
        [Required(ErrorMessage = "Aeroporto de partida é um campo obrigatório")]
        public int LeaveIATAId { get; set; }
        [Required(ErrorMessage = "Aeroporto de chegada é um campo obrigatório")]
        public int ArriveIATAId { get; set; }
    }
}
