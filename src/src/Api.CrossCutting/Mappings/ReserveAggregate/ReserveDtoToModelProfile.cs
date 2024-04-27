using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Dtos.ReserveAggregate;
using Domain.Models.ReserveAggregate;

namespace Api.CrossCutting.Mappings.ReserveAggregate
{
    public class ReserveDtoToModelProfile:Profile
    {
        public ReserveDtoToModelProfile()
        {
            CreateMap<ReserveModel,ReserveDto>().ReverseMap();
            CreateMap<ReserveModel, ReserveDtoCreate>().ReverseMap();
            CreateMap<ReserveModel, ReserveDtoUpdate>().ReverseMap();
        }
    }
}
