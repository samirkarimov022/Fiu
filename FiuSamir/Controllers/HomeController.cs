using Microsoft.AspNetCore.Mvc;

namespace FiuSamir.Controllers
{
	public class HomeController:Controller		
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ContacUs()
		{
			return View();
		}
	}
}
