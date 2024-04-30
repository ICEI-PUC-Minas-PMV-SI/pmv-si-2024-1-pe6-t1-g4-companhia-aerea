using Api.Domain.Dtos.UserAggregate;
using Api.Domain.Interfaces.Services.UserAggregate;
using Moq;

namespace Api.Service.Test.User;

public class WhenGetIsRun : UserTest
{
    private IUserService _service;
    private Mock<IUserService> _serviceMock;

    [Fact(DisplayName = "Is it possible to execute the Get Method.")]
    public async Task Is_it_possible_to_execute_the_Get_Method()
    {
        _serviceMock = new Mock<IUserService>();
        _serviceMock.Setup(m => m.Get(UserId)).ReturnsAsync(userDto);
        _service = _serviceMock.Object;

        var result = await _service.Get(UserId);
        Assert.NotNull(result);
        Assert.True(result.Id == UserId);
        Assert.Equal(UserName, result.FirstName);

        _serviceMock = new Mock<IUserService>();
        _serviceMock.Setup(m => m.Get(It.IsAny<Guid>())).Returns(Task.FromResult((UserDto)null));
        _service = _serviceMock.Object;

        var _record = await _service.Get(UserId);
        Assert.Null(_record);

    }
}