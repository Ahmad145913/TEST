using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    //  protect the hospital manger model
    [Authorize(Roles = "manager")]
    public class HospitalManagerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
