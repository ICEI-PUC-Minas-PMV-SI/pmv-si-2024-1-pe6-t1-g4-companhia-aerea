
using Api.Domain.Models.UserAggregate;
using AutoMapper;
using Domain.Dtos.FlightAggregate;
using Domain.Models.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings.FlightAggregate
{
    public class FlightDtoToModelProfile : Profile
    {
        public FlightDtoToModelProfile() 
        {
            CreateMap<FlightModel, FlightDto>()
                .ReverseMap();
            CreateMap<FlightModel, FlightDtoCreate>()
                .ReverseMap();
            CreateMap<FlightModel, FlightDtoUpdate>()
                .ReverseMap();

            CreateMap<FlightIntineraryModel, FlightIntineraryDto>()
                .ReverseMap();
            CreateMap<FlightIntineraryModel, FlightIntineraryDtoCreate>()
                .ReverseMap();
            CreateMap<FlightIntineraryModel, FlightIntineraryDtoUpdate>()
                .ReverseMap();

            CreateMap<IataModel, IataDto>() 
                .ReverseMap();
            CreateMap<IataModel, IataDtoCreate>() 
                .ReverseMap();
            CreateMap<IataModel, IataDtoUpdate>()
                .ReverseMap();
        }
    }
}
