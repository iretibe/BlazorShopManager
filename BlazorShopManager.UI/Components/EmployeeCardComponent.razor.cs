using BlazorShopManager.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorShopManager.UI.Components
{
    public partial class EmployeeCardComponent
    {
        [Parameter]
        public Employee EmployeeCard { get; set; } = default;


        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }


        [Inject]
        public NavigationManager NavigationManager { get; set; } = default;

		protected override void OnInitialized()
		{
            if (string.IsNullOrEmpty(EmployeeCard.LastName))
            {
                throw new Exception("Last name can't be empty");
            }
		}

		public void NavigateToDetails(Employee selectedEmployee)
        {
            NavigationManager.NavigateTo($"/employeedetailcomponent/{selectedEmployee.EmployeeId}");
        }
    }
}
