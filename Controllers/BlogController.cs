using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var blogs = _context.Blogs
                .Include(e => e.Comments)
                .Include(e => e.Tags)
                .ToList();
            ViewBag.BgImage = _context.BgImages.Where(e => e.Id == 2).Select(e => e.BackgroundImage).FirstOrDefault();
            return View(blogs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var blog = await _context.Blogs
                .Include(e => e.Comments)
                .ThenInclude(e => e.Replies)
                .Include(e => e.Tags)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

    }
}