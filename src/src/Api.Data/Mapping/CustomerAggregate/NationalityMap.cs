using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping.CustomerAggregate
{
    public class NationalityMap : IEntityTypeConfiguration<NationalityEntity>
    {
        public void Configure(EntityTypeBuilder<NationalityEntity> builder)
        {
            builder.ToTable("Nationality");

            builder.HasKey(u => u.Id);
        }
    }
}
