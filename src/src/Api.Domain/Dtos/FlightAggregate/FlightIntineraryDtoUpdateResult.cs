using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightIntineraryDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public DateTime LeaveDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public int LeaveIATAId { get; set; }
        public int ArriveIATAId { get; set; }
    }
}
