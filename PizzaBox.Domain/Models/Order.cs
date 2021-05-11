using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Pizzas;
// using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : AEntity
  {
    public Customer Customer { get; set; }
    public long CustomerEntityId { get; set; }
    public AStore Store { get; set; }
    public long StoreEntityId { get; set; }
    public List<APizza> Pizzas { get; set; }

    public decimal TotalCost
    {
      get
      {
        var total = 0M;
        foreach (APizza pizza in Pizzas)
        {
          total += pizza.Crust.Price + pizza.Size.Price + pizza.Toppings.Sum(t => t.Price);
        }
        return total;
      }
    }
  }
}