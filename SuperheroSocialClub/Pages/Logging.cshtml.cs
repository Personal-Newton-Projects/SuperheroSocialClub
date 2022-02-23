using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    public class LoggingModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public User CurrentUser { get; set; }

        public void OnGet(string message)
        {
            Message = message;
        }
        public IActionResult OnPost(string username, string password)
        {

            User attemptLogin = UserManager.Users.Where(u => u.Name.ToLower() == username.ToLower()).FirstOrDefault();
            if (attemptLogin != null)
            {
                if (attemptLogin.Password.ToLower() == password.ToLower())
                {
                    CurrentUser = attemptLogin;
                    Response.Cookies.Append("User", $"{CurrentUser.Id}");
                    return RedirectToPage("/Index");
                }
                else
                {
                    return RedirectToPage("/LogIn", new { Message = "Invalid Password" });
                }
            }
            else
            {
                return RedirectToPage("/LogIn", new { Message = "Account does not exist" });

            }
        }
    }
}
