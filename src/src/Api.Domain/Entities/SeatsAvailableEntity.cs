using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SeatsAvailableEntity:BaseEntity
    {
        public string Column {  get; set; }
        public string Row { get; set; }
        public string Class {  get; set; }
        public bool Available {  get; set; }
        public Guid FlightEntityId { get; set; }
    }
}
