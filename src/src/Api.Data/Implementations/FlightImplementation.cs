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
using Domain.Entities.FlightAggregate;

namespace Data.Implementations
{
    public class FlightImplementation : BaseRepository<FlightEntity>, IFlightRepository
    {
        private DbSet<FlightEntity> _dbFlight;
        private DbSet<IataEntity> _dbIata;
        public FlightImplementation(MyContext context) : base(context)
        {
            _dbFlight = context.Set<FlightEntity>();
            _dbIata = context.Set<IataEntity>();
        }

        public async Task<IataEntity> InsertIata(IataEntity entity)
        {
            try
            {
                entity.Id = entity.Id == Guid.Empty ? Guid.NewGuid() : entity.Id;
                entity.CreatedAt = DateTime.UtcNow;

                _dbIata.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            return entity;
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
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public async Task<IataEntity> GetIataById(Guid id)
        {
            return await _dbIata.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<List<IataEntity>> GetAllIata()
        {
            try
            {
                return await _dbIata.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
