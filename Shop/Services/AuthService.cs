using Shop.Data.Models;
using Shop.Data.Repositories;
using System.Security.Cryptography;

namespace Shop.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<bool> RegisterAsync(string email, string password, string name, string? phone = null)
        {
            if (await _userRepository.ExistsByEmailAsync(email)) return false;

            var user = new User
            {
                Email = email,

                Password = HashPassword(password),

                Name = name,

                Phone = phone,

                Role = UserRole.User
            };

            await _userRepository.AddAsync(user);

            return true;
        }

        public async Task<User?> LoginAsync(string email, string password)
        {
            var user = await _userRepository.GetByEmailAsync(email);

            if (user == null || !VerifyPassword(password, user.Password)) return null;

            return user;
        }

        public string HashPassword(string password) => password;

        public bool VerifyPassword(string password, string hashedPassword) => password == hashedPassword;
    }
}