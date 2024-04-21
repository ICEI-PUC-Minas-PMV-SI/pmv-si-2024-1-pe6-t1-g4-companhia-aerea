using Domain.Entities.PaymentAggregate;
using Domain.Entities.PurchaseAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.PurchaseAggregate
{
    public class PaymentMap : IEntityTypeConfiguration<PaymentEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
            builder.ToTable("Payment");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.PaymentCode)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.SubTotal)
               .IsRequired();

            builder.Property(u => u.Total)
              .IsRequired();
        }
    }


}
