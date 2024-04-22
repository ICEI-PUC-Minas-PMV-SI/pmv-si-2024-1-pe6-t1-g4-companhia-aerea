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
    public class FlightMap : IEntityTypeConfiguration<FlightEntity>
    {
        public void Configure(EntityTypeBuilder<FlightEntity> builder)
        {
            builder.ToTable("Flight");

            builder.HasKey(u => u.Id);
        }
    }
}
