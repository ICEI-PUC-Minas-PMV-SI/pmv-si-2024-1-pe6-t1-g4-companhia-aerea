using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.FlightAggregate
{
    public class SeatsEntity : BaseEntity
    {
        public string Column { get; set; }
        public string Row { get; set; }
        public bool Available { get; set; }
        public decimal Price { get; set; }
        public FlightClass FlightClassId { get; set; }

        public Guid FlightId { get; set; }
    }

    public enum FlightClass
    {
        Executive = 1,
        Economic = 2
    }
}
