using TastyHere.Business.DTOs;
using TastyHere.DataAccess.Models;

namespace TastyHere.Business.IServices
{
    public interface IUserServices
    {
        public Task<User> CreateUserAsync(UserInput user);
    }
}
