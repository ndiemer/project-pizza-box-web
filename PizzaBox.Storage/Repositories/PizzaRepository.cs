using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Storage.Repositories
{
  public class PizzaRepository : IRepository<APizza>
  {
    private readonly PizzaBoxContext _context;

    public PizzaRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(APizza entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<APizza> Select(Func<APizza, bool> expression)
    {
      throw new System.NotImplementedException();
    }

    public APizza Update()
    {
      throw new System.NotImplementedException();
    }

    public APizza Update(APizza t)
    {
      throw new NotImplementedException();
    }
  }
}