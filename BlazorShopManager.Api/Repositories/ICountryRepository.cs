using BlazorShopManager.Shared.Domain;

namespace BlazorShopManager.Api.Repositories
{
	public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}