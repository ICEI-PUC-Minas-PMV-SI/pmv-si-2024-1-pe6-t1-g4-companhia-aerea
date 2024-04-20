using Api.Data;
using Api.Data.Repository;
using Api.Domain.Entities.CustomerAggregate;
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
    public class FlightIntineraryImplementation : BaseRepository<FlightIntineraryEntity>, IFlightIntineraryRepository
    {
        private DbSet<FlightIntineraryEntity> _dbFlightIntinerary;
        public FlightIntineraryImplementation(MyContext context) : base(context)
        {
            _dbFlightIntinerary = context.Set<FlightIntineraryEntity>();
        }

        public async Task<List<FlightIntineraryEntity>> GetAll()
        {
            try
            {
                return await _dbFlightIntinerary.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FlightIntineraryEntity> GetFlightIntineraryById(Guid id)
        {
            try
            {
                return await _dbFlightIntinerary.SingleOrDefaultAsync(s => s.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FlightIntineraryEntity> InsertFlightIntinerary(FlightIntineraryEntity entity)
        {
            try
            {
                entity.Id = entity.Id == Guid.Empty ? Guid.NewGuid() : entity.Id;
                entity.CreatedAt = DateTime.UtcNow;

                _dbFlightIntinerary.Add(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FlightIntineraryEntity> UpdateFlightIntinerary(FlightIntineraryEntity entity)
        {
            try
            {
                var result = await _dbFlightIntinerary.SingleOrDefaultAsync(p => p.Id.Equals(entity.Id));
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
