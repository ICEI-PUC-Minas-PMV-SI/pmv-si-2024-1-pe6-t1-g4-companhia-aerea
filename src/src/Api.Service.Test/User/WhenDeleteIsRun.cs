using Api.Domain.Interfaces.Services.UserAggregate;
using Moq;

namespace Api.Service.Test.User;

public class WhenDeleteIsRun : UserTest
{
    private IUserService _service;
    private Mock<IUserService> _serviceMock;
    [Fact(DisplayName = "Is it possible to execute the Delete Method.")]
    public async Task Is_it_possible_to_execute_the_Delete_Method()
    {
        _serviceMock = new Mock<IUserService>();
        _serviceMock.Setup(m => m.Delete(UserId))
            .ReturnsAsync(true);
        _service = _serviceMock.Object;

        var deleted = await _service.Delete(UserId);
        Assert.True(deleted);

        _serviceMock = new Mock<IUserService>();
        _serviceMock.Setup(m => m.Delete(It.IsAny<Guid>()))
            .ReturnsAsync(false);
        _service = _serviceMock.Object;

        deleted = await _service.Delete(Guid.NewGuid());
        Assert.False(deleted);

    }
}