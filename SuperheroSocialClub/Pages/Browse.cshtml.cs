using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    public class BrowseModel : PageModel
    {
        public List<Superhero> Superheroes = SuperheroManager.Superheroes;
        public void OnGet()
        {
        }
    }
}
