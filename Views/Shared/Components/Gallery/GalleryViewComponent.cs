using Microsoft.AspNetCore.Mvc;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Views.Shared.Components.Gallery
{
    public class GalleryViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public GalleryViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var galleries = _context.PropertyImages.Take(6).ToList();

            return View(galleries);
        }
    }
}