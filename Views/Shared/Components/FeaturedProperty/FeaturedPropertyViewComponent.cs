using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.EntityFramework;

namespace NetCoreOakberry.Views.Shared.Components.FeaturedProperty
{
    public class FeaturedPropertyViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public FeaturedPropertyViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var featuredProperties = _context.Properties
                .Include(e => e.PropertyImages)
                .Include(e => e.Agent)
                .Include(e => e.PropertyCategory)
                .OrderBy(p => p.ConstructionDate)
                .Take(4)
                .ToList();
            return View(featuredProperties);
        }
    }
}