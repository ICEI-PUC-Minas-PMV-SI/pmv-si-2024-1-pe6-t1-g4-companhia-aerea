using Api.Domain.Dtos.UserAggregate;
using Api.Domain.Interfaces.Services.UserAggregate;
using Moq;

namespace Api.Service.Test.User;

public class WhenGetAllIsRun : UserTest
{
    private IUserService _service;
    private Mock<IUserService> _serviceMock;

    [Fact(DisplayName = "Is it possible to execute the GetAll Method.")]
    public async Task Is_it_possible_to_execute_the_GetAll_Method()
    {
        _serviceMock = new Mock<IUserService>();
        _serviceMock.Setup(m => m.GetAll()).ReturnsAsync(listaUserDto);
        _service = _serviceMock.Object;

        var result = await _service.GetAll();
        Assert.NotNull(result);
        Assert.True(result.Count() == 10);

        var _listResult = new List<UserDto>();
        _serviceMock = new Mock<IUserService>();
        _serviceMock.Setup(m => m.GetAll()).ReturnsAsync(_listResult.AsEnumerable);
        _service = _serviceMock.Object;

        var _resultEmpty = await _service.GetAll();
        Assert.Empty(_resultEmpty);
        Assert.True(_resultEmpty.Count() == 0);
    }
}