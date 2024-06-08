using Api.Domain.Entities.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.FlightAggregate;

namespace Data.Mapping.FlightAggregate
{
    public class FlightMap : IEntityTypeConfiguration<FlightEntity>
    {
        public void Configure(EntityTypeBuilder<FlightEntity> builder)
        {
            builder.ToTable("Flights");

            builder.HasKey(x => x.Id);

            builder.Ignore(b => b.Seats);
            builder.Ignore(b => b._seats);
            builder.Ignore(b => b.FlightIntinerary);

            builder.HasIndex(x => x.FlightCode)
                .IsUnique();

            builder.Property(x => x.FlightCode)
                .IsRequired();

            builder.Property(x => x.FlightStatusId)
                .IsRequired();

            builder
                .HasMany(nameof(FlightEntity.Seats))
                .WithOne()
                .HasForeignKey("FlightId")
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(p => p.FlightIntineraryId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("FlightIntineraryId")
                .IsRequired();

            builder.HasOne<FlightItineraryEntity>()
                .WithMany()
                .HasForeignKey(i => i.FlightIntineraryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
