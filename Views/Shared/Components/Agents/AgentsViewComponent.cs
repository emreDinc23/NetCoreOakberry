using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.Agents
{
    public class AgentsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}