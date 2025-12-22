using Shop.Models;

namespace Shop.Services
{
    public interface IShoeService
    {
        List<Product> GetFeaturedProducts();

        List<Product> GetNewArrivals();
        
        List<Product> GetOnSaleProducts();
    }

    public class ShoeService : IShoeService
    {
        public List<Product> GetFeaturedProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Кроссовки Nike Air Max",
                    Description = "Удобные кроссовки для повседневной носки",
                    Price = 7999m,
                    Category = "Кроссовки",
                    ImageUrl = "/images/shoes/nike-airmax.jpg",
                    IsNew = true,
                    Rating = 4.5,
                    AvailableSizes = new List<string> { "40", "41", "42", "43", "44" },
                    Brand = "Nike"
                },
                new Product
                {
                    Id = 2,
                    Name = "Туфли кожаные мужские",
                    Description = "Классические кожаные туфли для офиса",
                    Price = 5999m,
                    OldPrice = 6999m,
                    IsSale = true,
                    Category = "Туфли",
                    ImageUrl = "/images/shoes/leather-shoes.jpg",
                    Rating = 4.8,
                    AvailableSizes = new List<string> { "41", "42", "43", "44", "45" },
                    Brand = "Ecco"
                },
                new Product
                {
                    Id = 3,
                    Name = "Кеды Converse All Star",
                    Description = "Классические кеды на каждый день",
                    Price = 4999m,
                    Category = "Кеды",
                    ImageUrl = "/images/shoes/converse.jpg",
                    IsNew = true,
                    Rating = 4.7,
                    AvailableSizes = new List<string> { "39", "40", "41", "42", "43" },
                    Brand = "Converse"
                },
                new Product
                {
                    Id = 4,
                    Name = "Ботинки зимние Timberland",
                    Description = "Теплые зимние ботинки для холодной погоды",
                    Price = 12999m,
                    Category = "Ботинки",
                    ImageUrl = "/images/shoes/timberland.jpg",
                    Rating = 4.9,
                    AvailableSizes = new List<string> { "42", "43", "44", "45" },
                    Brand = "Timberland"
                }
            };
        }

        public List<Product> GetNewArrivals()
        {
            return GetFeaturedProducts().Where(p => p.IsNew).ToList();
        }

        public List<Product> GetOnSaleProducts()
        {
            return GetFeaturedProducts().Where(p => p.IsSale).ToList();
        }
    }
}