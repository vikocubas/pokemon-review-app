namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Relação 1 Country pode ter N Owners
        public ICollection<Owner> Owners { get; set; }
    }
}
