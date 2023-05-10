using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
        //Criando interface para o método post
        bool CreateReview(Review review);
        //Criando interface para o método update
        bool UpdateReview(Review review);
        //Criando interface para o método delete
        bool DeleteReview(Review review);
        bool Save();
    }
}
