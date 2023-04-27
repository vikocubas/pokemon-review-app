namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        // Relação 1 Pokemon pode ter N Reviews
        public ICollection<Review> Reviews { get; set;}
        // Relação de N Pokemon com N PokemonOwner
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        // Relação de N Pokemon com N PokemonCategory
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
