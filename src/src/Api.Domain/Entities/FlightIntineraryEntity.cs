using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FlightIntineraryEntity : BaseEntity
    {
        public string Description { get; set; }
        public bool Available { get; set; }
        public DateTime LeaveDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public Guid LeaveIATAId { get; set; }
        public Guid ArriveIATAId { get; set; }

        public ICollection<FlightEntity> Flights { get; set; }
    }
}
