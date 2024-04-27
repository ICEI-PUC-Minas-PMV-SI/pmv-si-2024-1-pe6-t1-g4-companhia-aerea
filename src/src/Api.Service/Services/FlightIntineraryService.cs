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
    public class FlightIntineraryService : IFlightIntineraryService
    {
        private IFlightIntineraryRepository _flightIntineraryRepository;
        private readonly IMapper _mapper;
        public FlightIntineraryService(IFlightIntineraryRepository flightIntineraryRepository, IMapper mapper)
        {
            _flightIntineraryRepository = flightIntineraryRepository;
            _mapper = mapper;
        }
        public async Task<FlightIntineraryDto> Get(Guid id)
        {
            var entity = await _flightIntineraryRepository.GetFlightIntineraryById(id);
            var flightIntDto = _mapper.Map<FlightIntineraryDto>(entity);

            return flightIntDto;
        }

        public async Task<List<FlightIntineraryDto>> GetAll()
        {
            var entity = await _flightIntineraryRepository.GetAll();
            var flightIntDto = _mapper.Map<List<FlightIntineraryDto>>(entity);

            return flightIntDto;
        }

        public async Task<FlightIntineraryDtoCreateResult> Post(FlightIntineraryDtoCreate flightIntinerary)
        {
            var flightIntEntity = new FlightIntineraryEntity()
            {
                Description = flightIntinerary.Description,
                Available = flightIntinerary.Available,
                LeaveDate = flightIntinerary.LeaveDate,
                ArriveDate = flightIntinerary.ArriveDate,
                LeaveIATAId = flightIntinerary.LeaveIATAId,
                ArriveIATAId = flightIntinerary.ArriveIATAId,
            };

            var result = await _flightIntineraryRepository.InsertFlightIntinerary(flightIntEntity);
            var flightIntDto = new FlightIntineraryDtoCreateResult()
            {
                Id = result.Id,
                Description = result.Description,
                Available = result.Available,
                LeaveDate = result.LeaveDate,
                ArriveDate = result.ArriveDate,
                LeaveIATAId = result.LeaveIATAId,
                ArriveIATAId = result.ArriveIATAId,
            };

            return flightIntDto;
        }

        public async Task<FlightIntineraryDtoUpdateResult> Put(FlightIntineraryDtoUpdate flightIntinerary)
        {
            var flightIntDb = await _flightIntineraryRepository.GetFlightIntineraryById(flightIntinerary.Id);

            if (flightIntDb != null)
            {
                var flightIntEntity = new FlightIntineraryEntity()
                {
                    Id = flightIntDb.Id,
                    Description = flightIntDb.Description,
                    Available = flightIntDb.Available,
                    LeaveDate = flightIntDb.LeaveDate,
                    ArriveDate = flightIntDb.ArriveDate,
                    LeaveIATAId = flightIntDb.LeaveIATAId,
                    ArriveIATAId = flightIntDb.ArriveIATAId
                };

                var result = await _flightIntineraryRepository.UpdateFlightIntinerary(flightIntEntity);

                var resultUpd = new FlightIntineraryDtoUpdateResult()
                {
                    Id = result.Id,
                    Description = result.Description,
                    Available = result.Available,
                    LeaveDate = result.LeaveDate,
                    ArriveDate = result.ArriveDate,
                    LeaveIATAId = result.LeaveIATAId,
                    ArriveIATAId = result.ArriveIATAId
                };

                return resultUpd;
            }

            return null;
        }
    }
}
