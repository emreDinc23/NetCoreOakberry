using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Views.Shared.ViewComponents.SliderHeroViewComponent
{
    public class SliderHeroViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public SliderHeroViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _context.Sliders
            .Where(s => s.IsActive)
            .ToListAsync();

            return View(sliders);
        }
    }
}