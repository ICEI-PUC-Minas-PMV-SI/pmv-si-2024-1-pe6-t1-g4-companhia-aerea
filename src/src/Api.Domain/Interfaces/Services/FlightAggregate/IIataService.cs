using Domain.Dtos.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.FlightAggregate
{
    public interface IIataService
    {
        Task<IataDto> Get(Guid id);
        Task<List<IataDto>> GetAll();
        Task<IataDtoCreateResult> Post(IataDtoCreate iata);
        Task<IataDtoUpdateResult> Put(IataDtoUpdate iata);
    }
}
