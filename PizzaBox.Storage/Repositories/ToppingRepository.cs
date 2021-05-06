using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class ToppingRepository : IRepository<Topping>
  {
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Topping t)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Topping> Select()
    {
      return new List<Topping>() { new Topping(), new Topping() };
    }

    public Topping Update(Topping t)
    {
      throw new System.NotImplementedException();
    }
  }
}