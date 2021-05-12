using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]/[action]")]
  public class HomeController : Controller
  {

    private readonly ILogger<HomeController> _logger;
    private readonly UnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, UnitOfWork unitOfWork)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Order()
    {
      var order = new OrderViewModel();

      order.Load(_unitOfWork);

      return View("order", order);
    }

    [HttpGet]
    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
