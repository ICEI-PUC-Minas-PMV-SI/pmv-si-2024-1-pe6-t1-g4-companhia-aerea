using Api.Domain.Entities.FlightAggregate;
using Api.Domain.Interfaces;
using Domain.Entities.FlightAggregate;
using Domain.Entities.PaymentAggregate;
using Domain.Entities.PurchaseAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IFlightRepository : IRepository<FlightEntity>
    {
        //Flight
        Task<FlightEntity> InsertFlightAsync(FlightEntity flight);
        Task<FlightEntity> GetFlightById(Guid id);
        Task<IEnumerable<FlightEntity>> GetAllFlight();

        //FlightIntinerary
        Task<FlightIntineraryEntity> InsertFlightIntineraryAsync(FlightIntineraryEntity flight);
        Task<FlightIntineraryEntity> GetFlightIntineraryById(Guid id);
        Task<IEnumerable<FlightIntineraryEntity>> GetAllFlightIntinerary();

        //Reserve
        Task<ReserveEntity> InsertReserveAsync(ReserveEntity reserve);
        Task<ReserveEntity> GetReserveById(Guid id);
        Task<IEnumerable<ReserveEntity>> GetAllReserve();

        //SeatsAvailable
        Task<SeatsAvailableEntity> InsertSeatsAvailableAsync(SeatsAvailableEntity seats);
        Task<SeatsAvailableEntity> GetSeatsAvailableById(Guid id);
        Task<IEnumerable<SeatsAvailableEntity>> GetAllSeatsAvailable();
    }
}
