using BlazorShopManager.Api.Data;
using BlazorShopManager.Shared.Domain;

namespace BlazorShopManager.Api.Repositories
{
	public class JobCategoryRepository: IJobCategoryRepository
    {
        private readonly ShopManagerContext _appDbContext;

        public JobCategoryRepository(ShopManagerContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<JobCategory> GetAllJobCategories()
        {
            return _appDbContext.JobCategories;
        }

        public JobCategory GetJobCategoryById(int jobCategoryId)
        {
            return _appDbContext.JobCategories.FirstOrDefault(c => c.JobCategoryId == jobCategoryId);
        }
    }
}