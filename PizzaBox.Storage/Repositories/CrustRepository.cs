using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Crust t)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Crust> Select()
    {
      return new List<Crust> { new Crust(), new Crust() };
    }

    public Crust Update(Crust t)
    {
      throw new System.NotImplementedException();
    }
  }
}