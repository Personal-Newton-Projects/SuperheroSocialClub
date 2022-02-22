namespace SuperheroSocialClub.Data
{
    public class Superhero
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? RealName { get; set; }
        public Region Region { get; set; }
        public List<string> Superpowers { get; set; }
    }
}
