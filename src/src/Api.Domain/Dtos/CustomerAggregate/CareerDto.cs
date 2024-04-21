using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.CustomerAggregate
{
    public class CareerDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public double AverageWage { get; set; }
    }
}
