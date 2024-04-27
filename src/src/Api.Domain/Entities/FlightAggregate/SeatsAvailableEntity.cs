using System;

namespace Api.Domain.Entities.FlightAggregate
{
    public class SeatsAvailableEntity : BaseEntity
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public ClassSeatsAvailable Class { get; set; }
        public bool Available { get; set; }
        public decimal Price { get; set; }
    }

    public enum ClassSeatsAvailable
    {
        Economica = 1,
        Business = 2,
        FirstClass = 3
    }


}
