using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities.CustomerAggregate
{
    public class NationalityEntity : BaseEntity
    {
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
