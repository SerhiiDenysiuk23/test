using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyHere.DataAccess.IRepositories;
using TastyHere.DataAccess.Models;

namespace TastyHere.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            if (_context.Users.Any(x => x.NickName == user.NickName))
                throw new Exception($"Nickname \"{user.NickName}\" is already taken");

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public Task<User> DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> EditUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUserListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
