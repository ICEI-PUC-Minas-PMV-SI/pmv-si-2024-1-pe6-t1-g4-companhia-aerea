using System;

namespace Api.Domain.Dtos.UserAggregate
{
    public class UserDtoUpdateResult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DateBirth { get; set; }
        public string Password { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
