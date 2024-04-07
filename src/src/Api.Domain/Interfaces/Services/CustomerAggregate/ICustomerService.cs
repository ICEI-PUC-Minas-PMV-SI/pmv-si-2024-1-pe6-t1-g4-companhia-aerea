using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.CustomerAggregate;

namespace Api.Domain.Interfaces.Services.CustomerAggregate
{
    public interface ICustomerService
    {
        Task<CustomerDto> Get(Guid id);
        Task<IEnumerable<CustomerDto>> GetAll();
        Task<CustomerDtoCreateResult> Post(CustomerDtoCreate customer);
        Task<CustomerDtoUpdateResult> Put(CustomerDtoUpdate customer);
        Task<bool> Delete(Guid id);
    }
}
