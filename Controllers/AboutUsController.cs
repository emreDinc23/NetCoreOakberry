using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.EntityFramework;
using NetCoreOakberry.Models;

namespace NetCoreOakberry.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext _context;

        public AboutUsController(AppDbContext context)
        {
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