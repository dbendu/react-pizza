using DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseContext.TypeConfigurations
{
    internal class PizzaCatalogComponentsConfiguration : IEntityTypeConfiguration<PizzaCatalogComponentsEntity>
    {
        public void Configure(EntityTypeBuilder<PizzaCatalogComponentsEntity> builder)
        {
            builder.ToTable("PizzaCatalogComponents");

            builder.HasKey(it => new { it.CatalogId, it.ComponentId });

            builder
                .HasOne(it => it.Component)
                .WithMany()
                .HasForeignKey(it => it.ComponentId)
                .IsRequired();

            builder
                .HasOne(it => it.Catalog)
                .WithMany(catalog => catalog.Components)
                .HasForeignKey(it => it.CatalogId)
                .IsRequired();
        }
    }
}
