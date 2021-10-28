using DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseContext.TypeConfigurations
{
    internal class PizzasCatalogConfiguration : IEntityTypeConfiguration<PizzasCatalogEntity>
    {
        public void Configure(EntityTypeBuilder<PizzasCatalogEntity> builder)
        {
            builder.ToTable("PizzasCatalog");

            builder.HasKey(it => it.Id);

            builder.HasIndex(it => it.PizzaId);

            builder.Property(it => it.PizzaId)
                .IsRequired();

            builder.Property(it => it.ThinDoughAvailable)
                .HasColumnType("BIT")
                .IsRequired();
        }
    }
}
