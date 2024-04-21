using Domain.Dtos.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.FlightAggregate
{
    public interface IFlightService
    {
        Task<FlightDto> Get(Guid id);
        Task<List<FlightDto>> GetAll();
        Task<List<FlightDto>> GetFlightsByDate(DateTime date);
        Task<FlightDto> GetFlightsByDate(DateOnly dateOnly);
        Task<FlightDtoCreateResult> Post(FlightDtoCreate flight);
        Task<FlightDtoUpdateResult> Put(FlightDtoUpdate flight);
    }
}
