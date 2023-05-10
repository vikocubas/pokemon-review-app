using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);
        //Criando interface para o método post
        bool CreateOwner(Owner owner);
        //Criando interface para o método update
        bool UpdateOwner(Owner owner);
        //Criando interface para o método delete
        bool DeleteOwner(Owner owner);
        bool Save();
    }
}
