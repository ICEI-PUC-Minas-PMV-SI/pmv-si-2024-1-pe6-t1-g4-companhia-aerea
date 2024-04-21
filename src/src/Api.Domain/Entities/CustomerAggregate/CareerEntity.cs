using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities.CustomerAggregate
{
    public class CareerEntity : BaseEntity
    {
        public string Description { get; set; }
        public string Note { get; set; }
        public double AverageWage { get; set; }
    }
}
