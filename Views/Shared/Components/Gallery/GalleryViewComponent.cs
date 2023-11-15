using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.Gallery
{
    public class GalleryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}