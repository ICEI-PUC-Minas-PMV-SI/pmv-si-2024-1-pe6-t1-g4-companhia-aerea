using Domain.Dtos.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.FlightAggregate
{
    public interface IFlightIntineraryService
    {
        Task<FlightIntineraryDto> Get(Guid id);
        Task<List<FlightIntineraryDto>> GetAll();
        Task<FlightIntineraryDtoCreateResult> Post(FlightIntineraryDtoCreate flightIntinerary);
        Task<FlightIntineraryDtoUpdateResult> Put(FlightIntineraryDtoUpdate flightIntinerary);
    }
}
