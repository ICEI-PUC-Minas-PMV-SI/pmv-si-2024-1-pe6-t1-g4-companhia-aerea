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
            builder.ToTable("FlightIntinerary");

            builder.HasKey(x => x.Id);

            builder.Ignore(b => b.LeaveIATA);

            builder.Ignore(b => b.ArriveIATA);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Available)
                .IsRequired();

            //builder.Property(x => x.LeaveDate)
            //    .HasColumnType("DATE");

            //builder.Property(x => x.ArriveDate)
            //    .HasColumnType("DATE");

            builder
                .Property(p => p.ArriveIATAId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("ArriveIATAID")
                .IsRequired();

            builder.HasOne<IataEntity>()
                .WithMany()
                .HasForeignKey(i => i.ArriveIATAId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(p => p.LeaveIATAId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("LeaveIATAId")
                .IsRequired();

            builder.HasOne<IataEntity>()
                .WithMany()
                .HasForeignKey(i => i.LeaveIATAId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
