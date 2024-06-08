using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FlightEntity : BaseEntity
    {
        public string FlightCode { get; set; }
        public Guid FlightIntineraryEntityId { get; set; }
        public FlightIntineraryEntity FlightIntinerary { get; set; }

        public ICollection<SeatsAvailableEntity> SeatsAvailable { get; set; }
        public ICollection<ReserveEntity> Reserves { get; set; } // Navigation property
        public FlightStatus FlightStatus { get; set; }
    }
    public enum FlightStatus
    {
        Delayed = 0,OnTime = 1,Rescheduled = 3
    }
}
