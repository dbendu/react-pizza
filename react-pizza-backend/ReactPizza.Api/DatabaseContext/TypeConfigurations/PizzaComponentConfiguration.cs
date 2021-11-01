using DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseContext.TypeConfigurations
{
    public class PizzaComponentConfiguration : IEntityTypeConfiguration<PizzaComponentEntity>
    {
        public void Configure(EntityTypeBuilder<PizzaComponentEntity> builder)
        {
            builder.ToTable("PizzaComponent");

            builder.HasKey(it => it.Id);

            builder.HasIndex(it => new { it.Name, it.Weight, it.Price })
                .IsUnique();

            builder.Property(it => it.Name)
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(it => it.Weight)
                .IsRequired();

            builder.Property(it => it.Price)
                .IsRequired();

            builder.Property(it => it.Category)
                .IsRequired();
        }
    }
}
