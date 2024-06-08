using Api.Domain.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class FlightIntineraryMap : IEntityTypeConfiguration<FlightIntineraryEntity>
    {
        public void Configure(EntityTypeBuilder<FlightIntineraryEntity> builder)
        {
            builder.ToTable("FlightIntineraries");

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
          

            builder.HasOne<IataEntity>()
                .WithMany("FlightIntineraries")
                .HasForeignKey("LeaveIATAId")
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.ArriveIATAId)
                .IsRequired();

            builder.HasOne<IataEntity>()
                .WithMany("FlightIntineraries")
                .HasForeignKey("ArriveIATAId")
                .OnDelete(DeleteBehavior.NoAction);

          
        }
    }
}
