using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.FeaturedProperty
{
    public class FeaturedPropertyViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}