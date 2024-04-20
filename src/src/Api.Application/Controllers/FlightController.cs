using Domain.Interfaces.Services.FlightAggregate;
using Microsoft.AspNetCore.Mvc;

namespace application.Controllers
{
    public class FlightController : CustomController
    {
        public IFlightService _flightService { get; set; }
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

    }
}
