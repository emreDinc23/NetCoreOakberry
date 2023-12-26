using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreOakberry.Persistence;

namespace NetCoreOakberry.Views.Shared.Components.Agents
{
    public class AgentsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public AgentsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var agents = _context.Agents
                .Take(4)
                .Include(a => a.Properties)
                .ToList();
            return View(agents);
        }
    }
}