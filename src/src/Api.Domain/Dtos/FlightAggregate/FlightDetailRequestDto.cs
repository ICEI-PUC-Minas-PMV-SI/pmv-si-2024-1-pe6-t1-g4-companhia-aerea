using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightDetailRequestDto
    {
        public string FromIataCode { get; set; }
        public string ToIataCode { get; set; }
        public DateTime DepeartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
