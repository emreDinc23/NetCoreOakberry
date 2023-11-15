using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.Blog
{
    public class BlogViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}