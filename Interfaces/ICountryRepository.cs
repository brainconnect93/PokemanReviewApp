using PokemanReviewApp.Models;

namespace PokemanReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        // Get & Read Methods in API.
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromCountry(int countryId);
        bool CountryExists(int id);

        // Post & Create Methods in API.
        bool CreateCountry(Country country);

        // Put & Update Methods in API.
        bool UpdateCountry(Country country);

        // Delete Methods in API.
        bool DeleteCountry(Country country);
        bool Save();
    }
}
