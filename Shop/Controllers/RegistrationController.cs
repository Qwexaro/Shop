using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Check(Registration registration)
        {
            if (ModelState.IsValid) return Redirect("/");

            return View("Index");
        }
    }
}
