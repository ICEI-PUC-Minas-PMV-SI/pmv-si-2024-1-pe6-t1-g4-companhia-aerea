using Api.Domain.Entities.CustomerAggregate;
using Api.Domain.Entities.FlightAggregate;
using Api.Domain.Interfaces.Services.PurchaseAggregate;
using Api.Domain.Repository;
using AutoMapper;
using Domain.Dtos.CustomerAggregate;
using Domain.Dtos.FlightAggregate;
using Domain.Dtos.PurchaseAggregate;
using Domain.Entities.FlightAggregate;
using Domain.Entities.PaymentAggregate;
using Domain.Entities.PurchaseAggregate;
using Domain.Interfaces.Services.FlightAggregate;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class FlightService : IFlightService
    {
        private IFlightRepository _repository;
        private readonly IMapper _mapper;
        public FlightService(IFlightRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<FlightDto> CreateFlight(FlightDtoCreate flight, Guid userId)
        {
            var flightEntity = new FlightEntity()
            {
                Id = Guid.NewGuid(),
                FlightCode = flight.FlightCode,
                FlightIntineraryId = flight.FlightIntineraryId,
                SeatsAvailableId = flight.SeatsAvailableId,
                UserId = userId,
                CreatedAt = DateTime.UtcNow,
            };
            var fliDb = await _repository.InsertFlightAsync(flightEntity);

            var flightResult = new FlightDto()
            {
                Id = fliDb.Id,
                FlightCode = fliDb.FlightCode,
                FlightIntineraryId = fliDb.FlightIntineraryId,
                SeatsAvailableId = fliDb.SeatsAvailableId,
                CreatedAt = fliDb.CreatedAt.Value,
            };
            return flightResult;
        }

        public async Task<FlightDto> GetFlight(Guid id)
        {
            var fliDb = await _repository.GetFlightById(id);

            return new FlightDto()
            {
                Id = fliDb.Id,
                FlightCode = fliDb.FlightCode,
                FlightIntineraryId = fliDb.FlightIntineraryId,
                SeatsAvailableId = fliDb.SeatsAvailableId,
                CreatedAt = fliDb.CreatedAt.Value,
            };
        }

        public async Task<IEnumerable<FlightDto>> GetAllFlight()
        {
            var listEntity = await _repository.GetAllFlight();
            var listDto = new List<FlightDto>();

            foreach (var flight in listEntity)
            {
                var dto = new FlightDto()
                {
                    Id = flight.Id,
                    FlightCode = flight.FlightCode,
                    FlightIntineraryId = flight.FlightIntineraryId,
                    SeatsAvailableId = flight.SeatsAvailableId,
                    CreatedAt = flight.CreatedAt.Value,
                };
                listDto.Add(dto);
            }

            return listDto;
        }

        public async Task<FlightIntineraryDto> CreateFlightIntinerary(FlightIntineraryDtoCreate flight)
        {
            var flightEntity = new FlightIntineraryEntity()
            {
                Id = Guid.NewGuid(),
                Description = flight.Description,
                LeaveDate = flight.LeaveDate,
                ArriveDate = flight.ArriveDate,
                LeaveIATAId = flight.LeaveIATAId,
                ArriveIATAId = flight.ArriveIATAId,
                CreatedAt = DateTime.UtcNow,
            };
            var fliDb = await _repository.InsertFlightIntineraryAsync(flightEntity);

            var flightResult = new FlightIntineraryDto()
            {
                Id = fliDb.Id,
                Description = fliDb.Description,
                LeaveDate = fliDb.LeaveDate,
                ArriveDate = fliDb.ArriveDate,
                LeaveIATAId = fliDb.LeaveIATAId,
                ArriveIATAId = fliDb.ArriveIATAId,
                CreatedAt = fliDb.CreatedAt.Value,
            };
            return flightResult;
        }

        public async Task<FlightIntineraryDto> GetFlightIntinerary(Guid id)
        {
            var fliDb = await _repository.GetFlightIntineraryById(id);

            return new FlightIntineraryDto()
            {
                Id = fliDb.Id,
                Description = fliDb.Description,
                LeaveDate = fliDb.LeaveDate,
                ArriveDate = fliDb.ArriveDate,
                LeaveIATAId = fliDb.LeaveIATAId,
                ArriveIATAId = fliDb.ArriveIATAId,
                CreatedAt = fliDb.CreatedAt.Value,
            };
        }

        public async Task<IEnumerable<FlightIntineraryDto>> GetAllFlightIntinerary()
        {
            var listEntity = await _repository.GetAllFlightIntinerary();
            var listDto = new List<FlightIntineraryDto>();

            foreach (var flight in listEntity)
            {
                var dto = new FlightIntineraryDto()
                {
                    Id = flight.Id,
                    Description = flight.Description,
                    LeaveDate = flight.LeaveDate,
                    ArriveDate = flight.ArriveDate,
                    LeaveIATAId = flight.LeaveIATAId,
                    ArriveIATAId = flight.ArriveIATAId,
                    CreatedAt = flight.CreatedAt.Value,
                };
                listDto.Add(dto);
            }

            return listDto;
        }

        public async Task<ReserveDto> CreateReserve(ReserveDtoCreate reserve)
        {
            var reserveEntity = new ReserveEntity()
            {
                Id = Guid.NewGuid(),
                ReserveCode = ReserveEntity.GenerateReserveCode(),
                ExtraLuggage = reserve.ExtraLuggage,
                FlightId = reserve.FlightId,
                CustomerId = reserve.CustomerId,
                CreatedAt = DateTime.UtcNow,
            };
            var reserveDb = await _repository.InsertReserveAsync(reserveEntity);

            var reserveResult = new ReserveDto()
            {
                Id = reserveDb.Id,
                ReserveCode = reserveDb.ReserveCode,
                ExtraLuggage = reserveDb.ExtraLuggage,
                FlightId = reserveDb.FlightId,
                CustomerId = reserveDb.CustomerId,
                CreatedAt = reserveDb.CreatedAt.Value
            };
            return reserveResult;
        }

        public async Task<ReserveDto> GetReserve(Guid id)
        {
            var reserveDb = await _repository.GetReserveById(id);

            return new ReserveDto()
            {
                Id = reserveDb.Id,
                ReserveCode = reserveDb.ReserveCode,
                ExtraLuggage = reserveDb.ExtraLuggage,
                FlightId = reserveDb.FlightId,
                CustomerId = reserveDb.CustomerId,
                CreatedAt = reserveDb.CreatedAt.Value
            };
        }

        public async Task<IEnumerable<ReserveDto>> GetAllReserve()
        {
            var listEntity = await _repository.GetAllReserve();
            var listDto = new List<ReserveDto>();

            foreach (var reserveDb in listEntity)
            {
                var dto = new ReserveDto()
                {
                    Id = reserveDb.Id,
                    ReserveCode = reserveDb.ReserveCode,
                    ExtraLuggage = reserveDb.ExtraLuggage,
                    FlightId = reserveDb.FlightId,
                    CustomerId = reserveDb.CustomerId,
                    CreatedAt = reserveDb.CreatedAt.Value
                };
                listDto.Add(dto);
            }

            return listDto;
        }

        public async Task<SeatsAvailableDto> CreateSeatsAvailable(SeatsAvailableDtoCreate seats)
        {
            var seatsEntity = new SeatsAvailableEntity()
            {
                Id = Guid.NewGuid(),
                Column = seats.Column,
                Row = seats.Row,
                Class = (ClassSeatsAvailable)seats.Class,
                Available = true,
                Price = seats.Price,
                CreatedAt = DateTime.UtcNow,
            };

            var seatsDb = await _repository.InsertSeatsAvailableAsync(seatsEntity);

            var seatsResult = new SeatsAvailableDto()
            {
                Id = seatsDb.Id,
                Column = seatsDb.Column,
                Row = seatsDb.Row,
                Class = seatsDb.Class,
                Price = seatsDb.Price,
                Available = seatsDb.Available,
                CreatedAt = seatsDb.CreatedAt.Value 
            };
            return seatsResult;
        }

        public async Task<SeatsAvailableDto> GetSeatsAvailable(Guid id)
        {
            var seatsDb = await _repository.GetSeatsAvailableById(id);

            return new SeatsAvailableDto()
            {
                Id = seatsDb.Id,
                Column = seatsDb.Column,
                Row = seatsDb.Row,
                Class = seatsDb.Class,
                Price = seatsDb.Price,
                Available = seatsDb.Available,
                CreatedAt = seatsDb.CreatedAt.Value
            };
        }

        public async Task<IEnumerable<SeatsAvailableDto>> GetAllSeatsAvailable()
        {
            var listEntity = await _repository.GetAllSeatsAvailable();
            var listDto = new List<SeatsAvailableDto>();

            foreach (var seatsDb in listEntity)
            {
                var dto = new SeatsAvailableDto()
                {
                    Id = seatsDb.Id,
                    Column = seatsDb.Column,
                    Row = seatsDb.Row,
                    Class = seatsDb.Class,
                    Price = seatsDb.Price,
                    Available = seatsDb.Available,
                    CreatedAt = seatsDb.CreatedAt.Value
                };
                listDto.Add(dto);
            }

            return listDto;
        }
    }
}
