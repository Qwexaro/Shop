using Shop.Data.Models;

namespace Shop.Services
{
    public interface ICartService
    {
        Task<Cart?> GetOrCreateCartAsync(int userId, string? sessionId = null);

        Task AddToCartAsync(int cartId, int productId, int sizeId, int quantity);
        
        Task RemoveFromCartAsync(int cartItemId);
        
        Task UpdateCartItemQuantityAsync(int cartItemId, int quantity);
        
        Task ClearCartAsync(int cartId);
        
        Task<decimal> CalculateCartTotalAsync(int cartId);
    }
}