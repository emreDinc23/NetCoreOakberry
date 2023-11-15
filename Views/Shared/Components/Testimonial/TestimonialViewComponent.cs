using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.Testimonial
{
    public class TestimonialViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}