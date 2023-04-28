namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; internal set; }
        public string Gym { get; set; }
        // Relação 1 Owner tem 1 Country
        public Country Country { get; set; }
        // Relação de N Owner com N PokemonOwner
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        
    }
}
