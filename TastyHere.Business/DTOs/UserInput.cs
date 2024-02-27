using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyHere.Business.DTOs
{
    public class UserInput
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NickName { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
        public string Password { get; set; }
    }
}
