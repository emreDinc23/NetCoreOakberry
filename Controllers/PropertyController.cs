using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.EntityFramework;

namespace NetCoreOakberry.Controllers
{
    public class PropertyController : Controller
    {
        private readonly AppDbContext _context;

        public PropertyController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var properties = _context.Properties
                .Include(e => e.PropertyImages)
                .Include(b => b.PropertyCategory)
                .Include(a => a.Agent)
                .Take(8)
                .ToList();
            return View(properties);
        }

        public IActionResult Search(string propertyName, int propertyType, string location, int priceLimit)
        {
            // Tüm mülkleri çek
            var properties = _context.Properties
                .Include(e => e.PropertyImages)
                .Include(b => b.PropertyCategory)
                .Include(a => a.Agent)
                .ToList();

            // propertyName değeri varsa, isme göre filtrele
            if (!string.IsNullOrEmpty(propertyName))
            {
                properties = properties.Where(p => p.Name.Contains(propertyName, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            // propertyType değeri 0 ise tüm özellikleri listele
            if (propertyType == 0)
            {
                properties = properties.ToList();
            }
            // propertyType değeri varsa, kategoriye göre filtrele
            else if (propertyType > 0)
            {
                properties = properties.Where(p => p.CategoryId == propertyType).ToList();
            }

            // location değeri varsa, şehire göre filtrele
            if (!string.IsNullOrEmpty(location))
            {
                properties = properties.Where(p => p.Address.Contains(location, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // priceLimit değeri varsa, fiyat sınırlarına göre filtrele
            if (priceLimit != 100)
            {
                properties = properties.Where(p => p.Price <= priceLimit).OrderBy(a => a.Price).ToList();
            }

            // Eğer hiç veri bulunamazsa, kullanıcıya bir hata mesajı göster
            if (properties.Count == 0)
            {
                ViewBag.ErrorMessage = "Arama kriterlerinize uygun mülk bulunamadı.";
            }

            return View("Search", properties);
        }
    }
}