using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Dtos.UserAggregate;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.UserAggregate
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
        Task<UserEntity> FindByLogin(string email);
    }
}
