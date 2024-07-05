using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string lastName { get; set; } = "";
        public string address { get; set; } = "";
        public DateTime CreatedAt { get; set; }

    }
}
