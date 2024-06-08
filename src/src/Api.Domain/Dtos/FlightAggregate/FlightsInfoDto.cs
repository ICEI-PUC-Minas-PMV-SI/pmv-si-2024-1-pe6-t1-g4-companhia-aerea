using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightsInfoDto
    {
        public List<FlightDetailDto> DepartureFlights { get; set; }
        public List<FlightDetailDto> ReturnFlights { get; set; }
    }

    public class FlightDetailDto
    {
        public string FlightCode { get; set; }
        public string Description { get; set; }
        public DateTime LeaveDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public string LeaveIATACode  { get; set; }
        public string ArriveIATACode { get; set; }
        public string LeaveAirport { get; set; }
        public string ArriveAirport { get; set; }
        public string LeaveLocation { get; set; } 
        public string ArriveLocation { get; set; }
        public decimal PriceExecutive { get; set; }
        public decimal PriceEconomy { get; set; }

    }
}
