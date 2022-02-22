using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    public class BrowseModel : PageModel
    {
        public List<Superhero> SuperHeroes = SuperheroManager.SuperHeroes;
        public void OnGet()
        {
        }
    }
}
