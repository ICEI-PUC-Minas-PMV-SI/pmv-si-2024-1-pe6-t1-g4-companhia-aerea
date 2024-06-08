using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.FlightAggregate
{
    public class FlightModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _flightCode;
        public string FlightCode
        {
            get { return _flightCode; }
            set { _flightCode = value; }
        }

        private Guid _flightIntineraryId;
        public Guid FlightIntineraryId
        {
            get { return _flightIntineraryId; }
            set { _flightIntineraryId = value; }
        }

       

        private FlightStatus _flightStatus;
        public FlightStatus FlightStatus
        {
            get { return _flightStatus; }
            set { _flightStatus = value; }
        }

        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == default ? DateTime.UtcNow : value; }
        }

        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }

    }
}
