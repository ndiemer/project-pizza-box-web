using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {

    public string Order(OrderViewModel order)
    {
      return order.SelectedCrust;
    }
  }
}