using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
        //Criando interface para o método post
        bool CreateReviewer(Reviewer reviewer);
        //Criando interface para o método update
        bool UpdateReviewer(Reviewer reviewer);
        //Criando interface para o método delete
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();
    }
}
