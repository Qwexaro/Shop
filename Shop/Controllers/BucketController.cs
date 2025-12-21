using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class BucketController : Controller
    {
        public IActionResult Index() => View();
    }
}