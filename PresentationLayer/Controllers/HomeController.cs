using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Diagnostics;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Creator> _userManager;
        private readonly ISurveyService _surveyService;

        public HomeController(ILogger<HomeController> logger, UserManager<Creator> userManager, ISurveyService surveyService)
        {
            _logger = logger;
            _userManager = userManager;
            _surveyService = surveyService;
        }

        public async Task<IActionResult>  Index()
        {
            var user=await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();
            var values=_surveyService.TGetSurveyList(user.Id);
            return View(values);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
