using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
  public class MeatPizza : APizza
  {

    public override void AddCrust(Crust crust)
    {
      Crust = crust ?? new Crust() { Name = "Original", Price = 4M };
    }

    public override void AddSize(Size size = null)
    {
      Size = size ?? new Size() { Name = "Medium", Price = 10M };
    }

    public override void AddToppings(params Topping[] toppings)
    {
      Toppings = new List<Topping>()
      {
        new Topping() { Name = "Mozzarella" },
        new Topping() { Name = "Marinara" }
      };
    }

  }
}