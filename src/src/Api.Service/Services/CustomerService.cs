using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.CustomerAggregate;
using Api.Domain.Entities.CustomerAggregate;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.CustomerAggregate;
using Api.Domain.Repository;
using AutoMapper;
using Domain.Dtos.CustomerAggregate;
using Microsoft.EntityFrameworkCore;

namespace Api.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _repository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CustomerDto> Get(Guid id)
        {
            var entity = await _repository.SelectByIdAsync(id);
            var customerDto = _mapper.Map<CustomerDto>(entity);

            return customerDto;
        }

        public async Task<IEnumerable<CustomerDtoSearchResult>> GetAll()
        {
            var listEntity = await _repository.SelectAllAsync();
            var result = new List<CustomerDtoSearchResult>();

            foreach (var customer in listEntity)
            {
                var customerDto = await ConvertToCustomerDtoSearchResult(customer);
                result.Add(customerDto);
            }

            //var result = await Task.WhenAll(listEntity.Select(async customer =>
            //{
            //    var customerDto = await ConvertToCustomerDtoSearchResult(customer);
            //    return customerDto;
            //}));

            //var resultList = result.ToList();

            return result;
        }

        private async Task<CustomerDtoSearchResult> ConvertToCustomerDtoSearchResult(CustomerEntity customer)
        {
            var nationalityEntity = await _repository.GetNationalityById(customer.NationalityId);
            var careerEntity = customer.CareerId.HasValue ? await _repository.GetCareerById(customer.CareerId.Value) : null;

            return new CustomerDtoSearchResult
            {
                Id = customer.Id,
                FullName = $"{customer.FirstName} {customer.LastName}",
                Email = customer.Email,
                Document = customer.Document,
                DateBirth = customer.DateBirth,
                NationalityId = customer.NationalityId,
                CareerId = customer.CareerId,
                NationalityDescription = nationalityEntity.Description,
                CareerDescription = careerEntity != null ? careerEntity.Description : ""
            };
        }

        public async Task<CustomerDtoCreateResult> Post(CustomerDtoCreate customer, Guid userId)
        {
            var customerEntity = new CustomerEntity()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Document = customer.Document,
                DateBirth = DateTime.Parse(customer.DateBirth),
                StatusId = CustomerStatus.Active,
                NationalityId = customer.NationalityId,
                CareerId = customer.CareerId,
                UserId = userId,
            };

            var addressResult = await CreateAddress(customer);
            customerEntity.AddressId = addressResult.Id;

            var phoneResult = await CreatePhone(customer);
            customerEntity.PhoneId = phoneResult.Id;

            var result = await _repository.InsertAsync(customerEntity);
            var customerResult = new CustomerDtoCreateResult()
            {
                Id = result.Id,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Email = result.Email,
                Document = result.Document,
                DateBirth = result.DateBirth,
                NationalityId = result.AddressId,
                UserId = result.UserId,
                PhoneId = result.PhoneId,
                CareerId = result.CareerId,

                CountryCode = phoneResult.CountryCode,
                DDD = phoneResult.DDD,
                PhoneNumber = phoneResult.Number,
                TypePhone = (int)phoneResult.TypePhone,

                ZipCode = addressResult.ZipCode,
                Country = addressResult.Country,
                State = addressResult.State,
                City = addressResult.City,
                Neighborhood = addressResult.Neighborhood,
                Street = addressResult.Street,
                Number = addressResult.Number,
                Complement = addressResult.Complement,

            };

            return customerResult;
        }

        public async Task<CustomerDtoUpdateResult> Put(CustomerDtoUpdate customer, Guid userId)
        {
            var customerDb = await _repository.SelectByIdAsync(customer.Id);
            var addressDb = await _repository.GetAddressById(customer.AddressId);
            var phoneDb = await _repository.GetPhoneById(customer.PhoneId);
            if (customerDb != null && addressDb != null && phoneDb != null)
            {
                //var customerEntity = _mapper.Map<CustomerEntity>(customer);
                var customerEntity = new CustomerEntity()
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    Document = customer.Document,
                    DateBirth = DateTime.Parse(customer.DateBirth),
                    StatusId = CustomerStatus.Active,
                    NationalityId = customer.NationalityId,
                    CareerId = customer.CareerId,
                    UserId = userId,
                };
                var result = await _repository.UpdateAsync(customerEntity);
                var phoneUpdated = await UpdatePhone(customer, phoneDb);
                var addressUpdate = await UpdateAddress(customer, addressDb);
                return EntityToCustomerDtoUpdateResult(result, phoneUpdated, addressUpdate);
            }
            return null;
        }

        private CustomerDtoUpdateResult EntityToCustomerDtoUpdateResult(CustomerEntity customer, PhoneEntity phoneUpdated, AddressEntity addressUpdate)
        {

            //TODO: Transfomar em um metodo a parte
            var customerResult = new CustomerDtoUpdateResult()
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Document = customer.Document,
                DateBirth = customer.DateBirth,
                NationalityId = customer.AddressId,
                UserId = customer.UserId,
                PhoneId = customer.PhoneId,
                CareerId = customer.CareerId,

                ZipCode = addressUpdate.ZipCode,
                Country = addressUpdate.Country,
                State = addressUpdate.State,
                City = addressUpdate.City,
                Neighborhood = addressUpdate.Neighborhood,
                Street = addressUpdate.Street,
                Number = addressUpdate.Number,
                Complement = addressUpdate.Complement,
                CountryCode = phoneUpdated.CountryCode,
                DDD = phoneUpdated.DDD,
                PhoneNumber = phoneUpdated.Number,
                TypePhone = (int)phoneUpdated.TypePhone
            };
            return customerResult;
        }



        private async Task<PhoneEntity> UpdatePhone(CustomerDtoUpdate customer, PhoneEntity phone)
        {

            var phoneEntity = _mapper.Map<PhoneEntity>(customer);
            phoneEntity.Id = phone.Id;
            phoneEntity.Number = customer.PhoneNumber;

            return await _repository.UpdatePhone(phoneEntity);
        }

        private async Task<AddressEntity> UpdateAddress(CustomerDtoUpdate customer, AddressEntity address)
        {
            var addressEntity = _mapper.Map<AddressEntity>(customer);
            addressEntity.Id = address.Id;

            return await _repository.UpdateAddress(addressEntity);
        }


        private async Task<PhoneEntity> CreatePhone(CustomerDtoCreate customer)
        {
            var phoneEntity = new PhoneEntity()
            {
                CountryCode = customer.CountryCode,
                DDD = customer.DDD,
                Number = customer.Number,
                TypePhone = (TypePhone)customer.TypePhone,
                CreatedAt = DateTime.UtcNow
            };
            return await _repository.InsertPhoneAsync(phoneEntity);
        }

        private async Task<AddressEntity> CreateAddress(CustomerDtoCreate customer)
        {
            var addressEntity = new AddressEntity()
            {
                ZipCode = customer.ZipCode,
                Country = customer.Country,
                State = customer.State,
                City = customer.City,
                Neighborhood = customer.Neighborhood,
                Street = customer.Street,
                Number = customer.Number,
                CreatedAt = DateTime.UtcNow
            };
            return await _repository.InsertAddressAsync(addressEntity);
        }

        public async Task<AddressDto> GetAddress(Guid id)
        {
            var addressDb = await _repository.GetAddressById(id);
            return _mapper.Map<AddressDto>(addressDb);

        }

        public async Task<CareerDto> GetCareer(Guid id)
        {
            var careerDb = await _repository.GetCareerById(id);
            return _mapper.Map<CareerDto>(careerDb);
        }

        public async Task<NationalityDto> GetNationality(Guid id)
        {
            var nationalityDb = await _repository.GetNationalityById(id);
            return _mapper.Map<NationalityDto>(nationalityDb);
        }

        public async Task<PhoneDto> GetPhone(Guid id)
        {
            var phoneDb = await _repository.GetPhoneById(id);
            return _mapper.Map<PhoneDto>(phoneDb);
        }

        public async Task<IEnumerable<CareerDto>> GetAllCareer()
        {
            var listEntity = await _repository.GetAllCareer();
            return _mapper.Map<IEnumerable<CareerDto>>(listEntity);
        }

        public async Task<IEnumerable<NationalityDto>> GetAllNationality()
        {
            var listEntity = await _repository.GetAllNationality();
            return _mapper.Map<IEnumerable<NationalityDto>>(listEntity);
        }
    }
}
