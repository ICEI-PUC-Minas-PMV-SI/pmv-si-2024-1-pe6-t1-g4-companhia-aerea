using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.CustomerAggregate;
using Domain.Dtos.CustomerAggregate;

namespace Api.Domain.Interfaces.Services.CustomerAggregate
{
    public interface ICustomerService
    {
        Task<CustomerDtoCreateResult> Post(CustomerDtoCreate customer, Guid userId);
        Task<CustomerDtoUpdateResult> Put(CustomerDtoUpdate customer, Guid userId);
        Task<CustomerDto> Get(Guid id);
        Task<IEnumerable<CustomerDtoSearchResult>> GetAll();
        Task<bool> Delete(Guid id);

        Task<AddressDto> GetAddress(Guid id);
        Task<CareerDto> GetCareer(Guid id);
        Task<NationalityDto> GetNationality(Guid id);
        Task<PhoneDto> GetPhone(Guid id);
        Task<IEnumerable<CareerDto>> GetAllCareer();
        Task<IEnumerable<NationalityDto>> GetAllNationality();

    }
}
