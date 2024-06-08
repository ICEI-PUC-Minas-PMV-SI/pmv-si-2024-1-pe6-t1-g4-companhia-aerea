using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class SeatsAvailableDTO
    {
        public Guid Id { get; set; }
        public string FlightCode { get; set; }
        public string Position { get; set; }
        public int ClassType { get; set; }
        public bool Available { get; set; }

    }
}
