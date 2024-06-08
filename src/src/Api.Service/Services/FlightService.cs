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
using Domain.Entities.FlightAggregate;

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


        public async Task<IataDto> GetIata(Guid id)
        {
            var entity = await _flightRepository.GetIataById(id);
            var iataDto = _mapper.Map<IataDto>(entity);

            return iataDto;
        }

        public async Task<List<IataDto>> GetAllIata()
        {
            var entity = await _flightRepository.GetAllIata();
            var iataDto = _mapper.Map<List<IataDto>>(entity);

            return iataDto;
        }

        public async Task<IataDtoCreateResult> PostIata(IataDtoCreate iata)
        {
            var entity = new IataEntity()
            {
                IATACode = iata.IATACode,
                Airport = iata.Airport,
                Location = iata.Location,
                Available = iata.Available,
            };

            var result = await _flightRepository.InsertIata(entity);

            var iataDto = new IataDtoCreateResult()
            {
                IATACode = result.IATACode,
                Airport = result.Airport,
                Location = result.Location,
                Available = result.Available,
            };

            return iataDto;
        }

        public async Task<IataDtoUpdateResult> PutIata(IataDtoUpdate iata)
        {
            var iataDb = await _flightRepository.GetIataById(iata.Id);

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

                var result = await _flightRepository.UpdateIata(iataEntity);

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

        public async Task<FlightInfoResponseDto> SearchFlights(FlightDetailRequestDto request)
        {
            var result = await _flightRepository.SearchFlights(request);

            var flightInfo = new FlightInfoResponseDto()
            {
                DepartureFlights = result.DepartureFlights.Select(f => new FlightDetailResponseDto()
                {
                    Departure = $"{f.LeaveIATACode} - {f.LeaveLocation}",
                    Arrival = $"{f.ArriveIATACode} - {f.ArriveLocation}",
                    DepartureTime = f.LeaveDate.ToString("HH:mm"),
                    ArrivalTime = f.ArriveDate.ToString("HH:mm"),
                    Duration = $"{(int)(f.ArriveDate - f.LeaveDate).TotalHours}h {(f.ArriveDate - f.LeaveDate).Minutes}m",
                    PriceBusiness = f.PriceExecutive.ToString("C2", new System.Globalization.CultureInfo("pt-BR")),
                    PriceEconomy = f.PriceEconomy.ToString("C2", new System.Globalization.CultureInfo("pt-BR")),
                }).ToList(),
                ReturnFlights = result.ReturnFlights.Select(f => new FlightDetailResponseDto()
                {
                    Departure = $"{f.LeaveIATACode} - {f.LeaveLocation}",
                    Arrival = $"{f.ArriveIATACode} - {f.ArriveLocation}",
                    DepartureTime = f.LeaveDate.ToString("HH:mm"),
                    ArrivalTime = f.ArriveDate.ToString("HH:mm"),
                    Duration = $"{(int)(f.ArriveDate - f.LeaveDate).TotalHours}h {(f.ArriveDate - f.LeaveDate).Minutes}m",
                    PriceBusiness = f.PriceExecutive.ToString("C2", new System.Globalization.CultureInfo("pt-BR")),
                    PriceEconomy = f.PriceEconomy.ToString("C2", new System.Globalization.CultureInfo("pt-BR")),
                }).ToList()
            };

            return flightInfo;
        }

        public Task<SearchSeatsResponse> SearchSeats(SearchSeatsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
