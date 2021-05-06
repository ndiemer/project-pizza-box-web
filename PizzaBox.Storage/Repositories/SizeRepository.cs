using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Size t)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Size> Select()
    {
      return new List<Size> { new Size(), new Size() };
    }

    public Size Update(Size t)
    {
      throw new System.NotImplementedException();
    }
  }
}