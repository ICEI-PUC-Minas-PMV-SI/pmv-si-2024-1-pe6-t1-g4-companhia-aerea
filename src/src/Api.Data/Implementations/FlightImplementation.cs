using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Data.Repository;
using Api.Domain.Entities.CustomerAggregate;
using Api.Domain.Entities.FlightAggregate;
using Api.Domain.Repository;
using Domain.Dtos.CustomerAggregate;
using Domain.Entities.FlightAggregate;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class FlightImplementation : BaseRepository<FlightEntity>, IFlightRepository
    {
        private DbSet<FlightEntity> _dbFlight;
        private DbSet<FlightIntineraryEntity> _dbFlightIntinerary;
        private DbSet<ReserveEntity> _dbReserve;
        private DbSet<AddressEntity> _dbAddress;
        private DbSet<SeatsAvailableEntity> _dbSeats;
        public FlightImplementation(MyContext context) : base(context)
        {
            _dbFlight = context.Set<FlightEntity>();
            _dbFlightIntinerary = context.Set<FlightIntineraryEntity>();
            _dbReserve = context.Set<ReserveEntity>();
            _dbAddress = context.Set<AddressEntity>();
            _dbSeats = context.Set<SeatsAvailableEntity>();
        }

        public async Task<IEnumerable<FlightEntity>> GetAllFlight()
        {
            try
            {
                return await _dbFlight.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<FlightIntineraryEntity>> GetAllFlightIntinerary()
        {
            try
            {
                return await _dbFlightIntinerary.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<ReserveEntity>> GetAllReserve()
        {
            try
            {
                return await _dbReserve.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<SeatsAvailableEntity>> GetAllSeatsAvailable()
        {
            try
            {
                return await _dbSeats.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<FlightEntity> GetFlightById(Guid id)
        {
            return await _dbFlight.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<FlightIntineraryEntity> GetFlightIntineraryById(Guid id)
        {
            return await _dbFlightIntinerary.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<ReserveEntity> GetReserveById(Guid id)
        {
            return await _dbReserve.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<SeatsAvailableEntity> GetSeatsAvailableById(Guid id)
        {
            return await _dbSeats.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<FlightEntity> InsertFlightAsync(FlightEntity flight)
        {
            try
            {
                flight.Id = flight.Id == Guid.Empty ? Guid.NewGuid() : flight.Id;
                flight.CreatedAt = DateTime.UtcNow;

                _dbFlight.Add(flight);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flight;
        }

        public async Task<FlightIntineraryEntity> InsertFlightIntineraryAsync(FlightIntineraryEntity flight)
        {
            try
            {
                flight.Id = flight.Id == Guid.Empty ? Guid.NewGuid() : flight.Id;
                flight.CreatedAt = DateTime.UtcNow;

                _dbFlightIntinerary.Add(flight);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flight;
        }

        public async Task<ReserveEntity> InsertReserveAsync(ReserveEntity reserve)
        {
            try
            {
                reserve.Id = reserve.Id == Guid.Empty ? Guid.NewGuid() : reserve.Id;
                reserve.CreatedAt = DateTime.UtcNow;

                _dbReserve.Add(reserve);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reserve;
        }

        public async Task<SeatsAvailableEntity> InsertSeatsAvailableAsync(SeatsAvailableEntity seats)
        {
            try
            {
                seats.Id = seats.Id == Guid.Empty ? Guid.NewGuid() : seats.Id;
                seats.CreatedAt = DateTime.UtcNow;

                _dbSeats.Add(seats);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return seats;
        }
    }
}
