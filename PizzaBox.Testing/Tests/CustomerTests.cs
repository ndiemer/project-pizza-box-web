using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class CustomerTests
  {
    /// <summary>
    /// Tests Customer is created and returns toString correctly
    /// </summary>
    [Fact]
    public void Test_Customer()
    {
      var sut = new Customer { Name = "Uncle Sam" };

      var actual = sut.Name;
      Assert.True(sut.ToString() == actual);
    }
  }
}