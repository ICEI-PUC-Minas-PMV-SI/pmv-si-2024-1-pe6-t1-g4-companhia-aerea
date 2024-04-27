using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Seeds.CustomerAggregates
{
    public static class CustomersSeeds
    {
        public static void Customers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEntity>().HasData(
                new CustomerEntity()
                {
                    Id = new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"),
                    FirstName = "Customer 01 do Adm ",
                    LastName = "Last Name Customer 01",
                    Email = "customer01@email.com",
                    Document = "116.987.659-96",
                    DateBirth = DateTime.Parse("2000-01-01"),
                    StatusId = CustomerStatus.Active,
                    AddressId = new Guid("22ca315c-e483-48c4-9483-d1c0904fee9d"),
                    CareerId = new Guid("eb15eaef-b653-4ccc-a0cd-b2720da41d55"),
                    NationalityId = new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"),
                    PhoneId = new Guid("f56171aa-4179-4668-9618-ca1676679449"),
                    UserId = new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"),
                    CreatedAt = DateTime.UtcNow
                },
                new CustomerEntity()
                {
                    Id = new Guid("7c259bf1-ee8b-4d1d-949e-b4a3aca134c4"),
                    FirstName = "Customer 02 do Adm ",
                    LastName = "Last Name Customer 02",
                    Email = "customer02@email.com",
                    Document = "189.847.392-05",
                    DateBirth = DateTime.Parse("1990-01-01"),
                    StatusId = CustomerStatus.Active,
                    AddressId = new Guid("8ff920eb-58f6-4b4c-a4f1-2e4bf62a7741"),
                    CareerId = new Guid("7a4a0108-7d57-4485-a1cf-ae7b239c1573"),
                    NationalityId = new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"),
                    PhoneId = new Guid("316b3c7b-c399-403d-bd7e-98a085fb5d3a"),
                    UserId = new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"),
                    CreatedAt = DateTime.UtcNow.AddHours(2)
                },
                new CustomerEntity()
                {
                    Id = new Guid("039cd0f7-1506-4daf-9648-be0fa40434fb"),
                    FirstName = "Customer 03 do Adm ",
                    LastName = "Last Name Customer 03",
                    Email = "customer03@email.com",
                    Document = "543.609.281-49",
                    DateBirth = DateTime.Parse("1994-01-01"),
                    StatusId = CustomerStatus.Active,
                    AddressId = new Guid("e82a1e06-57d7-4b2c-b8b6-1e7b013a2d05"),
                    CareerId = null,
                    NationalityId = new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"),
                    PhoneId = new Guid("73ed0e45-4740-4a6c-9348-fd97b405da2d"),
                    UserId = new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"),
                    CreatedAt = DateTime.UtcNow.AddMinutes(10)
                },
                 new CustomerEntity()
                 {
                     Id = new Guid("f3b171ea-047a-4e9d-a282-4115a76f419f"),
                     FirstName = "Customer 01 do regular 01 ",
                     LastName = "Last Name Customer 01R",
                     Email = "customer01r@email.com",
                     Document = "786.123.549-02",
                     DateBirth = DateTime.Parse("1990-02-02"),
                     StatusId = CustomerStatus.Active,
                     AddressId = new Guid("40b3e7df-4ff9-4d8d-bc2d-7f5c6481ff1d"),
                     CareerId = new Guid("0ec49ed6-1a07-4e63-b3d2-4ac3cb56a962"),
                     NationalityId = new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"),
                     PhoneId = new Guid("ec1ab1c0-c72a-4030-89f0-9833e9f621f4"),
                     UserId = new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041"),
                     CreatedAt = DateTime.UtcNow.AddHours(1)
                 },
                 new CustomerEntity()
                 {
                     Id = new Guid("fdf6777d-f6d3-4c54-96c3-4c498aa0903b"),
                     FirstName = "Customer 02 do regular 01 ",
                     LastName = "Last Name Customer 02R",
                     Email = "customer02r@email.com",
                     Document = "952.746.830-61",
                     DateBirth = DateTime.Parse("1994-02-02"),
                     StatusId = CustomerStatus.Active,
                     AddressId = new Guid("cd04928a-5934-4a9a-a68e-7cf38f2b8573"),
                     CareerId = new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"),
                     NationalityId = new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"),
                     PhoneId = new Guid("a52ef79d-f22c-4a44-8d92-2fcf4823188b"),
                     UserId = new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041"),
                     CreatedAt = DateTime.UtcNow.AddHours(3)
                 },
                 new CustomerEntity()
                 {
                     Id = new Guid("0c0e881c-61cf-4d12-8788-94e118d22177"),
                     FirstName = "Customer 03 do regular 01 ",
                     LastName = "Last Name Customer 02R",
                     Email = "customer03r@email.com",
                     Document = "367.195.482-34",
                     DateBirth = DateTime.Parse("1994-02-02"),
                     StatusId = CustomerStatus.Active,
                     AddressId = new Guid("f2427d11-9e8e-4cf8-976a-482207798ff6"),
                     CareerId = new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"),
                     NationalityId = new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"),
                     PhoneId = new Guid("2b2f3f5f-dfb9-4fe6-98a2-6664b9c6ab08"),
                     UserId = new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041"),
                     CreatedAt = DateTime.UtcNow.AddHours(3)
                 }
           );
        }
    }
}