using TastyHere.DataAccess.Models;

namespace TastyHere.DataAccess.IRepositories
{
    public interface IUserRepository
    {
        public Task<User> GetUserByEmailAsync(string email);
        public Task<User> GetUserByIdAsync(Guid id);
        public Task<IEnumerable<User>> GetUserListAsync();
        public Task<User> CreateUserAsync(User user);
        public Task<User> EditUserAsync(User user);
        public Task<User> DeleteUserAsync(User user);
    }
}
