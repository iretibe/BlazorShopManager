using BlazorShopManager.Api.Data;
using BlazorShopManager.Shared.Domain;

namespace BlazorShopManager.Api.Repositories
{
	public class CountryRepository : ICountryRepository
    {
        private readonly ShopManagerContext _appDbContext;

        public CountryRepository(ShopManagerContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return _appDbContext.Countries;
        }

        public Country GetCountryById(int countryId)
        {
            return _appDbContext.Countries.FirstOrDefault(c => c.CountryId == countryId);
        }
    }
}