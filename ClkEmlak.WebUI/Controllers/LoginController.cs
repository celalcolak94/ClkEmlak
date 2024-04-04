using ClkEmlak.DtoLayer.LoginDtos;
using ClkEmlak.EntityLayer.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
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
        public async Task<IActionResult> Index(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    return View();
                }
            }
            return View(loginDto);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
