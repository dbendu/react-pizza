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

            builder.Property(it => it.Category)
                .IsRequired();

            builder.Property(it => it.ThinDoughAvailable)
                .HasColumnType("BIT")
                .IsRequired();

            builder
                .HasOne(it => it.Pizza)
                .WithMany()
                .HasForeignKey(it => it.PizzaId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
