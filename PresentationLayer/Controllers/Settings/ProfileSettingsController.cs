using DtoLayer.Dtos.CreatorDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers.Settings
{
    public class ProfileSettingsController : Controller
    {
        private readonly UserManager<Creator> _userManager;

        public ProfileSettingsController(UserManager<Creator> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            CreatorEditDto creatorEditDto = new CreatorEditDto();
            creatorEditDto.Name = values.Name;
            creatorEditDto.Surname = values.Surname;
            creatorEditDto.PhoneNumber = values.PhoneNumber;
            creatorEditDto.Email = values.Email;
            return View(creatorEditDto);
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreatorEditDto creatorEditDto)
        {
            if (creatorEditDto.Password == creatorEditDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = creatorEditDto.Name;
                user.Surname = creatorEditDto.Surname;
                user.PhoneNumber = creatorEditDto.PhoneNumber;
                user.Email = creatorEditDto.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, creatorEditDto.Password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
