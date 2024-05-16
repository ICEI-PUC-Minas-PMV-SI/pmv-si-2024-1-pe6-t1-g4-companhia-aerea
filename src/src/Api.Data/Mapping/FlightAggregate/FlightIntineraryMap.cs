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
    public class FlightIntineraryMap : IEntityTypeConfiguration<FlightItineraryEntity>
    {
        public void Configure(EntityTypeBuilder<FlightItineraryEntity> builder)
        {
            builder.ToTable("Intinerary");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Available)
                .IsRequired();

            builder.Property(x => x.LeaveDate)
                .HasColumnType("DATE");

            builder.Property(x => x.ArriveDate)
                .HasColumnType("DATE");

            builder.Property(x => x.LeaveIATAId)
           .IsRequired();

            builder.HasOne(x => x.LeaveIATA)
                .WithOne(x => x.FlightItinerary)
                .HasForeignKey<FlightItineraryEntity>(x => x.LeaveIATAId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.ArriveIATAId)
            .IsRequired();

            builder.HasOne(x => x.ArriveIATA)
                .WithOne(x => x.FlightItinerary)
                .HasForeignKey<FlightItineraryEntity>(x => x.ArriveIATAId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
