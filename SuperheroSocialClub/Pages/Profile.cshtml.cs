using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    [BindProperties(SupportsGet = true)]
    public class ProfileModel : PageModel
    {

        public Superhero Superhero { get; set; }
        public bool? EditMode { get; set; }

        public void OnGet()
        {
            if (IndexModel.User != null)
            {
                Superhero = SuperheroManager.GetSuperheroFromUser(IndexModel.User);
            }
        }
    }
}
