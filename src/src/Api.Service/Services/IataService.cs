using Domain.Dtos.FlightAggregate;
using Domain.Interfaces.Services.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class IataService : IIataService
    {
        public Task<IataDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IataDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IataDtoCreateResult> Post(IataDtoCreate iata)
        {
            throw new NotImplementedException();
        }

        public Task<IataDtoUpdateResult> Put(IataDtoUpdate iata)
        {
            throw new NotImplementedException();
        }
    }
}
