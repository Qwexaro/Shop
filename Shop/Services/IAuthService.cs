using Shop.Data.Models;

namespace Shop.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(string email, string password, string name, string? phone = null);
        Task<User?> LoginAsync(string email, string password);
        string HashPassword(string password);
        bool VerifyPassword(string password, string hashedPassword);
    }
}