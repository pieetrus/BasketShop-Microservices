using Microsoft.AspNetCore.Identity;

namespace BasketShop.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
