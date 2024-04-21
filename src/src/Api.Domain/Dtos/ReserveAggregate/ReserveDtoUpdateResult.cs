using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.ReserveAggregate
{
    public class ReserveDtoUpdateResult
    {
        public string ReserveCode { get; set; }
        public ReserveStatus Status { get; set; }
        public bool ExtraLuggage { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
