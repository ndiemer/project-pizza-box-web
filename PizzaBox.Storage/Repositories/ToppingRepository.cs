using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class ToppingRepository : IRepository<Topping>
  {
    private readonly PizzaBoxContext _context;

    public ToppingRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Topping entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Topping> Select(Func<Topping, bool> expression)
    {
      return _context.Toppings.Where(expression);
    }

    public Topping Update(Topping t)
    {
      throw new System.NotImplementedException();
    }
  }
}