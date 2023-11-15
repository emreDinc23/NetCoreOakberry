using Microsoft.AspNetCore.Mvc;

namespace NetCoreOakberry.Views.Shared.Components.CategoriesPlaces
{
    public class CategoriesPlacesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        { return View(); }
    }
}