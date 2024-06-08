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
        // Task<FlightDto> Get(Guid id);
        // Task<List<FlightDto>> GetAll();
        // Task<FlightDtoCreateResult> Post(FlightDtoCreate flight);
        // Task<FlightDtoUpdateResult> Put(FlightDtoUpdate flight);
        
        Task<IataDto> GetIata(Guid id);
        Task<List<IataDto>> GetAllIata();
        Task<IataDtoCreateResult> PostIata(IataDtoCreate iata);
        Task<IataDtoUpdateResult> PutIata(IataDtoUpdate iata);
        Task<FlightInfoResponseDto> SearchFlights(FlightDetailRequestDto request);
        Task<SearchSeatsResponse> SearchSeats(SearchSeatsRequest request);
    }
}
