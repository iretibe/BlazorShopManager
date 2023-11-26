namespace BlazorShopManager.UI.Components.Widgets
{
    public partial class InboxWidgetComponent
    {
        public int MessageCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(10);
        }
    }
}
