using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Stores;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class OrderTests
  {
    [Fact]
    public void Test_Order_Customer()
    {
      var sut = new Order()
      {
        Customer = new Customer() { Name = "TestCustomer" }
      };

      var actual = sut.Customer;

      Assert.True(sut.Customer == actual);
    }

    [Fact]
    public void Test_Order_Store()
    {
      var sut = new Order()
      {
        Store = new ChicagoStore()
      };

      var actual = sut.Store;

      Assert.True(sut.Store == actual);
    }

    [Fact]
    public void Test_Order_Pizza()
    {
      var sut = new Order()
      {
        Pizzas = new List<APizza> { new MeatPizza(), new CustomPizza() }
      };

      foreach (var pizza in sut.Pizzas)
      {
        var actual = pizza;

        Assert.True(pizza == actual);
      }
    }

    [Fact]
    public void Test_Order_Total()
    {
      var sut = new Order()
      {
        Pizzas = new List<APizza> { new MeatPizza() }
      };

      Assert.True(sut.TotalCost != 0);
    }
  }
}