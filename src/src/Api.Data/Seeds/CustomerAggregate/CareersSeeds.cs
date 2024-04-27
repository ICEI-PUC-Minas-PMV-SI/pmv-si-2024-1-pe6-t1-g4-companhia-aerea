using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Seeds.CustomerAggregates
{
    public static class CareersSeeds
    {
        public static void Careers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CareerEntity>().HasData(

                new CareerEntity()
                {
                    Id = new Guid("eb15eaef-b653-4ccc-a0cd-b2720da41d55"),
                    Description = "Desenvolvedor de Software",
                    AverageWage = 7650.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("46e17017-2f85-4968-80b6-4ff1c0fc2db7"),
                    Description = "Engenheiro Civil",
                    AverageWage = 9500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("7a4a0108-7d57-4485-a1cf-ae7b239c1573"),
                    Description = "Médico Cirurgião",
                    AverageWage = 18000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("f22844bb-7601-439d-b6f0-d6cc1d510e0e"),
                    Description = "Professor Universitário",
                    AverageWage = 8500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("30254dd1-bd95-4e12-9e7c-5bdc40aa61b1"),
                    Description = "Advogado",
                    AverageWage = 9500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("82301e43-8ec9-4e7f-8a5a-3c9bc2a1a660"),
                    Description = "Enfermeiro",
                    AverageWage = 5500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("ebbe4f7a-f025-4db4-8b52-ae0a0e3d09f7"),
                    Description = "Analista Financeiro",
                    AverageWage = 8500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("0ec49ed6-1a07-4e63-b3d2-4ac3cb56a962"),
                    Description = "Designer Gráfico",
                    AverageWage = 6000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("a882f777-00a3-4b98-92e8-625ca8d444c0"),
                    Description = "Farmacêutico",
                    AverageWage = 7500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("506cb080-4a8b-42a3-9f34-bde6e1a40e9b"),
                    Description = "Chef de Cozinha",
                    AverageWage = 6000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("61ad6489-fb49-4782-8c4b-ef9b7fb5b4c7"),
                    Description = "Engenheiro de Software",
                    AverageWage = 8500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("ba8c526d-ec49-4469-a0e6-01d63f68712f"),
                    Description = "Psicólogo Clínico",
                    AverageWage = 7000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("fd484e11-26b4-4e54-9f1e-66e3e529180d"),
                    Description = "Engenheiro Mecânico",
                    AverageWage = 9000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("8e088726-ae8b-4211-8c19-cb20f97a0948"),
                    Description = "Piloto de Avião",
                    AverageWage = 12000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("6371818f-7e95-4c65-a67f-19b74f87f47e"),
                    Description = "Arquiteto",
                    AverageWage = 8000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("79295cb4-f755-4575-8049-f13e74cb19f4"),
                    Description = "Analista de Sistemas",
                    AverageWage = 7800.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("5af956fc-1bb9-44d0-9ee1-6435ff7e5de2"),
                    Description = "Dentista",
                    AverageWage = 8500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("c55e8fb0-df1f-43e8-8e07-f81a4463d0a4"),
                    Description = "Contador",
                    AverageWage = 8000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("8b3e12cf-8a0b-4d96-8a29-7614bf18d2bc"),
                    Description = "Fotógrafo",
                    AverageWage = 5000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("4b42eeed-b9c4-43e2-8151-eb18df5f1e2b"),
                    Description = "Analista de Marketing",
                    AverageWage = 7000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("2fc86ba3-6479-454a-9bc7-9e8ec1b78492"),
                    Description = "Auxiliar Administrativo",
                    AverageWage = 2800.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("d60ed8ae-6d30-4c2a-b946-6c751a18b871"),
                    Description = "Atendente de Telemarketing",
                    AverageWage = 2500.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("671892c6-002f-4a48-9913-3b10e20697d3"),
                    Description = "Recepcionista",
                    AverageWage = 3000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("94edfb10-7361-4708-924f-50b3b3ff17d6"),
                    Description = "Auxiliar de Limpeza",
                    AverageWage = 2000.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new CareerEntity()
                {
                    Id = new Guid("a76f70c6-6c2d-4d09-b9a0-7dc7f21ef16d"),
                    Description = "Ajudante de Cozinha",
                    AverageWage = 1800.00,
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                }

            );
        }
    }
}