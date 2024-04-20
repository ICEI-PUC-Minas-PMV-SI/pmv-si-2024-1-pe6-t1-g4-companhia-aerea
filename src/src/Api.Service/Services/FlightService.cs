using Domain.Dtos.FlightAggregate;
using Domain.Interfaces.Services.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class FlightService : IFlightService
    {
        public Task<FlightDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FlightDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<FlightDto>> GetFlightsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<FlightDto> GetFlightsByDate(DateOnly dateOnly)
        {
            throw new NotImplementedException();
        }

        public Task<FlightDtoCreateResult> Post(FlightDtoCreate flight)
        {
            throw new NotImplementedException();
        }

        public Task<FlightDtoUpdateResult> Put(FlightDtoUpdate flight)
        {
            throw new NotImplementedException();
        }
    }
}
