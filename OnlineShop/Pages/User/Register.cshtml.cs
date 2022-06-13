using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using OnlineShop.Models;

namespace OnlineShop.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User RegisteredUser { get; set; }

        public void OnGet()
        { }

        public RedirectToPageResult OnPost()
        {
            return RedirectToPage("Profile", RegisteredUser);
        }
    }
}
