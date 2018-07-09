using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using ArthausWebStore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace ArthausWebStore.Controllers
{
    public class AccountController : Controller

    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager,
                         SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, true, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                        return RedirectToAction("Index", "Home");

                    return Redirect(loginViewModel.ReturnUrl);
                }
            }

            ModelState.AddModelError("", "Username/password is incorrect.");
            return View(loginViewModel);
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel loginViewModel)
        {
            var checkMail = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (checkMail != null)
            {
                ModelState.AddModelError("", "A user with this e-mail address is already registered");
                return View();
            };

            var checkUserName = await _userManager.FindByNameAsync(loginViewModel.UserName);
            if (checkUserName != null)
            {
                ModelState.AddModelError("", "This username is already taken.");
                return View();
            }

            var matchInput = (checkMail == checkUserName) & (checkMail != null) & (checkUserName != null);

            if (matchInput)
            {
                ModelState.AddModelError("", "Username and password cannot have the same value.");
                return View();
            }

            if (ModelState.IsValid)
            {
                var user = new AppUser()
                { UserName = loginViewModel.UserName,
                  Email = loginViewModel.Email,
                  FullName = loginViewModel.FullName,
                  MainingList = loginViewModel.NewsLetter
                };
                var result = await _userManager.CreateAsync(user, loginViewModel.Password);

                if (result.Succeeded)
                {
                    ViewBag.Title = "Success";
                    ViewBag.Message = "Thank you for registering. Please take a moment to confirm your e-mail.";
                    return View("Message");
                }
                else
                {
                    ViewBag.Title = "Ooops...";
                    ViewBag.Message = "Something went wrong. The registration was not successfull.";
                    return View("Message");
                }
            }
            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}