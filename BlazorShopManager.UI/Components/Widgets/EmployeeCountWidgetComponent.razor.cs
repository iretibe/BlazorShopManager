using BlazorShopManager.UI.Models;

namespace BlazorShopManager.UI.Components.Widgets
{
    public partial class EmployeeCountWidgetComponent
    {
        public int EmployeeCounter { get; set; }

        protected override void OnInitialized()
        {
            EmployeeCounter = MockDataService.Employees.Count;
        }
    }
}
