using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FlightEntity : BaseEntity
    {
        public string FlightCode { get; set; }
        public Guid FlightIntineraryId { get; set; }
        public Guid SeatsAvailableId { get; set; }
        public int FlightStatusId { get; set; }
    }
}
