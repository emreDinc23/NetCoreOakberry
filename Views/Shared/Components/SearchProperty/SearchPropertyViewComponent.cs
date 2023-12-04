using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.EntityFramework;
using NetCoreOakberry.Models;

namespace NetCoreOakberry.Views.Shared.Components.SearchProperty
{
    public class SearchPropertyViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public SearchPropertyViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _context.Categories
                .Where(b => b.IsActive);

            var categoriesDd = await categories
                .Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                })
                .OrderBy(b => b.Text)
                .ToListAsync();

            var vm = new SearchViewModel()
            {
                CategoriesDd = categoriesDd,
                Categories = categories.ToList(),
            };

            return View(vm);
        }
    }
}