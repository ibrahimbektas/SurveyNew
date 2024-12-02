using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Diagnostics;

namespace PresentationLayer.Controllers.MySurveys
{
    public class MyAllSurveysController : Controller
    {
        private readonly UserManager<Creator> _userManager;
        private readonly ISurveyService _surveyService;

        public MyAllSurveysController(UserManager<Creator> userManager, ISurveyService surveyService)
        {
            _userManager = userManager;
            _surveyService = surveyService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();
            var values = _surveyService.TGetSurveyList(user.Id);
            return View(values);
        }
    }
}
