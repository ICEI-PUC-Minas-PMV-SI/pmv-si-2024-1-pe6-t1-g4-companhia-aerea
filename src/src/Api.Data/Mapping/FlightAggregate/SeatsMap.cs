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
    public class SeatsMap : IEntityTypeConfiguration<SeatsEntity>
    {
        public void Configure(EntityTypeBuilder<SeatsEntity> builder)
        {
            builder.ToTable("Seats");

            builder.HasKey(x => x.Id);

            builder.Ignore(b => b.FlightId);

            builder.Property(x => x.Column)
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(x => x.Row)
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(x => x.Available)
                .IsRequired();

            builder.Property(x => x.Price)
               .HasColumnType("decimal(8,2)")
               .IsRequired();
        }
    }
}
