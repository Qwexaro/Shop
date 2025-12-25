using Microsoft.AspNetCore.Mvc;
using Shop.Services;

namespace Shop.Controllers
{
    public class BucketController : Controller
    {
        private readonly ICartService _cartService;

        public BucketController(ICartService cartService) => _cartService = cartService;
        
        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            
            if (userId == null) return RedirectToAction("Index", "Login");

            var cart = await _cartService.GetOrCreateCartAsync(userId.Value);

            var total = await _cartService.CalculateCartTotalAsync(cart.Id);

            ViewBag.CartTotal = total;

            return View(cart);
        }
    }
}