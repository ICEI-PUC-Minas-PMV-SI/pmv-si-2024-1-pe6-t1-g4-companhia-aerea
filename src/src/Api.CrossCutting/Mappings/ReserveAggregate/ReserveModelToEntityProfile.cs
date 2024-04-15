using Api.Domain.Entities;
using AutoMapper;
using Domain.Models.ReserveAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.CrossCutting.Mappings.ReserveAggregate
{
    public class ReserveModelToEntityProfile:Profile
    {
        public ReserveModelToEntityProfile() { 
            CreateMap<ReserveEntity,ReserveModel>().ReverseMap();
        }
    }
}
