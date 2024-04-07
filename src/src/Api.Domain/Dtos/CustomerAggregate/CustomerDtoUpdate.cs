using System;

namespace Api.Domain.Dtos.CustomerAggregate
{
    public class CustomerDtoUpdate : CustomerDtoCreate
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public Guid PhoneId { get; set; }
    }
}
