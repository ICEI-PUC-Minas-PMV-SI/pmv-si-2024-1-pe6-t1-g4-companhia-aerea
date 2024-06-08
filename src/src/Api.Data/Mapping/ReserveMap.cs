using Api.Domain.Entities;
using Api.Domain.Entities.CustomerAggregate;
using Domain.Entities;
using Domain.Entities.FlightAggregate;
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

            builder.Property(x=>x.CustomerId).IsRequired();

            builder.HasOne<CustomerEntity>().WithMany().HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.NoAction);


            builder.Property(x => x.FlightId).IsRequired();

            builder.HasOne<FlightEntity>().WithOne().HasForeignKey("ReserveEntity","FlightId").OnDelete(DeleteBehavior.NoAction);

        }
    }
}
