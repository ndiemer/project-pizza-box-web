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

    public abstract void AddCrust(Crust crust = null);

    public abstract void AddSize(Size size = null);

    public abstract void AddToppings(params Topping[] toppings);
  }
}