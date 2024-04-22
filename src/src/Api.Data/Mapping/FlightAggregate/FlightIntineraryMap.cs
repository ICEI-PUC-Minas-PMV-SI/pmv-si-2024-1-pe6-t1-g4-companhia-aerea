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
    public class FlightIntineraryMap : IEntityTypeConfiguration<FlightIntineraryEntity>
    {
        public void Configure(EntityTypeBuilder<FlightIntineraryEntity> builder)
        {
            builder.ToTable("FlightIntinerary");

            builder.HasKey(u => u.Id);
        }
    }
}
