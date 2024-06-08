using AutoMapper;
using Domain.Dtos.FlightAggregate;
using Domain.Entities;
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
        private IFlightRepository _flightRepository;
        private readonly IMapper _mapper;
        public FlightService(IFlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public async Task<FlightDto> Get(Guid id)
        {
            var entity = await _flightRepository.GetFlightById(id);
            var flightDto = _mapper.Map<FlightDto>(entity);

            return flightDto;
        }

        public async Task<List<FlightDto>> GetAll()
        {
            var entity = await _flightRepository.GetAll();
            var flightDto = _mapper.Map<List<FlightDto>>(entity);

            return flightDto;
        }

        public Task<List<FlightDto>> GetFlightsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<FlightDto> GetFlightsByDate(DateOnly dateOnly)
        {
            throw new NotImplementedException();
        }

        public async Task<FlightDtoCreateResult> Post(FlightDtoCreate flight)
        {
            var flightEntity = new FlightEntity()
            {
                FlightCode = flight.FlightCode,
                FlightIntineraryEntityId = flight.FlightIntineraryId,
                FlightStatus = flight.FlightStatus,
            };

            var result = await _flightRepository.InsertAsync(flightEntity);
            var flightResult = new FlightDtoCreateResult()
            {
                Id = result.Id,
                FlightCode = result.FlightCode,
                FlightIntineraryId = result.FlightIntineraryEntityId,
                FlightStatus = result.FlightStatus,
              
            };

            return flightResult;
        }

        public async Task<FlightDtoUpdateResult> Put(FlightDtoUpdate flight)
        {
            var flightDb = await _flightRepository.GetFlightById(flight.Id);

            if (flightDb != null)
            {
                var flightEntity = new FlightEntity()
                {
                    FlightCode = flightDb.FlightCode,
                    FlightIntineraryEntityId = flightDb.FlightIntineraryEntityId,
                    FlightStatus = flightDb.FlightStatus,
                };

                var result = await _flightRepository.UpdateAsync(flightEntity);

                var resultUpdate = new FlightDtoUpdateResult()
                {
                    FlightStatus = result.FlightStatus
                };

                return resultUpdate;
            }
            return null;
        }
    }
}
