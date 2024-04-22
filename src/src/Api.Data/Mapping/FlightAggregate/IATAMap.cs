using Api.Domain.Entities.FlightAggregate;
using Domain.Entities.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.FlightAggregate
{
    public class IATAMap : IEntityTypeConfiguration<IATAEntity>
    {
        public void Configure(EntityTypeBuilder<IATAEntity> builder)
        {
            builder.ToTable("IATA");

            builder.HasKey(u => u.Id);
        }
    }
}
