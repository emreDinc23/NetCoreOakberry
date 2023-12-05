using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.EntityFramework;

namespace NetCoreOakberry.Views.Shared.Components.Blog
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var blogs = _context.Blogs
                .Take(4)
                .Include(e => e.Comments)
                .ToList();
            return View(blogs);
        }
    }
}