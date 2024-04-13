using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities.CustomerAggregate
{
    public class PhoneEntity : BaseEntity
    {
        public string CountryCode { get; set; }
        public string DDD { get; set; }
        public string Number { get; set; }
        public TypePhone TypePhone { get; set; }
    }

    public enum TypePhone
    {
        Mobile = 1,
        Home = 2,
        Work = 3
    }
}
