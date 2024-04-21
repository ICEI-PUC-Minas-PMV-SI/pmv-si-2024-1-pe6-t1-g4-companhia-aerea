using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping.CustomerAggregate
{
    public class CareerMap : IEntityTypeConfiguration<CareerEntity>
    {
        public void Configure(EntityTypeBuilder<CareerEntity> builder)
        {
            builder.ToTable("Career");

            builder.HasKey(u => u.Id);
        }
    }
}
