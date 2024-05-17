using Api.Domain.Entities;

namespace Domain.Entities.FlightAggregate
{
    public class IataEntity : BaseEntity
    {
        public string IATACode { get; set; }
        public string Airport { get; set; }
        public string Location { get; set; }
        public bool Available { get; set; }

    }
}
