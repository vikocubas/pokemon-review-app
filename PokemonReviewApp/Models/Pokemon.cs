namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        // Relação 1 Pokemon pode ter N Reviews
        public ICollection<Review> Reviews { get; set;}
    }
}
