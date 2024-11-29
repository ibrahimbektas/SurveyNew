using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers.QuestionPool
{
    public class QuestionSearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
