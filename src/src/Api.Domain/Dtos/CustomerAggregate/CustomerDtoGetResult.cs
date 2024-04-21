using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.CustomerAggregate
{
    public class CustomerDtoGetResult
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public DateTime DateBirth { get; set; }
        public Guid NationalityId { get; set; }
        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
        public Guid PhoneId { get; set; }
        public Guid? CareerId { get; set; }
    }
}
