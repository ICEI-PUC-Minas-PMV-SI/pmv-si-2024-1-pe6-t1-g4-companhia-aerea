using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightDto
    {
        public Guid Id { get; set; }
        public string FlightCode { get; set; }
        public Guid FlightIntineraryId { get; set; }
        public Guid SeatsAvailableId { get; set; }
        public int FlightStatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
