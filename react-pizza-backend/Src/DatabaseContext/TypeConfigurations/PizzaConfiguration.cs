using DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseContext.TypeConfigurations
{
    internal class PizzaConfiguration : IEntityTypeConfiguration<PizzaEntity>
    {
        public void Configure(EntityTypeBuilder<PizzaEntity> builder)
        {
            builder.ToTable("Pizza");

            builder.HasKey(it => it.Id);

            builder.Property(it => it.Name)
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(it => it.Description)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(it => it.Category)
                .IsRequired();
        }
    }
}
