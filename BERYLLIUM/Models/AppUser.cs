using Microsoft.AspNetCore.Identity;

namespace BERYLLIUM.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public bool isActivated { get; set; }
    }
}
