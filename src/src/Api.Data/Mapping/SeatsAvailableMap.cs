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
    public class SeatsAvailableMap : IEntityTypeConfiguration<SeatsAvailableEntity>
    {
        public void Configure(EntityTypeBuilder<SeatsAvailableEntity> builder)
        {
            builder.ToTable("SeatsAvailable");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Class);
            builder.Property(x=>x.Column);
            builder.Property(x=>x.Row);
            builder.Property(x=>x.Available);
            builder.Property(x=>x.FlightEntityId);

            builder.HasOne<FlightEntity>().WithMany(x=>x.SeatsAvailable).HasForeignKey(x=>x.FlightEntityId);
        }
    }
}
