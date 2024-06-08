using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Api.Domain.Entities;
using System.Runtime.CompilerServices;

namespace Domain.Repository
{
    public interface IReserveRepository:IRepository<ReserveEntity>
    {
       
        //public Task<IEnumerable<ReserveEntity>> GetReserveByCustomer(Guid id);
    }
}
