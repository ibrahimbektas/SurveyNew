using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers.QuestionPool
{
    public class QuestionSearchController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionSearchController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public IActionResult Index()
        {
            var values = _questionService.TGetPublicQuestionList();
            return View(values);
        }
    }
}
