using PokemonRewiewApp.Models;

namespace PokemonRewiewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int coutryId);
        bool CountryExist(int id);
        bool CreateCountry(Country country);
        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
        bool Save();
    }
}
