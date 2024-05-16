using AutoMapper;
using Domain.Models.FlightAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.FlightAggregate;

namespace CrossCutting.Mappings.FlightAggregate
{
    public class FlightModelToEntityProfile : Profile
    {
        public FlightModelToEntityProfile() 
        {
            CreateMap<FlightModel, FlightEntity>()
                .ReverseMap();

            CreateMap<FlightIntineraryModel, FlightItineraryEntity>()
                .ReverseMap();

            CreateMap<IataModel, IataEntity>() 
                .ReverseMap();
        }
    }
}
