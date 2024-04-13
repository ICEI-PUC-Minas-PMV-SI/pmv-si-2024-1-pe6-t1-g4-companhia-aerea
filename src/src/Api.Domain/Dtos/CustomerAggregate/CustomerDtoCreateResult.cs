using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.CustomerAggregate
{
    public class CustomerDtoCreateResult
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

        public string CountryCode { get; set; }
        public string DDD { get; set; }
        public string PhoneNumber { get; set; }
        public int TypePhone { get; set; }

        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }

        public CustomerDtoCreateResult()
        {

        }
    }
}
