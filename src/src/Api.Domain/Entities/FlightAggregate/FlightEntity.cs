using System;
using System.Collections.Generic;
using Api.Domain.Entities;

namespace Domain.Entities.FlightAggregate
{
    public class FlightEntity : BaseEntity
    {
        public string FlightCode { get; set; }
        public FlightStatus FlightStatusId { get; set; }
        public Guid FlightIntineraryId { get; set; }

        public FlightItineraryEntity FlightIntinerary { get; set; }

        public IReadOnlyCollection<SeatsEntity> Seats => _seats;
        public readonly List<SeatsEntity> _seats;

    }

    public enum FlightStatus
    {
        Active = 1,
        Inactive = 2,
        Blocked = 3
    }
}
