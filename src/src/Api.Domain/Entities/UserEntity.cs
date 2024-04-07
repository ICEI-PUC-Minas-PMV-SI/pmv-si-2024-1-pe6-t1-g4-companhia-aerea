
using System;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateBirth { get; set; }
        public UserStatus Status { get; set; }
        public TypeUser TypeUser { get; set; }
    }

    public enum UserStatus
    {
        Active = 1,
        Inactive = 2,
        Blocked = 3
    }

    public enum TypeUser
    {
        Admin = 1,
        Regular = 2
    }


}
