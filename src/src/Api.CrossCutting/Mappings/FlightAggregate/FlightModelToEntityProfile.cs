using AutoMapper;
using Domain.Entities;
using Domain.Models.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings.FlightAggregate
{
    public class FlightModelToEntityProfile : Profile
    {
        public FlightModelToEntityProfile() 
        {
            CreateMap<FlightModel, FlightEntity>()
                .ReverseMap();

            CreateMap<FlightIntineraryModel, FlightIntineraryEntity>()
                .ReverseMap();

            CreateMap<IataModel, IataEntity>() 
                .ReverseMap();
        }
    }
}
