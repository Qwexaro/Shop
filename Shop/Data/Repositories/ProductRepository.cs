using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context) => _context = context;
        
        public async Task<Product?> GetByIdAsync(int id) => await _context.Products
                .Include(p => p.Sizes)
                .Include(p => p.Images)
                .FirstOrDefaultAsync(p => p.Id == id);
        
        public async Task<IEnumerable<Product>> GetAllAsync() => await _context.Products
                .Include(p => p.Sizes)
                .Include(p => p.Images)
                .ToListAsync();

        public async Task<IEnumerable<Product>> GetActiveProductsAsync() => await _context.Products
                .Include(p => p.Sizes)
                .Include(p => p.Images)
                .Where(p => p.Status == ProductStatus.Active)
                .ToListAsync();
        
        public async Task<IEnumerable<Product>> GetByCategoryAsync(string category)
        {
            return await _context.Products
                .Include(p => p.Sizes)
                .Include(p => p.Images)
                .Where(p => p.Category == category && p.Status == ProductStatus.Active)
                .ToListAsync();
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await GetByIdAsync(id);
            
            if (product != null)
            {
                _context.Products.Remove(product);
               
                await _context.SaveChangesAsync();
            }
        }
    }
}