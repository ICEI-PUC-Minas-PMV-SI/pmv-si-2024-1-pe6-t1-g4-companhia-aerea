using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(u => u.Email)
               .IsRequired()
               .HasMaxLength(200);

            builder.Property(u => u.Password)
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(u => u.DateBirth)
               .IsRequired()
               .HasColumnType("DATE");

            builder.Property(u => u.Status)
               .IsRequired();

            builder.Property(u => u.TypeUser)
               .IsRequired();
        }
    }
}
