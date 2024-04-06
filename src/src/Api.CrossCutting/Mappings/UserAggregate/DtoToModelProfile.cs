using Api.Domain.Dtos.UserAggregate;
using Api.Domain.Models.UserAggregate;
using AutoMapper;

namespace Api.CrossCutting.Mappings.UserAggregate
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>()
                .ReverseMap();
            CreateMap<UserModel, UserDtoCreate>()
                .ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>()
                .ReverseMap();

        }

    }
}
