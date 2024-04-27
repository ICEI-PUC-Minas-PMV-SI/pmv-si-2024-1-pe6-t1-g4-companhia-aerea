using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightDtoCreateResult
    {
        public Guid Id { get; set; }
        public string FlightCode { get; set; }
        
        public Guid FlightIntineraryId { get; set; }
        
        public int FlightStatusId { get; set; }
        public Guid SeatsAvailableId { get; set; }
    }
}
