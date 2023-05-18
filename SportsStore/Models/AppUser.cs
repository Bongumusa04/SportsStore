using Microsoft.AspNetCore.Identity;

namespace SportsStore.Models
{
    public class AppUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; } = new byte[0];
    }
}
