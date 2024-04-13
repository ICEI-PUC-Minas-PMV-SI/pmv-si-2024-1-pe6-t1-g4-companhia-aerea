using Api.Domain.Entities.CustomerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.CustomerAggregate
{
    public class PhoneDto
    {
        public Guid Id { get; set; }
        public string CountryCode { get; set; }
        public string DDD { get; set; }
        public string Number { get; set; }
        public int TypePhone { get; set; }
    }
}
