using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class IataDtoCreate
    {
        [Required(ErrorMessage = "Codigo IATA é um campo obrigatório")]
        public string IATACode { get; set; }
        [Required(ErrorMessage = "Nome do aeroporto é um campo obrigatório")]
        public string Airport { get; set; }
        [Required(ErrorMessage = "Localizacao é um campo obrigatório")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Disponibilidade é um campo obrigatório")]
        public bool Available { get; set; }
    }
}
