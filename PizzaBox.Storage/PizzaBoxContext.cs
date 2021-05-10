using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Storage
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<APizza> Pizzas { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<APizza>().HasKey(e => e.EntityId);
      builder.Entity<CustomPizza>().HasBaseType<APizza>();
      builder.Entity<MeatPizza>().HasBaseType<APizza>();
      builder.Entity<SupremePizza>().HasBaseType<APizza>();

      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);

      OnModelSeeding(builder);
    }

    private void OnModelSeeding(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasData(new[]
      {
        new Crust() { EntityId = 1, Name = "Original", Price = 4M },
        new Crust() { EntityId = 2, Name = "Thin", Price = 2M },
        new Crust() { EntityId = 3, Name = "Stuffed", Price = 7M }
      });

      builder.Entity<Size>().HasData(new[]
      {
        new Size() { EntityId = 1, Name = "Small", Price = 5M },
        new Size() { EntityId = 2, Name = "Medium", Price = 10M },
        new Size() { EntityId = 3, Name = "Large", Price = 15M }
      });

      builder.Entity<Topping>().HasData(new[]
      {
        new Topping() { EntityId = 1, Name = "Mozarella", Price = 1M },
        new Topping() { EntityId = 2, Name = "Pepperoni", Price = 2M },
        new Topping() { EntityId = 3, Name = "Bacon", Price = 3M },
        new Topping() { EntityId = 4, Name = "Ham", Price = 3M },
        new Topping() { EntityId = 5, Name = "Sausage", Price = 3M },
        new Topping() { EntityId = 6, Name = "Black Olives", Price = 1M },
        new Topping() { EntityId = 7, Name = "Green Peppers", Price = 1M }
      });

      // builder.Entity<MeatPizza>().HasData(new MeatPizza[]
      // {
      //   new MeatPizza() { EntityId = 1, CrustEntityId = 1, SizeEntityId = 2, OrderEntityId = 1 }
      // });
      // new SupremePizza() { EntityId = 2}
    }
  }
}