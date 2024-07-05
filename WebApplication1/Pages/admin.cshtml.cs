using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    [Authorize(Roles = "admin")]  //  protect the admin model class
    public class adminModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
