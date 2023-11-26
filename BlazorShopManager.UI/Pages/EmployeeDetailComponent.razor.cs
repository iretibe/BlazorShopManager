using BlazorShopManager.Shared.Domain;
using BlazorShopManager.UI.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorShopManager.UI.Pages
{
    public partial class EmployeeDetailComponent
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee EmployeeDetail { get; set; } = new Employee();

        protected override Task OnInitializedAsync()
        {
            EmployeeDetail = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));

            return base.OnInitializedAsync();
        }
    }
}
