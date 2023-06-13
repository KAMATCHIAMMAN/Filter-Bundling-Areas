using Microsoft.AspNetCore.Mvc;

namespace FildterAndBundlingDemo.Areas.Tutorial.Controllers
{
	public class HomeController : Controller
	{
		[Area("Tutorial")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
