using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CreatorLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
