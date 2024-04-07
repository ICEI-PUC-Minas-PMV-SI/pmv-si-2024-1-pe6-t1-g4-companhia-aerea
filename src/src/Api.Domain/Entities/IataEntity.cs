using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class IataEntity : BaseEntity
    {
        public string IATACode { get; set; }
        public string Airport { get; set; }
        public string Location { get; set; }
        public bool Available { get; set; }
    }
}
