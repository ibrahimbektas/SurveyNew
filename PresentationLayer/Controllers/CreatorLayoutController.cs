using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CreatorLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
