using System;
using Api.Domain.Entities;

namespace Domain.Entities.FlightAggregate
{
    public class FlightEntity : BaseEntity
    {
        public string FlightCode { get; set; }
        public Guid FlightIntineraryId { get; set; }
        public Guid SeatsAvailableId { get; set; }
        public int FlightStatusId { get; set; }
    }
}
