using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebApp.Controllers
{
	public class PublisherController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
