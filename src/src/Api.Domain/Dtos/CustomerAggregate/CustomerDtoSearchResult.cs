using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.CustomerAggregate
{
    public class CustomerDtoSearchResult
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public DateTime DateBirth { get; set; }
        public Guid NationalityId { get; set; }
        public Guid? CareerId { get; set; }


        public string NationalityDescription { get; set; }
        public string CareerDescription { get; set; }
    }
}
