using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightInfoResponseDto
    {
        public List<FlightDetailResponseDto> DepartureFlights { get; set; }
        public List<FlightDetailResponseDto> ReturnFlights { get; set; }
    }

    public class FlightDetailResponseDto
    {
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string Duration { get; set; }
        public string PriceBusiness { get; set; }
        public string PriceEconomy { get; set; }
    }
}
