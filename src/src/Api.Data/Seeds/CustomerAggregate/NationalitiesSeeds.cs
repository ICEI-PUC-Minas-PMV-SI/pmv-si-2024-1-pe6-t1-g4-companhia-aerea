using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Seeds.CustomerAggregates
{
    public static class NationalitiesSeeds
    {
        public static void Nationalities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NationalityEntity>().HasData(
                new NationalityEntity()
                {
                    Id = new Guid("e8460494-91aa-4b03-8fd8-aefd7ad63164"),
                    Description = "Brasileira",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("66d38f80-5b2c-409e-b4f6-68b017af22db"),
                    Description = "Americana",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("ae7c6886-4a8c-4878-8ff6-5755046a93d8"),
                    Description = "Canadense",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("f700bd3b-1256-4f55-a682-d1e7c10f59a1"),
                    Description = "Mexicana",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("1c52d7f7-49ac-45b3-a3fc-8375068e97ae"),
                    Description = "Argentina",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("5f5e0a2c-4201-4a2e-80e5-85d1ee8cf077"),
                    Description = "Chilena",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("0a3a3f5f-bf97-4a64-bd07-1b45468de336"),
                    Description = "Inglesa",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("334f5a76-3b27-45f0-8371-75f36a7381c2"),
                    Description = "Francesa",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("d8f23df8-d9f6-4696-9b0b-1613c1e4ef63"),
                    Description = "Italiana",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("ca7ae9c3-62f3-4a05-b7ac-0c6e3f29b10e"),
                    Description = "Alemã",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("96e01522-d4b5-4d07-bfe6-f4c6151b2f33"),
                    Description = "Espanhola",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("f920c11e-f6f7-42a3-b3bc-83701241c781"),
                    Description = "Portuguesa",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("c301e7a7-d90e-47e3-b241-3fdad89d0b79"),
                    Description = "Sueca",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("7ff9a21e-3ff2-4ef0-aac1-1181a6ff7a78"),
                    Description = "Norueguesa",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("bd609feb-4d8e-4384-bcd1-7641fb4b3e1a"),
                    Description = "Japonesa",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("ec91c3d3-fb1c-44d1-a01e-af4bb1a4f3f5"),
                    Description = "Chinesa",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("a5658e1d-61ff-4e48-9a38-95bfb631e7a1"),
                    Description = "Russa",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("0e61a8b8-0a65-4e3e-9203-dbe526054bb4"),
                    Description = "Indiana",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("bb179145-250f-4260-80e0-232e5743ec7b"),
                    Description = "Coreana",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                },
                new NationalityEntity()
                {
                    Id = new Guid("cd1b540e-119a-4417-bf69-6fd4f8a558c1"),
                    Description = "Australiana",
                    Note = "",
                    CreatedAt = DateTime.UtcNow,
                }

            );
        }
    }
}