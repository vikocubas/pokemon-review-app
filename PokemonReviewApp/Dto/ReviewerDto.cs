using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto
{
    public class ReviewerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Relação 1 Reviewer pode ter tem N Reviews
        public ICollection<Review> Reviews { get; set; }
    }
}
