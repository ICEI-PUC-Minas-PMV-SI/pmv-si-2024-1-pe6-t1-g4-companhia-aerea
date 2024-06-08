using Api.Domain.Entities;
using Domain.Entities;
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

        public ICollection<SeatsAvailableEntity> SeatsAvailable { get; set; }
        public ICollection<ReserveEntity> Reserves { get; set; } // Navigation property
        public FlightStatus FlightStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
