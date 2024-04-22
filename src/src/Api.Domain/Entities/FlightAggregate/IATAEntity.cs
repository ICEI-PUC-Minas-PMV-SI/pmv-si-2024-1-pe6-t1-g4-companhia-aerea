using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.FlightAggregate
{
    public class IATAEntity : BaseEntity
    {
        public string IATACode { get; set; }
        public string Airport { get; set; }
        public string Location { get; set; }
    }
}
