namespace Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public decimal Price { get; set; }

        public decimal? OldPrice { get; set; }
        
        public string Category { get; set; }
        
        public string ImageUrl { get; set; }
        
        public bool IsNew { get; set; }
        
        public bool IsSale { get; set; }
        
        public double Rating { get; set; }
        
        public List<string> AvailableSizes { get; set; }
       
        public string Brand { get; set; }
    }
}