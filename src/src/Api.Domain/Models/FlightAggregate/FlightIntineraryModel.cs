using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.FlightAggregate
{
    public class FlightIntineraryModel
    {
        private Guid _id;
        public Guid Id 
        { 
           get { return _id; } 
           set { _id = value; } 
        }

        private string _description;
        public string Description 
        {
            get { return _description; } 
            set {  _description = value; } 
        }

        private bool _available;
        public bool Available 
        { 
            get { return _available; } 
            set {  _available = value; } 
        }

        private DateTime _leaveDate;
        public DateTime LeaveDate 
        { 
            get { return _leaveDate; } 
            set { _leaveDate = value; }
        }

        private DateTime _arriveDate;
        public DateTime ArriveDate 
        { 
            get { return _arriveDate; } 
            set { _arriveDate = value; } 
        }

        private int _leaveIATAId;
        public int LeaveIATAId 
        { 
            get { return _leaveIATAId; } 
            set { _leaveIATAId = value; }
        }

        private int _arriveIATAId;
        public int ArriveIATAId 
        { 
            get { return _arriveIATAId; } 
            set { _arriveIATAId = value; } 
        }
    }
}
