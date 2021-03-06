using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Stores;

namespace PizzaBox.Domain.Abstracts
{
  [XmlInclude(typeof(ChicagoStore))]
  [XmlInclude(typeof(NewYorkStore))]
  public abstract class AStore : AEntity
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    /// <summary>
    /// Overrides ToStrings to display Name property
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }
  }
}