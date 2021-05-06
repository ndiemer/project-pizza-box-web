using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public string Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return "good request";
      }
      return "bad request";
    }
  }
}