using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int id);
        bool CategoryExists(int id);
        //Criando interface para o método post
        bool CreateCategory(Category category);
        //Criando interface para o método update
        bool UpdateCategory(Category category);
        //Criando interface para o método delete
        bool DeleteCategory(Category category);
        bool Save();
    }
}
