using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
        var customer = _unitOfWork.Customers.Select(c => c.Name == order.SelectedCustomer).First();
        var size = _unitOfWork.Sizes.Select(s => s.Name == order.SelectedSize).First();
        var store = _unitOfWork.Stores.Select(s => s.Name == order.SelectedStore).First();
        var toppings = new List<Topping>();

        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(_unitOfWork.Toppings.Select(t => t.Name == item).First());
        }

        var newPizza = new CustomPizza { Crust = crust, Size = size, Toppings = toppings };
        var newOrder = new Order { Pizzas = new List<APizza> { newPizza } };

        _unitOfWork.Orders.Insert(newOrder);
        _unitOfWork.Save();

        ViewBag.Order = newOrder;

        return View("checkout");
      }

      order.Load(_unitOfWork);

      return View("order", order);
    }
  }
}