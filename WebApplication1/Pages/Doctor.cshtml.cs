using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace WebApplication1.Pages
{
    // protect the doctor model
    [Authorize(Roles = "doctor")]
    public class DoctorModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
