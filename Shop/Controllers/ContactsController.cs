using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if(ModelState.IsValid) return Redirect("/");

            return View("Index");
        }
    }
}