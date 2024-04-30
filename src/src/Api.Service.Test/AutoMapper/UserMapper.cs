using Api.Domain.Dtos.UserAggregate;
using Api.Domain.Entities;
using Api.Domain.Models.UserAggregate;

namespace Api.Service.Test.AutoMapper;

public class UserMapper : BaseTestService
{
    [Fact(DisplayName = "Is it possible mapper user .")]
        public void Is_it_possible_mapper_user()
        {
            var model = new UserModel
            {
                Id = Guid.NewGuid(),
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Email = Faker.Internet.Email(),
                Password = Faker.Lorem.Words(1).First(),
                DateBirth = Faker.DateOfBirth.Next().ToString("yyyy-MM-dd"),
                Status = 1,
                TypeUser = 2,
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var listaEntity = new List<UserEntity>();
            for (int i = 0; i < 5; i++)
            {
                var item = new UserEntity
                {
                    Id = Guid.NewGuid(),
                    FirstName = Faker.Name.First(),
                    LastName = Faker.Name.Last(),
                    Email = Faker.Internet.Email(),
                    Password = Faker.Lorem.Words(1).First(),
                    DateBirth = Faker.DateOfBirth.Next(),
                    Status = UserStatus.Active,
                    TypeUser = TypeUser.Regular,
                    CreatedAt = DateTime.UtcNow,
                    UpdateAt = DateTime.UtcNow
                };
                listaEntity.Add(item);
            }

            //Model => Entity
            var entity = Mapper.Map<UserEntity>(model);
            Assert.Equal(entity.Id, model.Id);
            Assert.Equal(entity.FirstName, model.FirstName);
            Assert.Equal(entity.LastName, model.LastName);
            Assert.Equal(entity.Email, model.Email);
            //Assert.Equal(entity.CreatedAt, model.CreateAt);
            //Assert.Equal(entity.UpdateAt, model.UpdateAt);

            //Entity para Dto
            var userDto = Mapper.Map<UserDto>(entity);
            Assert.Equal(userDto.Id, entity.Id);
            Assert.Equal(userDto.FirstName, entity.FirstName);
            Assert.Equal(userDto.LastName, entity.LastName);
            Assert.Equal(userDto.Email, entity.Email);
            //Assert.Equal(userDto.CreateAt, entity.CreatedAt);

            var listaDto = Mapper.Map<List<UserDto>>(listaEntity);
            Assert.True(listaDto.Count() == listaEntity.Count());
            for (int i = 0; i < listaDto.Count(); i++)
            {
                Assert.Equal(listaDto[i].Id, listaEntity[i].Id);
                Assert.Equal(listaDto[i].FirstName, listaEntity[i].FirstName);
                Assert.Equal(listaDto[i].LastName, listaEntity[i].LastName);
                Assert.Equal(listaDto[i].Email, listaEntity[i].Email);
                //Assert.Equal(listaDto[i].CreateAt, listaEntity[i].CreatedAt);
            }

            var userDtoCreateResult = Mapper.Map<UserDtoCreateResult>(entity);
            Assert.Equal(userDtoCreateResult.Id, entity.Id);
            Assert.Equal(userDtoCreateResult.FirstName, entity.FirstName);
            Assert.Equal(userDtoCreateResult.LastName, entity.LastName);
            Assert.Equal(userDtoCreateResult.Email, entity.Email);
            //Assert.Equal(userDtoCreateResult.CreateAt, entity.CreatedAt);

            var userDtoUpdateResult = Mapper.Map<UserDtoUpdateResult>(entity);
            Assert.Equal(userDtoUpdateResult.FirstName, entity.FirstName);
            Assert.Equal(userDtoUpdateResult.LastName, entity.LastName);
            Assert.Equal(userDtoUpdateResult.Email, entity.Email);
            //Assert.Equal(userDtoUpdateResult.UpdateAt, entity.UpdateAt);

            //Dto para Model
            var userModel = Mapper.Map<UserModel>(userDto);
            Assert.Equal(userModel.Id, userDto.Id);
            Assert.Equal(userModel.FirstName, userDto.FirstName);
            Assert.Equal(userModel.LastName, userDto.LastName);
            Assert.Equal(userModel.Email, userDto.Email);
            //Assert.Equal(userModel.CreateAt, userDto.CreateAt);

            var userDtoCreate = Mapper.Map<UserDtoCreate>(userModel);
            Assert.Equal(userDtoCreate.FirstName, userModel.FirstName);
            Assert.Equal(userDtoCreate.LastName, userModel.LastName);
            Assert.Equal(userDtoCreate.Email, userModel.Email);

            var userDtoUpdate = Mapper.Map<UserDtoUpdate>(userModel);
            Assert.Equal(userDtoUpdate.Id, userModel.Id);
            Assert.Equal(userDtoUpdate.FirstName, userModel.FirstName);
            Assert.Equal(userDtoUpdate.LastName, userModel.LastName);
            Assert.Equal(userDtoUpdate.Email, userModel.Email);

        }
}