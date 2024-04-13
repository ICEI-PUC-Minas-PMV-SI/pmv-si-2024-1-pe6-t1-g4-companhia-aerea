using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities.CustomerAggregate;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface ICustomerRepository : IRepository<CustomerEntity>
    {
        Task<IEnumerable<NationalityEntity>> GetAllNationality();
        Task<IEnumerable<CareerEntity>> GetAllCareer();
        Task<AddressEntity> InsertAddressAsync(AddressEntity address);
        Task<PhoneEntity> InsertPhoneAsync(PhoneEntity phone);

        Task<AddressEntity> GetAddressById(Guid id);
        Task<PhoneEntity> GetPhoneById(Guid id);

        Task<AddressEntity> UpdateAddress(AddressEntity address);
        Task<PhoneEntity> UpdatePhone(PhoneEntity phone);
    }
}
