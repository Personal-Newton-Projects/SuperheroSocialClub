using SuperheroSocialClub.Models;


namespace SuperheroSocialClub.Data
{
    public static class UserManager
    {
        public static List<User> Users = GetUsers();


        static List<User> GetUsers()
        {
            List<User> users = new List<User>
            {
                new User()
                {
                    Id = 1,
                    Name = "bengt",
                    Password = "test"
                },
                new User()
                {
                    Id = 2,
                    Name = "nestle",
                    Password = "rabbit"
                },
                new User()
                {
                    Id = 3,
                    Name = "mantisman",
                    Password = "hunter2"
                },
                new User()
                {
                    Id = 4,
                    Name = "ronald",
                    Password = "mcdonald",
                },
                new User()
                {
                    Id = 5,
                    Name = "admin",
                    Password = "admin"
                },
                new User()
                {
                    Id = 6,
                    Name = "frogger",
                    Password = "idk"
                }
            };

            return users;
        }

        public static User GetUserFromCookie(string cookie)
        {
            int value = int.Parse(cookie);
            return Users.Find(u => u.Id == (value));
        }

    }
}
