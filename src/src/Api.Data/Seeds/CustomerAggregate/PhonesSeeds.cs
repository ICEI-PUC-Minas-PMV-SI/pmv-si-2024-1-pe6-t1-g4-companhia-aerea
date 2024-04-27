using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Seeds.CustomerAggregates
{
    public static class PhonesSeeds
    {
        public static void Phones(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneEntity>().HasData(
                new PhoneEntity()
                {
                    Id = new Guid("f56171aa-4179-4668-9618-ca1676679449"),
                    CountryCode = "55",
                    DDD = "31",
                    Number = "9 9944-2621",
                    TypePhone = TypePhone.Mobile,
                    CreatedAt = DateTime.UtcNow
                },
                new PhoneEntity()
                {
                    Id = new Guid("316b3c7b-c399-403d-bd7e-98a085fb5d3a"),
                    CountryCode = "55",
                    DDD = "11",
                    Number = "3123-4567",
                    TypePhone = TypePhone.Home,
                    CreatedAt = DateTime.UtcNow
                },
                new PhoneEntity()
                {
                    Id = new Guid("73ed0e45-4740-4a6c-9348-fd97b405da2d"),
                    CountryCode = "55",
                    DDD = "21",
                    Number = "98765-4321",
                    TypePhone = TypePhone.Work,
                    CreatedAt = DateTime.UtcNow
                },
                new PhoneEntity()
                {
                    Id = new Guid("ec1ab1c0-c72a-4030-89f0-9833e9f621f4"),
                    CountryCode = "55",
                    DDD = "41",
                    Number = "99988-7766",
                    TypePhone = TypePhone.Mobile,
                    CreatedAt = DateTime.UtcNow
                },
                new PhoneEntity()
                {
                    Id = new Guid("a52ef79d-f22c-4a44-8d92-2fcf4823188b"),
                    CountryCode = "55",
                    DDD = "51",
                    Number = "3030-2020",
                    TypePhone = TypePhone.Home,
                    CreatedAt = DateTime.UtcNow
                },
                new PhoneEntity()
                {
                    Id = new Guid("2b2f3f5f-dfb9-4fe6-98a2-6664b9c6ab08"),
                    CountryCode = "55",
                    DDD = "61",
                    Number = "8765-4321",
                    TypePhone = TypePhone.Work,
                    CreatedAt = DateTime.UtcNow
                }

            );
        }
    }
}
