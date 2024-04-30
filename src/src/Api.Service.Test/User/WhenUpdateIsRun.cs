using Api.Domain.Interfaces.Services.UserAggregate;
using Moq;

namespace Api.Service.Test.User;

public class WhenUpdateIsRun : UserTest
{
    private IUserService _service;
    private Mock<IUserService> _serviceMock;

    [Fact(DisplayName = "Is it possible to execute the Update Method.")]
    public async Task Is_it_possible_to_execute_the_Update_Method()
    {
        _serviceMock = new Mock<IUserService>();
        _serviceMock.Setup(m => m.Post(userDtoCreate)).ReturnsAsync(userDtoCreateResult);
        _service = _serviceMock.Object;

        var result = await _service.Post(userDtoCreate);
        Assert.NotNull(result);
        Assert.Equal(UserName, result.FirstName);
        Assert.Equal(UserLastName, result.LastName);
        Assert.Equal(UserEmail, result.Email);

        _serviceMock = new Mock<IUserService>();
        _serviceMock.Setup(m => m.Put(userDtoUpdate)).ReturnsAsync(userDtoUpdateResult);
        _service = _serviceMock.Object;

        var resultUpdate = await _service.Put(userDtoUpdate);
        Assert.NotNull(resultUpdate);
        Assert.Equal(UserName, resultUpdate.FirstName);
        Assert.Equal(UserLastName, resultUpdate.LastName);
        Assert.Equal(UserEmail, resultUpdate.Email);

    }
}