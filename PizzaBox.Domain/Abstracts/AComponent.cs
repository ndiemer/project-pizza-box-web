using System.Collections.Generic;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  public class AComponent : AEntity
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ICollection<APizza> Pizzas { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{Name}";
    }
  }
}