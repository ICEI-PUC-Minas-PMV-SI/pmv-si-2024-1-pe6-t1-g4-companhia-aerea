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
using Domain.Dtos.FlightAggregate;
using System.Data;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MySqlConnector;


namespace Data.Implementations
{

    public class FlightImplementation : BaseRepository<FlightEntity>, IFlightRepository
    {
        private DbSet<FlightEntity> _dbFlight;
        private DbSet<IataEntity> _dbIata;
        private DbSet<FlightItineraryEntity> _dbItinerary;
        private DbSet<SeatsEntity> _dbSeats;

        private MyContext _myContext;


        public FlightImplementation(MyContext context) : base(context)
        {
            _dbFlight = context.Set<FlightEntity>();
            _dbIata = context.Set<IataEntity>();
            _dbSeats = context.Set<SeatsEntity>();
            _dbItinerary = context.Set<FlightItineraryEntity>();
            _myContext = context;
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

        private async Task<List<FlightDetailDto>> GetFlightDetail(DateTime filterDate, string leaveIATA, string arriveIATA)
        {
            List<FlightDetailDto> flights = FlightDetailData.GetFlights()
                .Where(flight =>
                    flight.LeaveDate.Date == filterDate.Date
                    && flight.LeaveIATACode.ToLower() == leaveIATA.ToLower()
                    && flight.ArriveIATACode.ToLower() == arriveIATA.ToLower()
                )
                .ToList();

            return flights;


            //var sql = @"
            //select distinct 
            //    f.id,
            //    i.Description,
            //    i.LeaveDate,
            //    i.ArriveDate,
            //    ia.IATACode,
            //    ia.Airport,
            //    ia.Location,
            //    s.price
            //    From uaiflydb.flights f
            //    LEFT JOIN uaiflydb.intinerary i ON i.id = f.flightintineraryId
            //    LEFT JOIN uaiflydb.iata ia ON ia.id = i.LeaveIATAId
            //    LEFT JOIN uaiflydb.seats s ON s.FlightId = f.id
            //    WHERE s.Price IS NOT null
            //    AND i.LeaveDate::date = {filterDate:yyyy-MM-dd}
            //    AND ia.IATACode = {leaveIATA}
            //    AND ia.IATACode = {arriveIATA}";

            //var results = await _myContext.Set<FlightDetailDto>()
            //    .FromSqlRaw(sql)
            //    .ToListAsync();

            //return results;


        }

        public async Task<FlightsInfoDto> SearchFlights(FlightDetailRequestDto request)
        {
            try
            {
                var flightInfo = new FlightsInfoDto()
                {
                    DepartureFlights = new List<FlightDetailDto>(),
                    ReturnFlights = new List<FlightDetailDto>(),
                };


                var departureFlights = GetFlightDetail(request.DepeartureDate, request.FromIataCode, request.ToIataCode);
                flightInfo.DepartureFlights = await departureFlights;

                if (request.ReturnDate.HasValue)
                {
                    var returnFlights = GetFlightDetail(request.ReturnDate.Value, request.ToIataCode, request.FromIataCode);
                    flightInfo.ReturnFlights = await returnFlights;
                }


                return flightInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private SeatsAvailableDTO GetSeatsAvailable()
        {
            List<string> flightCodes = new List<string>
            {
                "AD 0910", "AD 2021", "AD 1617", "AD 0809", "VO 0809", "VO 1718", "LA 9102"
            };
            return new SeatsAvailableDTO() { };
        }

        public Task<SearchSeatsResponse> SearchSeats(SearchSeatsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
