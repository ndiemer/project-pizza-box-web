using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    private readonly PizzaBoxContext _context;

    public SizeRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Size t)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Size> Select(Func<Size, bool> expression)
    {
      return _context.Sizes.Where(expression);
    }

    public Size Update(Size t)
    {
      throw new System.NotImplementedException();
    }
  }
}