using DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseContext.TypeConfigurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(it => it.Id);

            builder.Property(it => it.Name)
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(it => it.Description)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(it => it.Category)
                .IsRequired();

            builder.Property(it => it.Rating)
                .IsRequired();

            builder.Property(it => it.ImageSrc)
                .HasMaxLength(256)
                .IsRequired();
        }
    }
}
