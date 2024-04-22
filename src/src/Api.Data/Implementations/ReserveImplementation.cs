using Api.Data;
using Api.Data.Repository;
using Api.Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class ReserveImplementation : BaseRepository<ReserveEntity>, IReserveRepository
    {
        private DbSet<ReserveEntity> _dataset;

        public ReserveImplementation(MyContext context):base(context) 
        {
           _dataset = context.Set<ReserveEntity>(); 
        }
        public async Task<IEnumerable<ReserveEntity>> GetReserveByCustomer(Guid id)
        {
            return await _dataset.Where(r=>r.CustomerId == id).ToListAsync();
        }
    }
}
