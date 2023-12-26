using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Controllers
{
    public class AgentsController : Controller
    {
        private readonly AppDbContext _context;

        public AgentsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var agents = _context.Agents
                .Include(e => e.Properties)
                .Take(8)
                .ToList();
            ViewBag.BgImage = _context.BgImages.Where(e => e.Id == 1).Select(e => e.BackgroundImage).FirstOrDefault();
            return View(agents);
        }
    }
}