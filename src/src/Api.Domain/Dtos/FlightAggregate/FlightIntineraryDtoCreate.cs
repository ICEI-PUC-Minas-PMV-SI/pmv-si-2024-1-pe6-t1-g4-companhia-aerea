using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightIntineraryDtoCreate
    {
        [Required(ErrorMessage = "Descrição é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "Descrição deve ter no máximo {1} caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Data de partida é um campo obrigatório")]
        public DateTime LeaveDate { get; set; }

        [Required(ErrorMessage = "Data de chegada é um campo obrigatório")]
        public DateTime ArriveDate { get; set; }

        [Required(ErrorMessage = "Local de partida é um campo obrigatório")]
        public Guid LeaveIATAId { get; set; }

        [Required(ErrorMessage = "Local de chegada é um campo obrigatório")]
        public Guid ArriveIATAId { get; set; }
    }
}
