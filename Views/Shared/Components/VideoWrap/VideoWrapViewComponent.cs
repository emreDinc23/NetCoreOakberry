using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.EntityFramework;

namespace NetCoreOakberry.Views.Shared.Components.VideoWrap
{
    public class VideoWrapViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public VideoWrapViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var videos = await _context.VideoWraps.FirstOrDefaultAsync();

            return View(videos);
        }
    }
}