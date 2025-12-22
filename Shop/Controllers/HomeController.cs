using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Services;

namespace ShoeStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShoeService _shoeService;

        public HomeController(IShoeService shoeService)
        {
            _shoeService = shoeService;
        }

        public IActionResult Index()
        {
            var featuredProducts = _shoeService.GetFeaturedProducts();
            var newArrivals = _shoeService.GetNewArrivals();
            var saleProducts = _shoeService.GetOnSaleProducts();

            var viewModel = new HomeViewModel
            {
                FeaturedProducts = featuredProducts,
                NewArrivals = newArrivals,
                OnSaleProducts = saleProducts
            };

            return View(viewModel);
        }
    }

    public class HomeViewModel
    {
        public List<Product> FeaturedProducts { get; set; }
        public List<Product> NewArrivals { get; set; }
        public List<Product> OnSaleProducts { get; set; }
    }
}