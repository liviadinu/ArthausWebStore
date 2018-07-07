using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArthausWebStore.Models;
using ArthausWebStore.ViewModels;
using System.Security.Claims;
using ArthausWebStore.AuthHelpers;

namespace ArthausWebStore.Controllers
{
    [Authorize]
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
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            });
        }

        //[AllowAnonymous]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                        return RedirectToAction("Index", "Home");

                    return Redirect(loginViewModel.ReturnUrl);
                }
            }
           
            ModelState.AddModelError("", "The username/password combination was not found.");
            return View("Register",loginViewModel);
        }


        //[AllowAnonymous]
        //public IActionResult SignUp()
        //{
        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser() {
                    UserName = loginViewModel.UserName,
                    Email = loginViewModel.Email };
                var result = await _userManager.CreateAsync(user, loginViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("Register",loginViewModel);
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

        [AllowAnonymous]
        public IActionResult GoogleLogin(string returnUrl = null)
        {
            var redirectUrl = Url.Action("GoogleLoginCallback", "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(ThirPartyLoginService.GoogleProvider, redirectUrl);
            return Challenge(properties, ThirPartyLoginService.GoogleProvider);
        }

        [AllowAnonymous]
        public async Task<IActionResult> GoogleLoginCallback(string returnUrl = null, string serviceError = null)
        {
            if (serviceError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {serviceError}");
                return View(nameof(Login));
            }

            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
            if (result.Succeeded)
            {
                if (returnUrl == null)
                    return RedirectToAction("index", "home");

                return Redirect(returnUrl);
            }

            var user = new AppUser
            {
                Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                UserName = info.Principal.FindFirst(ClaimTypes.Email).Value
            };

            var identityResult = await _userManager.CreateAsync(user);

            if (!identityResult.Succeeded) return AccessDenied();

            identityResult = await _userManager.AddLoginAsync(user, info);

            if (!identityResult.Succeeded) return AccessDenied();

            await _signInManager.SignInAsync(user, false);

            if (returnUrl == null)
                return RedirectToAction("index", "home");

            return Redirect(returnUrl);
        }

    }
}