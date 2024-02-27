using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyHere.Business.DTOs;
using TastyHere.Business.IServices;
using TastyHere.DataAccess.Models;
using TastyHere.DataAccess.Repositories;

namespace TastyHere.Business.Services
{
    public class UserService : IUserServices
    {
        private readonly UserRepository repository;

        public UserService(UserRepository repository)
        {
            this.repository = repository;
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }


        public async Task<User> CreateUserAsync(UserInput user)
        {
            if (string.IsNullOrWhiteSpace(user.Password))
                throw new Exception("Password is required");
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);

            return await repository.CreateUserAsync(
                new User()
                {
                    Id = user.Id,
                    NickName = user.NickName,
                    Email = user.Email,
                    AvatarUrl = user.AvatarUrl,
                    PasswordHash = passwordHash.ToString(),
                    PasswordSalt = passwordSalt.ToString()
                });
        }
    }
}
