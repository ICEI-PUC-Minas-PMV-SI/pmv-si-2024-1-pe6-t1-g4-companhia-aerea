using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping.CustomerAggregate
{
    public class PhoneMap : IEntityTypeConfiguration<PhoneEntity>
    {
        public void Configure(EntityTypeBuilder<PhoneEntity> builder)
        {
            builder.ToTable("Phone");

            builder.HasKey(u => u.Id);
        }
    }
}
