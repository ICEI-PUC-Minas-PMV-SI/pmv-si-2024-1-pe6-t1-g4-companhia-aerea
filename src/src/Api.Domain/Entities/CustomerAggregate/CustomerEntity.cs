using System;

namespace Api.Domain.Entities.CustomerAggregate
{
    public class CustomerEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public DateTime DateBirth { get; set; }
        public CustomerStatus StatusId { get; set; }
        public Guid NationalityId { get; set; }
        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
        public Guid PhoneId { get; set; }
        public Guid? CareerId { get; set; }


        public CustomerEntity()
        {

        }
    }

    public enum CustomerStatus
    {
        Active = 1,
        Inactive = 2,
        Blocked = 3
    }


}
