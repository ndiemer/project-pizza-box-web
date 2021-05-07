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
    // public Customer Customer { get; set; }
    // public AStore Store { get; set; }
    public List<APizza> Pizzas { get; set; }

    // public decimal TotalCost
    // {
    //   get
    //   {
    //     var total = 0m;
    //     foreach (APizza pizza in Pizzas)
    //     {
    //       total = Decimal.Add(pizza.Crust.Price, pizza.Size.Price);
    //     }
    //     return Pizza.Crust.Price + Pizza.Size.Price + Pizza.Toppings.Sum(t => t.Price);
    //   }
    // }
  }
}