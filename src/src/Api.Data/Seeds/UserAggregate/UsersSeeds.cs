using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Seeds.UserAggregate
{
    public static class UsersSeeds
    {
        public static void Users(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity()
                {
                    Id = new Guid("12c55a0e-771a-41bb-9b2a-9094db0ee7f8"),
                    FirstName = "User Adm",
                    LastName = "Adm Master",
                    Email = "user1@email.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("string"),
                    DateBirth = DateTime.Parse("2000-01-01"),
                    Status = UserStatus.Active,
                    TypeUser = TypeUser.Admin,
                    CreatedAt = DateTime.UtcNow
                },
                new UserEntity()
                {
                    Id = new Guid("5e1849cd-ddee-4982-b4c6-8d4b3c20b041"),
                    FirstName = "User Regular",
                    LastName = "Last Regular",
                    Email = "user2@email.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("string"),
                    DateBirth = DateTime.Parse("1990-01-01"),
                    Status = UserStatus.Active,
                    TypeUser = TypeUser.Regular,
                    CreatedAt = DateTime.UtcNow
                },
                new UserEntity()
                {
                    Id = new Guid("7fc20e97-a58d-4c92-b2c2-a41eedd931e1"),
                    FirstName = "Jose",
                    LastName = "Pereira",
                    Email = "jose@email.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("string"),
                    DateBirth = DateTime.Parse("1992-01-01"),
                    Status = UserStatus.Active,
                    TypeUser = TypeUser.Regular,
                    CreatedAt = DateTime.UtcNow
                }
            );

        }
    }
}