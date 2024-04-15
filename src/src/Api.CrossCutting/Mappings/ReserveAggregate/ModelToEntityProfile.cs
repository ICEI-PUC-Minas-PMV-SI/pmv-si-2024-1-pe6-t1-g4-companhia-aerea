using Api.Domain.Entities;
using AutoMapper;
using Domain.Models.ReserveAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings.ReserveAggregate
{
    public class ModelToEntityProfile:Profile
    {
        public ModelToEntityProfile() { 
            CreateMap<ReserveEntity,ReserveModel>().ReverseMap();
        }
    }
}
