using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class FullCRUDUser : BaseTest, IClassFixture<DbTest>
    {
        private ServiceProvider _serviceProvide;

        public FullCRUDUser(DbTest dbTest)
        {
            _serviceProvide = dbTest.ServiceProvider;
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
                    Email = "email@email.com",
                    FirstName = "Test",
                    LastName = "Test lastname",
                    Password = BCrypt.Net.BCrypt.HashPassword("string"),
                    DateBirth = DateTime.UtcNow,
                    Status = UserStatus.Active,
                    TypeUser = TypeUser.Regular
                };

                var _register = await _repository.InsertAsync(_entity);
                Assert.NotNull(_register);
                Assert.Equal(_entity.Email, _register.Email);
                Assert.Equal(_entity.FirstName, _register.FirstName);
                Assert.False(_register.Id == Guid.Empty);

                

            }
        }
    }
}
