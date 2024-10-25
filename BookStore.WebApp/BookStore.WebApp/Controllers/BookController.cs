using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebApp.Controllers
{
	public class BookController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
