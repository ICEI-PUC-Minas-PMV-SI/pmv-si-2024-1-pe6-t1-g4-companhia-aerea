using Domain.Entities.PaymentAggregate;
using Domain.Entities.PurchaseAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.PurchaseAggregate
{
    public class PurchaseMap : IEntityTypeConfiguration<PurchaseEntity>
    {
        public void Configure(EntityTypeBuilder<PurchaseEntity> builder)
        {
            builder.ToTable("Purchase");

            builder.HasKey(u => u.Id);
            
        }
    }


}
