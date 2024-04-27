using Api.Domain.Entities.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.FlightAggregate
{
    public class SeatsAvailableMap : IEntityTypeConfiguration<SeatsAvailableEntity>
    {
        public void Configure(EntityTypeBuilder<SeatsAvailableEntity> builder)
        {
            builder.ToTable("SeatsAvailable");

            builder.HasKey(u => u.Id);
        }
    }
}
