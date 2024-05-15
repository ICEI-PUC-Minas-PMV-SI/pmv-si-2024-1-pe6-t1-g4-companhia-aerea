using Api.Domain.Entities.CustomerAggregate;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.FlightAggregate;

namespace Data.Mapping
{
    public class FlightMap : IEntityTypeConfiguration<FlightEntity>
    {
        public void Configure(EntityTypeBuilder<FlightEntity> builder)
        {
            builder.ToTable("Flights");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.FlightCode)
                .IsUnique();

            builder.Property(x => x.FlightCode)
                .IsRequired();

            builder.Property(x => x.FlightIntineraryId)
                .IsRequired();

            builder.HasOne<FlightIntineraryEntity>()
               .WithMany()
               .HasForeignKey(i => i.FlightIntineraryId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.SeatsAvailableId)
                .IsRequired();

            builder.Property(x => x.FlightStatusId)
                .IsRequired();
        }
    }
}
