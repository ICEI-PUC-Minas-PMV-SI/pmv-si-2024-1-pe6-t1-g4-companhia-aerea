using System;

namespace Api.Domain.Entities.FlightAggregate
{
    public class FlightEntity : BaseEntity
    {
        public string FlightCode { get; set; }
        public Guid FlightIntineraryId { get; set; }
        public Guid SeatsAvailableId { get; set; }
        public Guid UserId { get; set; }
        public FlightStatus Status { get; set; }


    }

    public enum FlightStatus
    {
        Active = 1,
        Inactive = 2,
        Blocked = 3
    }


}
