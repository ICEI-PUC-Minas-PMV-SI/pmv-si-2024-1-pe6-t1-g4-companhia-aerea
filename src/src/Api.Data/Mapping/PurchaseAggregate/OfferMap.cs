using Domain.Entities.PurchaseAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.PurchaseAggregate
{
    public class OfferMap : IEntityTypeConfiguration<OffersEntity>
    {
        public void Configure(EntityTypeBuilder<OffersEntity> builder)
        {
            builder.ToTable("Offer");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.InitialDate)
                .IsRequired()
                .HasColumnType("DATE");

            builder.Property(u => u.ExpirationDate)
                .IsRequired()
                .HasColumnType("DATE");

            builder.Property(u => u.PromotionalCode)
                .IsRequired()
                .HasMaxLength(20);
        }
    }


}
