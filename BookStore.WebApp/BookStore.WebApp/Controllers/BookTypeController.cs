using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebApp.Controllers
{
	public class BookTypeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
