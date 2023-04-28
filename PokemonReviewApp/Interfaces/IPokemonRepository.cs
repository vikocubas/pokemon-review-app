using PokemonReviewApp.Models;

//Adicionando as Interfaces
namespace PokemonReviewApp.Interfaces
{
    
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
