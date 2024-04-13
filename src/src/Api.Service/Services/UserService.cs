using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.UserAggregate;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.UserAggregate;
using Api.Domain.Models.UserAggregate;
using AutoMapper;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;
        private readonly IMapper _mapper;
        public UserService(IRepository<UserEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDto> Get(Guid id)
        {
            var entity = await _repository.SelectByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(entity);
            userDto.CreateAt = entity.CreatedAt.Value;

            return userDto;
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var listEntity = await _repository.SelectAllAsync();
            return _mapper.Map<IEnumerable<UserDto>>(listEntity);
        }

        public async Task<UserDtoCreateResult> Post(UserDtoCreate user)
        {
            var model = _mapper.Map<UserModel>(user);
            model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);

            var entity = _mapper.Map<UserEntity>(model);
            entity.Status = UserStatus.Active;
            entity.TypeUser = TypeUser.Regular;

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UserDtoCreateResult>(result);
        }

        public async Task<UserDtoUpdateResult> Put(UserDtoUpdate user)
        {
            var userDb = await _repository.SelectByIdAsync(user.Id);
            if (userDb != null)
            {
                var model = _mapper.Map<UserModel>(user);
                model.Password = string.IsNullOrWhiteSpace(user.Password) ? userDb.Password : BCrypt.Net.BCrypt.HashPassword(model.Password);

                var entity = _mapper.Map<UserEntity>(model);
                entity.Status = UserStatus.Active;
                entity.TypeUser = TypeUser.Regular;


                var result = await _repository.UpdateAsync(entity);
                return _mapper.Map<UserDtoUpdateResult>(result);
            }
            return null;

        }
    }
}
