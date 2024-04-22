using Api.Domain.Entities.FlightAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class SeatsAvailableDtoCreate
    {
        [Required(ErrorMessage = "Coluna é um campo obrigatório")]
        public int Column { get; set; }
        
        [Required(ErrorMessage = "Row é um campo obrigatório")]
        public int Row { get; set; }

        [Required(ErrorMessage = "Classe é um campo obrigatório")]
        public int Class { get; set; }

        [Required(ErrorMessage = "Preço é um campo obrigatório")]
        public decimal Price { get; set; }
    }
}
