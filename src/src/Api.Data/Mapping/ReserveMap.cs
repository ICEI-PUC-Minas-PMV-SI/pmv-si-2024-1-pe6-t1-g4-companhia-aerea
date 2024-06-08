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
    public class ReserveMap: IEntityTypeConfiguration<ReserveEntity>   
    {
        public void Configure(EntityTypeBuilder<ReserveEntity> builder)
        {

            builder.ToTable("Reserves");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.ReserveCode)
                .IsUnique();

            builder.Property(x => x.ReserveCode)
              .IsRequired();
            builder.Property(x => x.ReserveStatus).IsRequired();
            builder.Property(x=> x.ExtraLuggage).IsRequired();

            builder.Property(x=>x.CustomerEntityId).IsRequired();
            builder.Property(x=>x.FlightEntityId).IsRequired();

            builder.HasOne<FlightEntity>().WithMany("Reserves").HasForeignKey("FlightEntityId")
              .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<CustomerEntity>().WithMany().HasForeignKey(x => x.CustomerEntityId).OnDelete(DeleteBehavior.NoAction);

            

        }
    }
}
