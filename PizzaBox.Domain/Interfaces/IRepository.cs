using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository<T> where T : class
  {
    /// <summary>
    /// Read Entries
    /// </summary>
    /// <returns></returns>
    IEnumerable<T> Select(Func<T, bool> expression);

    /// <summary>
    /// Create Entry
    /// </summary>
    /// <param name="t"></param>
    bool Insert(T entry);

    /// <summary>
    /// Update an entry
    /// </summary>
    /// <param name="t"></param>
    T Update(T t);

    /// <summary>
    /// Delete an entry
    /// </summary>
    bool Delete();
  }
}