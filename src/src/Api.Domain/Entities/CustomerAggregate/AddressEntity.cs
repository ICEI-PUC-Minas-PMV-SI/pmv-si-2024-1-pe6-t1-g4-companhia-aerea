using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities.CustomerAggregate
{
    public class AddressEntity : BaseEntity
    {
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
    }
}
