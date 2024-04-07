using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.CustomerAggregate
{
    public class CustomerDto
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

        public string NationalityDescription { get; set; }
        public string CompleteAddress { get; set; }
        public string UserCompleteName { get; set; }
        public string PhoneCompleteNumber { get; set; }
        public string CareerDescription { get; set; }
    }
}
