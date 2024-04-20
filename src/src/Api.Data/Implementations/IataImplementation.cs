using Api.Data;
using Api.Data.Repository;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class IataImplementation : BaseRepository<IataEntity>, IIataRepository
    {
        private DbSet<IataEntity> _dbIata;
        public IataImplementation(MyContext context) : base(context)
        {
            _dbIata =  context.Set<IataEntity>();
        }

        public async Task<List<IataEntity>> GetAll()
        {
            try
            {
                return await _dbIata.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IataEntity> GetIataById(Guid id)
        {
            try
            {
                return await _dbIata.SingleOrDefaultAsync(s => s.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IataEntity> InsertIata(IataEntity entity)
        {
            try
            {
                entity.Id = entity.Id == Guid.Empty ? Guid.NewGuid() : entity.Id;
                entity.CreatedAt = DateTime.UtcNow;

                _dbIata.Add(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IataEntity> UpdateIata(IataEntity entity)
        {
            try
            {
                var result = await _dbIata.SingleOrDefaultAsync(p => p.Id.Equals(entity.Id));
                if (result == null) return null;

                entity.CreatedAt = result.CreatedAt;
                entity.UpdateAt = DateTime.UtcNow;

                _context.Entry(result).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
