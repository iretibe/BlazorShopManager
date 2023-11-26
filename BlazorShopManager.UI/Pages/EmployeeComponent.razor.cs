using BlazorShopManager.Shared.Domain;
using BlazorShopManager.UI.Models;

namespace BlazorShopManager.UI.Pages
{
    public partial class EmployeeComponent
    {
        public List<Employee> Employees { get; set; } = default;
        private Employee _selectedEmployee;
        private string Title = "Employee Overview";

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee) 
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
