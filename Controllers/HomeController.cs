using Microsoft.AspNetCore.Mvc;
using MyCoffeeShop.Models;
using System.Diagnostics;

namespace MyCoffeeShop.Controllers
{
	public class HomeController : Controller
	{
		
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult Create()
		{
			return View();
		}
		public IActionResult Dashboard(Create l)
		{
			return View(l);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}