using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class SurveyMake : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
