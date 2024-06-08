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
    public class IataMap : IEntityTypeConfiguration<IataEntity>
    {
        public void Configure(EntityTypeBuilder<IataEntity> builder)
        {
            builder.ToTable("Iatas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.IATACode)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(x => x.Airport)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Location)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Available)
                .IsRequired();
        }
    }
}
