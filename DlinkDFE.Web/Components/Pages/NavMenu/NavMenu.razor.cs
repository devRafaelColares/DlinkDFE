using Microsoft.AspNetCore.Components;

namespace DlinkDFE.Web.Components.Pages.NavMenu
{
    public class NavMenuBase : ComponentBase
    {
        [Parameter]
        public EventCallback OnMenuItemClick { get; set; }

        protected async Task CloseDrawer()
        {
            if (OnMenuItemClick.HasDelegate)
                await OnMenuItemClick.InvokeAsync(null);
        
        }
    }
}