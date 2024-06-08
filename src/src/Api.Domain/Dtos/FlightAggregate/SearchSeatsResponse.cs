using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class SearchSeatsResponse
    {
        public SeatsClass EconomyClass {  get; set; }
        public SeatsClass BusinessClass {  get; set; }
    }

    public class SeatsClass
    {
        public List<string> AvailableSeats { get; set; }
        public List<string> ReservedSeats { get; set; }
    }
}
