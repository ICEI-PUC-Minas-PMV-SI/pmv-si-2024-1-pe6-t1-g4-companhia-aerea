using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class IataDtoCreateResult
    {
        public Guid Id { get; set; }
        public string IATACode { get; set; }
        public string Airport { get; set; }
        public string Location { get; set; }
        public bool Available { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
