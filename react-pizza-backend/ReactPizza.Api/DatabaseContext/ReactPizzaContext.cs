using System;
using DatabaseContext.Entities;
using DatabaseContext.TypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContext
{
    public class ReactPizzaContext : DbContext
    {
        public const string ContextName = "ReactPizza";

        public ReactPizzaContext(DbContextOptions<ReactPizzaContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<PizzasCatalogEntity> PizzasCatalog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaComponentConfiguration());
            modelBuilder.ApplyConfiguration(new PizzasCatalogConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaCatalogComponentsConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(false);
            optionsBuilder.LogTo(Console.WriteLine);
        }
            
    }
}
