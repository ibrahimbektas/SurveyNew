using DataAccessLayer.Concrete;
using DtoLayer.Dtos.SurveyDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers.MakeNewSurvey
{
    public class MakeSpecialSurvey : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SurveyRegisterInfos(SurveyRegisterInfosDto dto)
        {
            var context = new Context();

            Console.WriteLine($"DTO'dan gelen IsPublic değeri: {dto.IsPublic}");

            if (ModelState.IsValid)
            {
                // DTO'dan Entity'ye dönüşüm
                Survey survey = new Survey()
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    Category = dto.Category,
                    IsPublic = dto.IsPublic,
                    Version = dto.Version,
                    CreatorID = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value), // Giriş yapan kullanıcının Id'si
                    CreationDate = DateTime.Now
                };

                // Veritabanına kaydet
                context.Surveys.Add(survey);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(dto);
        }
    }
}
