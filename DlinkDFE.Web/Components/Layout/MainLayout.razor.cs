using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using MudBlazor;

namespace DlinkDFE.Web.Components.Layout
{
    public partial class MainLayout : LayoutComponentBase, IDisposable
    {
        private bool _isDrawerOpened = false;
        private MudThemeProvider _mudThemeProvider = null!;

        [Inject]
        private NavigationManager NavigationManager { get; set; } = null!;

        private void ToggleDrawer()
        {
            _isDrawerOpened = !_isDrawerOpened;
        }

        private void CloseDrawer()
        {
            _isDrawerOpened = false;
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
                NavigationManager.LocationChanged += OnLocationChanged;
            
        }

        private void OnLocationChanged(object? sender, LocationChangedEventArgs e)
        {
            CloseDrawer();
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            NavigationManager.LocationChanged -= OnLocationChanged;
        }
    }
}
