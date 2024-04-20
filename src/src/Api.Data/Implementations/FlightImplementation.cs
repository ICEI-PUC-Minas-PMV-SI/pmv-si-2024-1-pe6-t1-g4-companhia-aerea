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
    public class FlightImplementation : BaseRepository<FlightEntity>, IFlightRepository
    {
        private DbSet<FlightEntity> _dbFlight;
        public FlightImplementation(MyContext context) : base(context)
        {
            _dbFlight = context.Set<FlightEntity>();
        }
        public async Task<List<FlightEntity>> GetAll()
        {
            try
            {
                return await _dbFlight.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FlightEntity> GetFlightById(Guid id)
        {
            try
            {
                return await _dbFlight.SingleOrDefaultAsync(s => s.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FlightEntity> InsertFlight(FlightEntity entity)
        {
            try
            {
                entity.Id = entity.Id == Guid.Empty ? Guid.NewGuid() : entity.Id;
                entity.CreatedAt = DateTime.UtcNow;

                _dbFlight.Add(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FlightEntity> UpdateFlight(FlightEntity entity)
        {
            try
            {
                var result = await _dbFlight.SingleOrDefaultAsync(p => p.Id.Equals(entity.Id));
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
