using BusinessLayer.Concrete;
using DtoLayer.Dtos.CreatorDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<Creator> _userManager;

        public RegisterController(UserManager<Creator> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreatorRegisterDto creatorRegisterDto)
        {
            if (creatorRegisterDto.Password != creatorRegisterDto.ConfirmPassword)
            {
                ModelState.AddModelError("", "Password and confirm password are not same.");
                return View();
            }

            if (ModelState.IsValid)
            {
                Creator creator = new Creator()
                {
                    Name = creatorRegisterDto.Name,
                    Surname = creatorRegisterDto.Surname,
                    UserName = creatorRegisterDto.Username,
                    Email = creatorRegisterDto.Email
                };
                var result = await _userManager.CreateAsync(creator, creatorRegisterDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
