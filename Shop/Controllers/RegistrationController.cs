using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Services;

namespace Shop.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IAuthService _authService;

        public RegistrationController(IAuthService authService) => _authService = authService;
        
        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Check(Registration registration)
        {
            if (!ModelState.IsValid) return View("Index");

            var success = await _authService.RegisterAsync(
                registration.Email,
                registration.Password,
                registration.Username);

            if (!success)
            {
                ModelState.AddModelError("", "Пользователь с таким email уже существует");
        
                return View("Index");
            }

            return Redirect("/Login");
        }
    }
}