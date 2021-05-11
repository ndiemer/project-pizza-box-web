using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Customer : AEntity
  {
    public string Name { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}