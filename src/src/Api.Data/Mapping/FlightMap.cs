using Api.Domain.Entities;
using Api.Domain.Entities.CustomerAggregate;
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

            builder.Property(x => x.FlightIntineraryEntityId);


            builder.HasOne<FlightIntineraryEntity>().WithMany()
               .HasForeignKey(f=>f.FlightIntineraryEntityId)
               .OnDelete(DeleteBehavior.NoAction);


            builder.Property(x => x.FlightStatus)
                .IsRequired();

            //builder.Navigation("FlightIntinerary");
        }
    }
}
