using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Dtos.ReserveAggregate;
using Domain.Models.ReserveAggregate;

namespace CrossCutting.Mappings.ReserveAggregate
{
    public class DtoToModelProfile:Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<ReserveModel,ReserveDto>().ReverseMap();
            CreateMap<ReserveModel, ReserveDtoCreate>().ReverseMap();
            CreateMap<ReserveModel, ReserveDtoUpdate>().ReverseMap();
        }
    }
}
