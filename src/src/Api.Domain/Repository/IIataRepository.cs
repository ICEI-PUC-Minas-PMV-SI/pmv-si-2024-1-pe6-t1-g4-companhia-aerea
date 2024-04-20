using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IIataRepository
    {
        Task<IataEntity> InsertIata(IataEntity entity);
        Task<IataEntity> UpdateIata(IataEntity entity);
        Task<IataEntity> GetIataById(Guid id);
        Task<List<IataEntity>> GetAll();
    }
}
