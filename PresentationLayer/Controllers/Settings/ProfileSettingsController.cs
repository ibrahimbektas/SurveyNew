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
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            // Kullanıcı bilgilerini güncelle
            user.Name = creatorEditDto.Name;
            user.Surname = creatorEditDto.Surname;
            user.PhoneNumber = creatorEditDto.PhoneNumber;
            user.Email = creatorEditDto.Email;

            // Şifreyi kontrol et ve güncelle
            if (!string.IsNullOrEmpty(creatorEditDto.Password) &&
                creatorEditDto.Password == creatorEditDto.ConfirmPassword)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, creatorEditDto.Password);
            }

            if (creatorEditDto.ProfilePicture!=null)
            {
                var extension =Path.GetExtension(creatorEditDto.ProfilePicture.FileName);
                var newImageName=Guid.NewGuid() + extension;
                var location=Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProfilePictures/", newImageName);
                var stream= new FileStream (location, FileMode.Create);
                creatorEditDto.ProfilePicture.CopyTo(stream);
                user.ProfilePicture=newImageName;
            }

            // Kullanıcıyı güncelle ve sonucu kontrol et
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                // Şifre güncellenmişse kullanıcıyı yeniden giriş yapmaya yönlendir
                if (!string.IsNullOrEmpty(creatorEditDto.Password))
                {
                    return RedirectToAction("Index", "Login");
                }
                // Şifre güncellenmediyse anketlere yönlendir
                return RedirectToAction("Index", "MyAllSurveys");
            }

            // Güncelleme başarısız olursa aynı sayfayı döndür
            return View();

            return View();
        }
    }
}
