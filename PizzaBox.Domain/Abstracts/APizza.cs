using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class APizza : AEntity
  {
    public Crust Crust { get; set; }
    public long CrustEntityId { get; set; }
    public Size Size { get; set; }
    public long SizeEntityId { get; set; }
    public Order Order { get; set; }
    public long OrderEntityId { get; set; }
    public List<Topping> Toppings { get; set; }

    protected APizza()
    {
      Factory();
    }

    public virtual void Factory()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    /// <summary>
    /// Will Set crust property to a Crust object passed to it
    /// </summary>
    /// <param name="crust"></param>
    public abstract void AddCrust(Crust crust = null);

    /// <summary>
    /// Will Set size property to a Size object passed to it
    /// </summary>
    /// <param name="size"></param>
    public abstract void AddSize(Size size = null);

    /// <summary>
    /// Will set Toppings property using a list of Topping objects
    /// </summary>
    /// <param name="toppings"></param>
    public abstract void AddToppings(params Topping[] toppings);
  }
}