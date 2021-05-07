using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class OrderRepository : IRepository<Order>
  {
    private readonly PizzaBoxContext _context;

    public OrderRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Order entry)
    {
      _context.Orders.Add(entry);
      return true;
    }

    public IEnumerable<Order> Select(Func<Order, bool> expression)
    {
      throw new System.NotImplementedException();
    }

    public Order Update(Order t)
    {
      throw new System.NotImplementedException();
    }
  }
}