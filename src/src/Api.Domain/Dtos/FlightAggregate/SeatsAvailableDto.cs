using Api.Domain.Entities.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class SeatsAvailableDto
    {
        public Guid Id { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public ClassSeatsAvailable Class { get; set; }
        public bool Available { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
