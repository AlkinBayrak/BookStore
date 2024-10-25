using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebApp.Controllers
{
	public class AuthorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
