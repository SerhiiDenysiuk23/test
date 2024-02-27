using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyHere.DataAccess.Models
{
    public enum UserRole
    {
        user,
        moderator,
        admin
    }

    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string NickName { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public UserRole Role { get; set; }
    }
}
