using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightIntineraryDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime LeaveDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public Guid LeaveIATAId { get; set; }
        public Guid ArriveIATAId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
