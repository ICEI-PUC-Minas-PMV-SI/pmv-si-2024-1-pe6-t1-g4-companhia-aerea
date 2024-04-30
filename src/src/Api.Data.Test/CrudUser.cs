using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class CrudUser : BaseTest, IClassFixture<DbTest>
    {
        private readonly ServiceProvider _serviceProvide;

        public CrudUser(DbTest dbTeste)
        {
            _serviceProvide = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "CRUD User")]
        [Trait("CRUD", "UserEntity")]
        public async Task Is_it_possible_CRUD_User()
        {
            using (var context = _serviceProvide.GetService<MyContext>())
            {
                UserImplementation _repository = new UserImplementation(context);
                UserEntity _entity = new UserEntity
                {
                    FirstName = Faker.Name.First(),
                    LastName = Faker.Name.Last(),
                    Email = Faker.Internet.Email(),
                    Password = BCrypt.Net.BCrypt.HashPassword("string"),
                    DateBirth = DateTime.Parse("2000-01-01"),
                    Status = UserStatus.Active,
                    TypeUser = TypeUser.Admin,
                    CreatedAt = DateTime.UtcNow
                };

               

                //Create
                var _record = await _repository.InsertAsync(_entity);
                Assert.NotNull(_record);
                Assert.Equal(_entity.Email, _record.Email);
                Assert.Equal(_entity.FirstName, _record.FirstName);
                Assert.Equal(_entity.LastName, _record.LastName);
                //Assert.Equal(_entity.Password, _record.Password);
                Assert.Equal(_entity.DateBirth, _record.DateBirth);
                Assert.Equal(_entity.Status, _record.Status);
                Assert.Equal(_entity.TypeUser, _record.TypeUser);
                Assert.False(_record.Id == Guid.Empty);

                //Update
                _entity.FirstName = Faker.Name.First();
                _entity.LastName = Faker.Name.Last();
                var _updatedRecord = await _repository.UpdateAsync(_entity);
                Assert.NotNull(_updatedRecord);
                Assert.Equal(_entity.Email, _updatedRecord.Email);
                Assert.Equal(_entity.FirstName, _updatedRecord.FirstName);
                Assert.Equal(_entity.LastName, _updatedRecord.LastName);


                //Get by Id
                var _selectedRecord = await _repository.SelectByIdAsync(_updatedRecord.Id);
                Assert.NotNull(_selectedRecord);
                Assert.Equal(_updatedRecord.Email, _selectedRecord.Email);
                Assert.Equal(_updatedRecord.FirstName, _selectedRecord.FirstName);
                Assert.Equal(_updatedRecord.LastName, _selectedRecord.LastName);


                //Get All
                var _allRecords = await _repository.SelectAllAsync();
                Assert.NotNull(_allRecords);
                Assert.True(_allRecords.Count() > 1);

                //Delete
                var _remove = await _repository.DeleteAsync(_selectedRecord.Id);
                Assert.True(_remove);

                //Get by email
                var _userDefaut = await _repository.FindByLogin("user1@email.com");
                Assert.NotNull(_userDefaut);
                Assert.Equal("user1@email.com", _userDefaut.Email);
                Assert.Equal("User Adm", _userDefaut.FirstName);
                Assert.Equal("Adm Master", _userDefaut.LastName);

            }
        }
    }
}
