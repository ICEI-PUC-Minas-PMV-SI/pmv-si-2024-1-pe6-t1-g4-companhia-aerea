using AutoMapper;
using Domain.Dtos.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.FlightAggregate;

namespace CrossCutting.Mappings.FlightAggregate
{
    public class FlightEntityToDtoProfile : Profile
    {
        public FlightEntityToDtoProfile() 
        {
            CreateMap<FlightDto, FlightEntity>()
                .ReverseMap();
            CreateMap<FlightDtoCreateResult, FlightEntity>() 
                .ReverseMap();
            CreateMap<FlightDtoUpdateResult, FlightEntity>()
                .ReverseMap();

            CreateMap<FlightIntineraryDto, FlightItineraryEntity>()
                .ReverseMap();
            CreateMap<FlightIntineraryDtoCreateResult, FlightItineraryEntity>()
                .ReverseMap();
            CreateMap<FlightIntineraryDtoUpdateResult, FlightItineraryEntity>()
                .ReverseMap();

            CreateMap<IataDto, IataEntity>() 
                .ReverseMap();
            CreateMap<IataDtoCreateResult, IataEntity>()
                .ReverseMap();
            CreateMap<IataDtoUpdateResult, IataEntity>()
                .ReverseMap();
        }
    }
}
