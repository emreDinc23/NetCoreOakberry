using Microsoft.AspNetCore.Mvc;
using NetCoreOakberry.Persistence;

using NetCoreOakberry.Persistence.Entities;

namespace NetCoreOakberry.Views.Shared.Components.CategoriesPlaces
{
    public class CategoriesPlacesViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public CategoriesPlacesViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cityStatistics = _context.Properties
                .GroupBy(p => p.City)
                .Select(group => new CityStatistic
                {
                    City = group.Key,
                    PropertyCount = group.Count()
                })
                .OrderByDescending(stat => stat.PropertyCount)
                .Take(12)
                .ToList();

            return View(cityStatistics);
        }
    }
}