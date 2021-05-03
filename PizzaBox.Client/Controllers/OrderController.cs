using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  public class OrderController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}