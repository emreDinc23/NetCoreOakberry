using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.VideoWrap
{
    public class VideoWrapViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}