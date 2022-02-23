using SuperheroSocialClub.Models;
using System.Collections.Generic;

namespace SuperheroSocialClub.Data
{
    public static class SuperheroManager
    {

        public static List<Superhero> Superheroes { get; set; } = GenerateBaseEntries();
        static List<Superhero> GenerateBaseEntries()
        {
            return new List<Superhero>
            {
                new Superhero()
                {
                    Id = 1,
                    Name = "Bengtson",
                    RealName = "Bengt Larson",
                    Region = new Region()
                    {
                        City = "Gotham",
                        Country = "USA"
                    },
                    Superpowers = new List<string>
                    {
                        "Super Eating",
                        "Super Walking"
                    }
                },
                new Superhero()
                {
                    Id = 2,
                    Name = "Nestle Rabbit",
                    Region = new Region()
                    {
                        City = "Everywhere to be seen",
                    },
                    Superpowers = new List<string>
                    {
                        "Creating Cereal"
                    }
                },
                new Superhero()
                {
                    Id = 3,
                    Name = "Mantis Man",
                    Region = new Region()
                    {
                        Country = "USA"
                    },
                    Superpowers = new List<string>
                    {
                        "Looks like a Praying Mantis",
                        "Acts like a Praying Mantis",
                        "Speaks English"
                    }
                },
                new Superhero()
                {
                    Id = 4,
                    RealName = "Ronald McDonald",
                    Region = new Region()
                    {
                        City = "Every corner of every street block",
                        Country = "USA"
                    },
                    Superpowers = new List<string>
                    {
                        "Scare children",
                        "Walking statue / hardened skin"
                    }
                },
                new Superhero()
                {
                    Id = 5,
                    Name = "Control Freak",
                    RealName = "Nobody knows",
                    Region = new Region()
                    {
                        City = "Nobody knows",
                    },
                    Superpowers = new List<string>
                    {
                        "???"
                    }
                },
                new Superhero()
                {
                    Id = 6,
                    Name = "Frog Man",
                    RealName = "Albert Harrot",
                    Region = new Region()
                    {
                        City = "New York",
                        Country = "USA"
                    },
                    Superpowers = new List<string>
                    {
                        "Sticks to walls",
                        "Sticky",
                        "Frog Hands",
                        "Long Jump"
                    }

                },
            };

        }
        public static Superhero GetSuperheroFromUser(User User)
        {
            int index = UserManager.Users.IndexOf(User);
            return Superheroes.Find(s => s.Id == (index+1));
        }
    }

}
