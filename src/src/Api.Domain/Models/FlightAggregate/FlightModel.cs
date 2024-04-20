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

        private Guid _seatsAvailableId;
        public Guid SeatsAvailableId
        {
            get { return _seatsAvailableId; }
            set { _seatsAvailableId = value; }
        }

        private int _flightStatusId;
        public int FlightStatusId
        {
            get { return _flightStatusId; }
            set { _flightStatusId = value; }
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
