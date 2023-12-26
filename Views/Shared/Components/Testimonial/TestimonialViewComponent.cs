using Microsoft.AspNetCore.Mvc;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Views.Shared.Components.Testimonial
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public TestimonialViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonials = _context.Testimonials.Take(6).ToList();
            return View(testimonials);
        }
    }
}