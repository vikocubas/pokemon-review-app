namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }
        // Relação 1 Owner tem 1 Country
        public Country Country { get; set; }
    }
}
