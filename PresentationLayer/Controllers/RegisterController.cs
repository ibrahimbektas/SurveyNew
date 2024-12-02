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

        private async Task<string> GetGenderFromNameAsync(string name)
        {
            try
            {
                // HTTP Client oluştur
                using var client = new HttpClient();
                // API anahtarınızı buraya ekleyin
                var apiKey = "67496939c7b7019558710154";
                // Request URL oluştur
                var requestUrl = $"https://genderapi.io/api/?name={name}&key={apiKey}";

                // API çağrısı yap
                var response = await client.GetAsync(requestUrl);

                // Eğer başarılıysa sonucu işle
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    // Dönen JSON'dan "gender" alanını al
                    return json.gender; // "male", "female" veya "unknown" dönebilir
                }

                return "unknown"; // Başarısız durum için default değer
            }
            catch (Exception ex)
            {
                // Hata durumunda default değer döndür
                Console.WriteLine($"Error fetching gender: {ex.Message}");
                return "unknown";
            }
        }


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
                var gender =await GetGenderFromNameAsync(creatorRegisterDto.Name);

                Creator creator = new Creator()
                {
                    Name = creatorRegisterDto.Name,
                    Surname = creatorRegisterDto.Surname,
                    UserName = creatorRegisterDto.Username,
                    Email = creatorRegisterDto.Email,
                    Gender = gender == "male" ? "Erkek" : "Kadın"
                };

                if (creator.Gender == "Erkek")
                {
                    creator.ProfilePicture = "ErkekProfilResmi.png";
                }
                else if(creator.Gender == "Kadın")
                {
                    creator.ProfilePicture = "KadinProfilResmi.png";
                }

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
