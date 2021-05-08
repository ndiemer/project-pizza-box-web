using PizzaBox.Domain.Models.Pizzas;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class PizzaTests
  {
    [Fact]
    public void Test_CustomPizza()
    {
      var sut = new CustomPizza();

      Assert.NotNull(sut);
    }
  }
}