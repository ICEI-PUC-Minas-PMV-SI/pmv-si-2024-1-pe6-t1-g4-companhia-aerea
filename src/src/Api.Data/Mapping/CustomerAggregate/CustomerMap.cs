using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping.CustomerAggregate
{
    public class CustomerMap : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(u => u.DateBirth)
                .IsRequired()
                .HasColumnType("DATE");

            builder
                .Property(p => p.AddressId)
                .IsRequired();

            builder.HasOne<AddressEntity>()
                .WithMany()
                .HasForeignKey(i => i.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(p => p.UserId)
                .IsRequired();

            builder.HasOne<UserEntity>()
                .WithMany()
                .HasForeignKey(i => i.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(p => p.PhoneId)
                .IsRequired();

            builder.HasOne<PhoneEntity>()
                .WithMany()
                .HasForeignKey(i => i.PhoneId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(p => p.CareerId);

            builder.HasOne<CareerEntity>()
                .WithMany()
                .HasForeignKey(i => i.CareerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
