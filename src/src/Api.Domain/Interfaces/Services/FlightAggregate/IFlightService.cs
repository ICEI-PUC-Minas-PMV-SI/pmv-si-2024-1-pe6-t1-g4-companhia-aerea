using Domain.Dtos.PurchaseAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.FlightAggregate
{
    public interface IFlightService
    {

        //Flight
        Task<FlightDto> CreateFlight(FlightDtoCreate flight, Guid userId);
        Task<FlightDto> GetFlight(Guid id);
        Task<IEnumerable<FlightDto>> GetAllFlight();

        //FlightIntinerary
        Task<FlightIntineraryDto> CreateFlightIntinerary(FlightIntineraryDtoCreate flight);
        Task<FlightIntineraryDto> GetFlightIntinerary(Guid id);
        Task<IEnumerable<FlightIntineraryDto>> GetAllFlightIntinerary();


        //Reserve
        Task<ReserveDto> CreateReserve(ReserveDtoCreate reserve);
        Task<ReserveDto> GetReserve(Guid id);
        Task<IEnumerable<ReserveDto>> GetAllReserve();

        //SeatsAvailable
        Task<SeatsAvailableDto> CreateSeatsAvailable(SeatsAvailableDtoCreate seats);
        Task<SeatsAvailableDto> GetSeatsAvailable(Guid id);
        Task<IEnumerable<SeatsAvailableDto>> GetAllSeatsAvailable();

    }
}
