using Core.Entities;

namespace Entities.DTOs
{
    public class UserForLoginDto : IDTo
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
