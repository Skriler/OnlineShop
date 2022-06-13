using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages
{
    public class LoginModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGet(User RegisteredUser)
        {
            Message = $"Username - {RegisteredUser.Username}, " +
                $"Email - {RegisteredUser.Email}, " +
                $"Password - {RegisteredUser.Password}";
        }
    }
}
