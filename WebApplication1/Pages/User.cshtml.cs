using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    [Authorize]
    public class UserModel : PageModel
    {
        private readonly UserManager<Users> userManager;
        public Users? appUser;

        public UserModel(UserManager<Users> userManager)
        {
            this.userManager = userManager;
        }
        public void OnGet()
        {
            var test = userManager.GetUserAsync(User);
            test.Wait();
            appUser = test.Result;
        }
    }
}
