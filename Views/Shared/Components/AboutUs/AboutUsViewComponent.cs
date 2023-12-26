using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.Models;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Views.Shared.Components.AboutUs
{
    public class AboutUsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public AboutUsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var aboutUsData = await _context.AboutUsses.FirstOrDefaultAsync();

            var viewModel = new AboutUsStatisticViewModel
            {
                TotalProperties = _context.Properties.Count(),
                QualifiedRealtors = _context.Agents.Count(),
                AboutUsData = aboutUsData
            };

            return View(viewModel);
        }
    }
}