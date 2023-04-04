using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDemo.Data;
using RazorDemo;
using System.Security.Claims;
using System.Threading.Tasks;

public class IndexModel : PageModel
{ 
 private readonly DataContext _db;

public IndexModel(DataContext db)
{
    _db = db;
}

public List<User> Users { get; set; }






public ActionResult OnGet()
{
    ClaimsPrincipal ClaimUser = HttpContext.User;
    if (ClaimUser.Identity.IsAuthenticated)
        Users = _db.Users.ToList();


    return Page();



}
    

    public async Task<IActionResult> OnPostLogoutAsync()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToPage("/Login");
    }
}
