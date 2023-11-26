using BlazorShopManager.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorShopManager.UI.Components
{
    public partial class QuickViewPopupComponent
    {
        [Parameter]
        public Employee EmployeeQuickView { get; set; }

        private Employee _employee;

        protected override void OnParametersSet()
        {
            _employee = EmployeeQuickView;
        }

        public void Close()
        {
            _employee = null;
        }
    }
}
