using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.Home
{

    public class _CreatorLayoutHeaderDesktopPartial:ViewComponent
    {
        private readonly UserManager<Creator> _userManager;
        public _CreatorLayoutHeaderDesktopPartial(UserManager<Creator> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = values.Name;
            ViewBag.Surname = values.Surname;
            ViewBag.Email= values.Email;
            return View();
        }
    }
}
