using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Seeds.CustomerAggregates
{
    public static class AddressesSeeds
    {
        public static void Addresses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressEntity>().HasData(
                new AddressEntity()
                {
                    Id = new Guid("22ca315c-e483-48c4-9483-d1c0904fee9d"),
                    ZipCode = "31615-520",
                    Country = "Brasil",
                    State = "MG",
                    City = "Belo Horizonte",
                    Neighborhood = "Esmelo",
                    Street = "Rua dos Bobos",
                    Number = "0",
                    Complement = "Casa",
                    CreatedAt = DateTime.UtcNow
                },
                new AddressEntity()
                {
                    Id = new Guid("8ff920eb-58f6-4b4c-a4f1-2e4bf62a7741"),
                    ZipCode = "70000-000",
                    Country = "Brasil",
                    State = "DF",
                    City = "Brasília",
                    Neighborhood = "Asa Sul",
                    Street = "Quadra 300",
                    Number = "S/N",
                    Complement = "Apartamento",
                    CreatedAt = DateTime.UtcNow
                },
                new AddressEntity()
                {
                    Id = new Guid("e82a1e06-57d7-4b2c-b8b6-1e7b013a2d05"),
                    ZipCode = "04101-000",
                    Country = "Brasil",
                    State = "SP",
                    City = "São Paulo",
                    Neighborhood = "Vila Mariana",
                    Street = "Avenida Paulista",
                    Number = "1000",
                    Complement = "Bloco B",
                    CreatedAt = DateTime.UtcNow
                },
                new AddressEntity()
                {
                    Id = new Guid("40b3e7df-4ff9-4d8d-bc2d-7f5c6481ff1d"),
                    ZipCode = "20540-060",
                    Country = "Brasil",
                    State = "RJ",
                    City = "Rio de Janeiro",
                    Neighborhood = "Tijuca",
                    Street = "Rua Conde de Bonfim",
                    Number = "123",
                    Complement = "Casa 2",
                    CreatedAt = DateTime.UtcNow
                },
                new AddressEntity()
                {
                    Id = new Guid("cd04928a-5934-4a9a-a68e-7cf38f2b8573"),
                    ZipCode = "30140-061",
                    Country = "Brasil",
                    State = "MG",
                    City = "Belo Horizonte",
                    Neighborhood = "Centro",
                    Street = "Avenida Afonso Pena",
                    Number = "250",
                    Complement = "Sala 301",
                    CreatedAt = DateTime.UtcNow
                },
                new AddressEntity()
                {
                    Id = new Guid("f2427d11-9e8e-4cf8-976a-482207798ff6"),
                    ZipCode = "13400-000",
                    Country = "Brasil",
                    State = "SP",
                    City = "Piracicaba",
                    Neighborhood = "Centro",
                    Street = "Rua do Rosário",
                    Number = "789",
                    Complement = "Loja",
                    CreatedAt = DateTime.UtcNow
                }
           );
        }
    }
}