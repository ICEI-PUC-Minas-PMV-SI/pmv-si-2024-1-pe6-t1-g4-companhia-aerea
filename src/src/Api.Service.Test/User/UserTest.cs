using Api.Domain.Dtos.UserAggregate;

namespace Api.Service.Test.User;

public class UserTest
{
    public static string UserName { get; set; }
    public static string UserLastName { get; set; }
    public static string UserEmail { get; set; }
    public static string UsernameChanged { get; set; }
    public static string UserLastnameChanged { get; set; }
    public static string EmailUserChanged { get; set; }
    public static Guid UserId { get; set; }
    public static DateTime UserDateBirth { get; set; }
    public static DateTime UserCreateAt { get; set; }
    

    public List<UserDto> listaUserDto = new List<UserDto>();
    public UserDto userDto;
    public UserDtoCreate userDtoCreate;
    public UserDtoCreateResult userDtoCreateResult;
    public UserDtoUpdate userDtoUpdate;
    public UserDtoUpdateResult userDtoUpdateResult;
    

    public UserTest()
    {
        UserId = Guid.NewGuid();
        UserName = Faker.Name.First();
        UserLastName = Faker.Name.Last();
        UserEmail = Faker.Internet.Email();
        UsernameChanged = Faker.Name.First();
        UserLastnameChanged = Faker.Name.Last();
        EmailUserChanged = Faker.Internet.Email();
        UserDateBirth = Faker.DateOfBirth.Next();
        UserCreateAt = DateTime.UtcNow;

        for (var i = 0; i < 10; i++)
        {
            var dto = new UserDto()
            {
                Id = Guid.NewGuid(),
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Email = Faker.Internet.Email(),
                DateBirth = Faker.DateOfBirth.Next(),
                CreateAt = DateTime.UtcNow
            };
            listaUserDto.Add(dto);
        }

        userDto = new UserDto
        {
            Id = UserId,
            FirstName = UserName,
            LastName = UserLastName,
            Email = UserEmail,
            DateBirth = UserDateBirth,
            CreateAt = UserCreateAt
        };

        userDtoCreate = new UserDtoCreate
        {
            FirstName = UserName,
            LastName = UserLastName,
            Email = UserEmail,
            DateBirth = UserDateBirth.ToString("yyyy-MM-dd"),
            Password = Faker.Lorem.Words(1).First()
        };


        userDtoCreateResult = new UserDtoCreateResult
        {
            Id = UserId,
            FirstName = UserName,
            LastName = UserLastName,
            Email = UserEmail,
            CreateAt = UserCreateAt,
            DateBirth = UserDateBirth.ToString("yyyy-MM-dd")
        };

        userDtoUpdate = new UserDtoUpdate
        {
            Id = UserId,
           
            FirstName = UsernameChanged,
            LastName = UserLastnameChanged,
            Email = EmailUserChanged,
            DateBirth = UserDateBirth.ToString("yyyy-MM-dd"),
            Password = Faker.Lorem.Words(1).First()
        };

        userDtoUpdateResult = new UserDtoUpdateResult
        {
           
            FirstName = UsernameChanged,
            LastName = UserLastnameChanged,
            Email = EmailUserChanged,
            DateBirth = UserDateBirth.ToString("yyyy-MM-dd"),
            UpdateAt = DateTime.UtcNow
        };

    }
}