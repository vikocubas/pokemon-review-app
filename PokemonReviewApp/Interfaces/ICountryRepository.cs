using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int id);
        //Criando interface para o método post
        bool CreateCountry(Country country);
        //Criando interface para o método update
        bool UpdateCountry(Country country);
        //Criando interface para o método delete
        bool DeleteCountry(Country country);
        bool Save();

    }
}
