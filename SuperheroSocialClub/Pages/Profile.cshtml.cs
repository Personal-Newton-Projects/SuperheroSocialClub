using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    public class ProfileModel : PageModel
    {
        public Superhero SuperHero { get; set; }
        public void OnGet()
        {

            SuperHero = SuperheroManager.GetSuperheroFromUser(IndexModel.User);
        }
    }
}
