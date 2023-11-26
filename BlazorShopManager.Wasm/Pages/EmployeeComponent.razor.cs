using BlazorShopManager.Shared.Domain;
using BlazorShopManager.Wasm.Models;

namespace BlazorShopManager.Wasm.Pages
{
    public partial class EmployeeComponent
    {
        public List<Employee> Employees { get; set; } = default;

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }
    }
}
