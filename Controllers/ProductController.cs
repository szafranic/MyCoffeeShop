using Microsoft.AspNetCore.Mvc;
using MyCoffeeShop.Models;

namespace MyCoffeeShop.Controllers
{
    public class ProductController : Controller
    {
		CoffeeContext db = new CoffeeContext();
		public IActionResult Index()
        {
			List<Product> products = db.Products.ToList();
			return View(products);
        }
		public IActionResult Detail(int type)
		{
			Product result = db.Products.Find(type);
			return View(result);
		}
		public IActionResult List(string type)
		{
			List<Product> products = db.Products.Where(x => x.Category == type).ToList();
			return View(products);
		}
	}
}
