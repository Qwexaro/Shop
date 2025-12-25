using Shop.Data.Models;

namespace Shop.Data.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);

        Task<User?> GetByEmailAsync(string email);
        
        Task<IEnumerable<User>> GetAllAsync();
        
        Task AddAsync(User user);
        
        Task UpdateAsync(User user);
        
        Task DeleteAsync(int id);
        
        Task<bool> ExistsByEmailAsync(string email);
    }
}