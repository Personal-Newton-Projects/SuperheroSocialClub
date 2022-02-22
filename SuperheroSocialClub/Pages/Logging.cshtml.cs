using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    public class LoggingModel : PageModel
    {

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public void OnPost(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
