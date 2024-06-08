using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class ReserveEntity:BaseEntity
    {
        public string ReserveCode {  get; set; }
        public ReserveStatus ReserveStatus { get; set; }
        public bool ExtraLuggage {  get; set; }
        public Guid CustomerEntityId {  get; set; }
        public Guid FlightEntityId { get; set; }
        public FlightEntity Flight { get; set; } // Navigation property
    }
    public enum ReserveStatus
    {
        NotConfirmed = 0, Confirmed = 1
    }
}
