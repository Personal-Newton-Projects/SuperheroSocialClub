using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    [BindProperties(SupportsGet = true)]
    public class EditModel : PageModel
    {

        [BindProperty]
        public string? Name { get; set; }
        [BindProperty]
        public string? RealName { get; set; }
        [BindProperty]
        public string? City { get; set; }
        [BindProperty]
        public string? Country { get; set; }
        [BindProperty]
        public string? Superpowers { get; set; }

        public void SetProperties(Superhero hero)
        {
            int index = SuperheroManager.GetIndexofHero(hero);
            Name = SuperheroManager.Superheroes[index].Name;
            RealName = SuperheroManager.Superheroes[index].RealName;
            City = SuperheroManager.Superheroes[index].Region.City;
            Country = SuperheroManager.Superheroes[index].Region.Country;
            Superpowers = string.Join(";", SuperheroManager.Superheroes[index].Superpowers);
        }

        void GetHero()
        {
            if (IndexModel.User != null)
            {
                SetProperties(SuperheroManager.GetSuperheroFromUser(IndexModel.User));
            }
        }

        public void OnGet()
        {
            GetHero();
        }


        public IActionResult OnPost()
        {
            int index = SuperheroManager.GetIndexofHero(SuperheroManager.GetSuperheroFromUser(IndexModel.User));
            SuperheroManager.Superheroes[index].Name = Name;
            SuperheroManager.Superheroes[index].RealName = RealName;
            SuperheroManager.Superheroes[index].Region.City = City;
            SuperheroManager.Superheroes[index].Region.Country = Country;
            SuperheroManager.Superheroes[index].Superpowers = Superpowers.Split(';').ToList();

            return RedirectToPage("/Profile");
        }
    }
}
