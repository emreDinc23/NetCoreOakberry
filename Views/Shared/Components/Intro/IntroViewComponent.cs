using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.Intro
{
    public class IntroViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}