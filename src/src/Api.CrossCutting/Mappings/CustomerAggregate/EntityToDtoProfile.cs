using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.CustomerAggregate;
using Api.Domain.Entities.CustomerAggregate;
using AutoMapper;
using Domain.Dtos.CustomerAggregate;

namespace Api.CrossCutting.Mappings.CustomerAggregate
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<CustomerDto, CustomerEntity>()
               .ReverseMap();

            CreateMap<CustomerDtoCreateResult, CustomerEntity>()
               .ReverseMap();

            CreateMap<CustomerDtoUpdateResult, CustomerEntity>()
               .ReverseMap();

            CreateMap<CustomerDtoCreateResult, AddressEntity>()
               .ReverseMap();

            CreateMap<CustomerDtoCreateResult, PhoneEntity>()
               .ReverseMap();

            CreateMap<CustomerDtoUpdateResult, AddressEntity>()
               .ReverseMap();

            CreateMap<CustomerDtoUpdateResult, PhoneEntity>()
               .ReverseMap();


            CreateMap<AddressDto, AddressEntity>()
               .ReverseMap();

            CreateMap<CareerDto, CareerEntity>()
               .ReverseMap();

            CreateMap<NationalityDto, NationalityEntity>()
               .ReverseMap();

            CreateMap<PhoneDto, PhoneEntity>()
               .ReverseMap();

        }
    }
}
