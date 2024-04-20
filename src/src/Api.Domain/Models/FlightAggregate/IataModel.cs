using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.FlightAggregate
{
    public class IataModel
    {
        private Guid _id;
        public Guid Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }

        private string _iataCode;
        public string IataCode 
        { 
            get { return _iataCode; } 
            set { _iataCode = value; } 
        }

        private string _airport;
        public string Airport 
        { 
            get { return _airport; } 
            set { _airport = value; }
        }

        private string _location;
        public string Location 
        { 
            get { return _location; } 
            set { _location = value; } 
        }

        private bool _available;
        public bool Available 
        { 
            get { return _available; } 
            set {  _available = value; } 
        }
    }
}
