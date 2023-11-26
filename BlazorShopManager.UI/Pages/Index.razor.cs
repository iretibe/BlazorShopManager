using BlazorShopManager.UI.Components.Widgets;

namespace BlazorShopManager.UI.Pages
{
    public partial class Index
    {
        public List<Type> Widgets { get; set; } = new List<Type>()
        {
            typeof(EmployeeCountWidgetComponent), typeof(InboxWidgetComponent)
        };
    }
}
