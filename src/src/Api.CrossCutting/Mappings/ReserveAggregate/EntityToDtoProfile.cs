using Api.Domain.Entities;
using AutoMapper;
using Domain.Dtos.ReserveAggregate;
using Domain.Models.ReserveAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings.ReserveAggregate
{
    public class EntityToDtoProfile:Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ReserveDto,ReserveEntity>().ReverseMap();
            CreateMap<ReserveDtoCreateResult, ReserveEntity>().ReverseMap();
            CreateMap<ReserveDtoUpdateResult, ReserveEntity>().ReverseMap();
        }
    }
}
