using Domain.Entities.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.FlightAggregate
{
    public class IataMap : IEntityTypeConfiguration<IataEntity>
    {
        public void Configure(EntityTypeBuilder<IataEntity> builder)
        {
            builder.ToTable("Iata");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.IATACode)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(x => x.Airport)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Location)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.Available)
                .IsRequired();

            builder.HasOne(x => x.FlightItinerary)
                .WithOne(x => x.LeaveIATA)
                .HasForeignKey<FlightItineraryEntity>(x => x.LeaveIATAId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.FlightItinerary)
                .WithOne(x => x.ArriveIATA)
                .HasForeignKey<FlightItineraryEntity>(x => x.ArriveIATAId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
