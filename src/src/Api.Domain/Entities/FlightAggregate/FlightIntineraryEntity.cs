using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.FlightAggregate
{
    public class FlightIntineraryEntity : BaseEntity
    {
        public string Description { get; set; }
        public DateTime LeaveDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public Guid LeaveIATAId { get; set; }
        public Guid ArriveIATAId { get; set; }

        public FlightIntineraryStatus Status { get; set; }
    }

    public enum FlightIntineraryStatus
    {
        Ok = 1,
        late = 2,
        canceled = 3
    }
}
