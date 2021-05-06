using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class OrderRepository : IRepository<Order>
  {
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Order t)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Order> Select()
    {
      throw new System.NotImplementedException();
    }

    public Order Update(Order t)
    {
      throw new System.NotImplementedException();
    }
  }
}