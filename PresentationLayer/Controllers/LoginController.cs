﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<Creator> _userManager;
        private readonly SignInManager<Creator> _signInManager;

        public LoginController(UserManager<Creator> userManager, SignInManager<Creator> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel )
        {
            var result=await _signInManager.PasswordSignInAsync(loginViewModel.Username, loginViewModel.Password, false, true);
            if (result.Succeeded)
            {
                var user=await _userManager.FindByNameAsync(loginViewModel.Username);
                return RedirectToAction("Index", "MyAllSurveys");
            }
            else
            {
                return View();
            }
        }
    }
}
