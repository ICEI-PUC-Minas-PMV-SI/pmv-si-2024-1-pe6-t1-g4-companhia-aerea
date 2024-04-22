using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class ReserveDto
    {
        public Guid Id { get; set; }
        public string ReserveCode { get; set; }
        public bool ExtraLuggage { get; set; }

        public Guid FlightId { get; set; }
        public Guid CustomerId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
