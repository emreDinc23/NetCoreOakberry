using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.AboutUs
{
    public class AboutUsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}