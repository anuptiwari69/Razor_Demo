using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorDemo.Pages
{
    [Authorize]
    public class PrivacyModel : PageModel
    {
        

        public void OnGet()
        {
        }
    }
}