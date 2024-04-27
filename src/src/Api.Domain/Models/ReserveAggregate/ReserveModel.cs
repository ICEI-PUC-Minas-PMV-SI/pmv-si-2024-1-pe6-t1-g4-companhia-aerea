using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.ReserveAggregate
{
    public class ReserveModel
    {
        public Guid Id { get; set; }
        public string ReserveCode { get; set; }
        public ReserveStatus Status { get; set; }
        public bool ExtraLuggage { get; set; }
        public Guid CustomerId { get; set; }
        public Guid FlightId { get; set; }
       
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}
