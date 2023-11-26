using BlazorShopManager.Shared.Domain;

namespace BlazorShopManager.Api.Repositories
{
	public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}