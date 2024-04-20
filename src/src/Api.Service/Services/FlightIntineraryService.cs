using Domain.Dtos.FlightAggregate;
using Domain.Interfaces.Services.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class FlightIntineraryService : IFlightIntineraryService
    {
        public Task<FlightIntineraryDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FlightIntineraryDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<FlightIntineraryDtoCreateResult> Post(FlightIntineraryDtoCreate flightIntinerary)
        {
            throw new NotImplementedException();
        }

        public Task<FlightIntineraryDtoUpdateResult> Put(FlightIntineraryDtoUpdate flightIntinerary)
        {
            throw new NotImplementedException();
        }
    }
}
