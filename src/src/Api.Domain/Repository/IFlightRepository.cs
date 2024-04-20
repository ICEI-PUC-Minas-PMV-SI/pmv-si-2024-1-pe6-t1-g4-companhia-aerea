using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IFlightRepository
    {
        Task<FlightEntity> InsertFlight(FlightEntity entity);
        Task<FlightEntity> UpdateFlight(FlightEntity entity);
        Task<FlightEntity> GetFlightById(Guid id);
        Task<List<FlightEntity>> GetAll();
    }
}
