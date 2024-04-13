using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Repository;
using Api.Domain.Entities.CustomerAggregate;
using Api.Domain.Repository;
using Domain.Dtos.CustomerAggregate;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class CustomerImplementation : BaseRepository<CustomerEntity>, ICustomerRepository
    {
        private DbSet<CustomerEntity> _dbCustomer;
        private DbSet<CareerEntity> _dbCareer;
        private DbSet<NationalityEntity> _dbNationality;
        private DbSet<AddressEntity> _dbAddress;
        private DbSet<PhoneEntity> _dbPhone;
        public CustomerImplementation(MyContext context) : base(context)
        {
            _dbCustomer = context.Set<CustomerEntity>();
            _dbCareer = context.Set<CareerEntity>();
            _dbNationality = context.Set<NationalityEntity>();
            _dbAddress = context.Set<AddressEntity>();
            _dbPhone = context.Set<PhoneEntity>();
        }

        public async Task<AddressEntity> InsertAddressAsync(AddressEntity address)
        {
            try
            {
                address.Id = address.Id == Guid.Empty ? Guid.NewGuid() : address.Id;
                address.CreatedAt = DateTime.UtcNow;

                _dbAddress.Add(address);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return address;
        }

        public async Task<PhoneEntity> InsertPhoneAsync(PhoneEntity phone)
        {
            try
            {
                phone.Id = phone.Id == Guid.Empty ? Guid.NewGuid() : phone.Id;
                phone.CreatedAt = DateTime.UtcNow;

                _dbPhone.Add(phone);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return phone;
        }

        public async Task<AddressEntity> UpdateAddress(AddressEntity item)
        {
            try
            {
                var result = await _dbAddress.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null) return null;

                item.CreatedAt = result.CreatedAt;
                item.UpdateAt = DateTime.UtcNow;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<PhoneEntity> UpdatePhone(PhoneEntity item)
        {
            try
            {
                var result = await _dbPhone.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null) return null;

                item.CreatedAt = result.CreatedAt;
                item.UpdateAt = DateTime.UtcNow;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<AddressEntity> GetAddressById(Guid id)
        {
            return await _dbAddress.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task<CareerEntity> GetCareerById(Guid id)
        {
            return await _dbCareer.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<NationalityEntity> GetNationalityById(Guid id)
        {
            return await _dbNationality.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task<PhoneEntity> GetPhoneById(Guid id)
        {
            return await _dbPhone.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<IEnumerable<CareerEntity>> GetAllCareer()
        {
            try
            {
                return await _dbCareer.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<NationalityEntity>> GetAllNationality()
        {
            try
            {
                return await _dbNationality.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
