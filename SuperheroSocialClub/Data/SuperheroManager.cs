using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Data
{
    public static class SuperheroManager
    {
        public static List<Superhero> SuperHeroes { get; set; } = GetHeroes();


        static List<Superhero> GetHeroes()
        {
            SuperHeroes = new List<Superhero>
            {
                new Superhero()
                {
                    Name = "Bengtson",
                    RealName = "Bengt Larson",
                    Region =
                    {
                        City = "Gotham",
                        Country = "USA"
                    },
                    Superpowers =
                    {
                        "Super Eating",
                        "Super Walking"
                    }
                },
                new Superhero()
                {
                    Name = "Nestle Rabbit",
                    Region =
                    {
                        City = "Everywhere to be seen"
                    },
                    Superpowers =
                    {
                        "Creating Cereal"
                    }
                },
                new Superhero()
                {
                    Name = "Mantis Man",
                    Region =
                    {
                        Country = "USA"
                    },
                    Superpowers =
                    {
                        "Looks like a Praying Mantis",
                        "Acts like a Praying Mantis",
                        "Speaks English"
                    }
                },
                new Superhero()
                {
                    RealName = "Ronald McDonald",
                    Region =
                    {
                        City = "Every corner of every street block",
                        Country = "USA"
                    },
                    Superpowers =
                    {
                        "Scare children",
                        "Walking statue / hardened skin"
                    }
                },
                new Superhero()
                {
                    Name = "Control Freak",
                    RealName = "Nobody knows",
                    Region =
                    {
                        City = "Nobody knows",
                        Country = null,
                    },
                    Superpowers =
                    {
                        "???"
                    }
                },
                new Superhero()
                {
                    Name = "Frog Man",
                    RealName = "Albert Harrot",
                    Region =
                    {
                        City = "New York",
                        Country = "USA"
                    },
                    Superpowers =
                    {
                        "Sticks to walls",
                        "Sticky",
                        "Frog Hands",
                        "Long Jump"
                    }

                }
            };

            return SuperHeroes;
        }

        public static int GetId(Superhero superhero)
        {
            return SuperHeroes.IndexOf(superhero);
        }

    }
}
