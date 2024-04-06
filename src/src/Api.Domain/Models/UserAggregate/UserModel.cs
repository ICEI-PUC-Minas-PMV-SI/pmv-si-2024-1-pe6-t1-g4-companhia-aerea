using System;

namespace Api.Domain.Models.UserAggregate
{
    public class UserModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _dateBirth;
        public string DateBirth
        {
            get { return _dateBirth; }
            set
            {
                _dateBirth = value;
            }
        }

        private int _status;
        public int Status
        {
            get { return _status; }
            set
            {
                _status = value == 0 ? 1 : value;
            }
        }

        private int _typeUser;
        public int TypeUser
        {
            get { return _typeUser; }
            set
            {
                _typeUser = value == 0 ? 2 : value;
            }
        }

        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set
            {
                _createAt = value == null ? DateTime.UtcNow : value;
            }
        }

        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }


    }
}
