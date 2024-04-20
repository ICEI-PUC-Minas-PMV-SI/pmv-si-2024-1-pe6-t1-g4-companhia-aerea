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
    public class IataService : IIataService
    {
        private IIataRepository _iataRepository;
        private readonly IMapper _mapper;
        public IataService(IIataRepository iataRepository, IMapper mapper)
        {
            _iataRepository = iataRepository;
            _mapper = mapper;
        }
        public async Task<IataDto> Get(Guid id)
        {
            var entity = await _iataRepository.GetIataById(id);
            var iataDto = _mapper.Map<IataDto>(entity);

            return iataDto;
        }

        public async Task<List<IataDto>> GetAll()
        {
            var entity = await _iataRepository.GetAll();
            var iataDto = _mapper.Map<List<IataDto>>(entity);

            return iataDto;
        }

        public async Task<IataDtoCreateResult> Post(IataDtoCreate iata)
        {
            var entity = new IataEntity()
            {
                IATACode = iata.IATACode,
                Airport = iata.Airport,
                Location = iata.Location,
                Available = iata.Available,
            };

            var result = await _iataRepository.InsertIata(entity);

            var iataDto = new IataDtoCreateResult()
            {
                IATACode = result.IATACode,
                Airport = result.Airport,
                Location = result.Location,
                Available = result.Available,
            };

            return iataDto;
        }

        public async Task<IataDtoUpdateResult> Put(IataDtoUpdate iata)
        {
            var iataDb = await _iataRepository.GetIataById(iata.Id);

            if (iataDb != null)
            {
                var iataEntity = new IataEntity()
                {
                    Id = iataDb.Id,
                    IATACode = iataDb.IATACode,
                    Airport = iataDb.Airport,
                    Location = iataDb.Location,
                    Available = iataDb.Available,
                };

                var result = await _iataRepository.UpdateIata(iataEntity);

                var resultUpd = new IataDtoUpdateResult()
                {
                    Id = result.Id,
                    IATACode = result.IATACode,
                    Airport = result.Airport,
                    Location = result.Location,
                    Available = result.Available,
                };

                return resultUpd;
            }

            return null;
        }
    }
}
