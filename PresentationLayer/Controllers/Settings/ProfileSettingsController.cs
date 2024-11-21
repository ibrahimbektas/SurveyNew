using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers.Settings
{
    public class ProfileSettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
