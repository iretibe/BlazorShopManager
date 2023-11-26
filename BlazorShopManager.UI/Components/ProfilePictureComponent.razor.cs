using Microsoft.AspNetCore.Components;

namespace BlazorShopManager.UI.Components
{
    public partial class ProfilePictureComponent
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
