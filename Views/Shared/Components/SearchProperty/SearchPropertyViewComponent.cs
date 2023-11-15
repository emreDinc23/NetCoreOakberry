using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.SearchProperty
{
    public class SearchPropertyViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}