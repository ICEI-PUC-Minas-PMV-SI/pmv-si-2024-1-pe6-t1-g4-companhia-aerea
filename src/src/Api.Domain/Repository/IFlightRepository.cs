using Api.Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.FlightAggregate;
using Domain.Dtos.FlightAggregate;

namespace Domain.Repository
{
    public interface IFlightRepository : IRepository<FlightEntity>
    {
        // Task<FlightEntity> InsertFlight(FlightEntity entity);
        // Task<FlightEntity> UpdateFlight(FlightEntity entity);
        // Task<FlightEntity> GetFlightById(Guid id);
        // Task<List<FlightEntity>> GetAll();
        
        Task<IataEntity> InsertIata(IataEntity entity);
        Task<IataEntity> UpdateIata(IataEntity entity);
        Task<IataEntity> GetIataById(Guid id);
        Task<List<IataEntity>> GetAllIata();
        Task<FlightsInfoDto> SearchFlights(FlightDetailRequestDto request);
        Task<SearchSeatsResponse> SearchSeats(SearchSeatsRequest request);

    }
}
