using Microsoft.AspNetCore.Mvc;
using NetCoreOakberry.Business.Services;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IAboutUsService _aboutUs;

        public AboutUsController(AppDbContext context, IAboutUsService aboutUs)
        {
            _context = context;
            _aboutUs = aboutUs;
        }

        public IActionResult Index()
        {
            var aboutUsImage = _context.AboutUsses.Select(e => e.ImageUrlLeft).FirstOrDefault();
            ViewBag.AboutUsImage = aboutUsImage;
            return View();
        }
    }
}