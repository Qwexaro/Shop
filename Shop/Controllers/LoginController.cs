using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Check(Login login)
        {
            if (ModelState.IsValid) return Redirect("/");

            return View("Index");
        }
    }
}