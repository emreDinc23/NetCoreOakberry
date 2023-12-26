using Microsoft.AspNetCore.Mvc;
using NetCoreOakberry.Business.Services;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly AboutUsService _aboutUsService;

        public AboutUsController(AppDbContext context, AboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
            _context = context;
        }

        public IActionResult Index()
        {
            var aboutUsImage = _context.AboutUsses.Select(e => e.ImageUrlLeft).FirstOrDefault();
            ViewBag.AboutUsImage = aboutUsImage;
            return View();
        }
    }
}