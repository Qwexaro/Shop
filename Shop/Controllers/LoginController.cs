using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Services;

namespace Shop.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Check(Login login)
        {
            if (!ModelState.IsValid)
                return View("Index");

            var user = await _authService.LoginAsync(login.Username, login.Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Неверный email или пароль");
                return View("Index");
            }

            // Сохраняем пользователя в сессии
            HttpContext.Session.SetInt32("UserId", user.Id);
            HttpContext.Session.SetString("UserName", user.Name);
            HttpContext.Session.SetString("UserRole", user.Role.ToString());

            return Redirect("/");
        }
    }
}