using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.ViewComponents.SliderHeroViewComponent
{
    public class SliderHeroViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}