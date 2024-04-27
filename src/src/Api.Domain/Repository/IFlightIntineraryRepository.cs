using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IFlightIntineraryRepository
    {
        Task<FlightIntineraryEntity> InsertFlightIntinerary(FlightIntineraryEntity entity);
        Task<FlightIntineraryEntity> UpdateFlightIntinerary(FlightIntineraryEntity entity);
        Task<FlightIntineraryEntity> GetFlightIntineraryById(Guid id);
        Task<List<FlightIntineraryEntity>> GetAll();
    }
}
