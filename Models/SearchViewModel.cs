using Microsoft.AspNetCore.Mvc.Rendering;
using NetCoreOakberry.EntityFramework.Entities;

namespace NetCoreOakberry.Models
{
    public class SearchViewModel
    {
        public List<SelectListItem> CategoriesDd { get; internal set; }
        public List<Category> Categories { get; internal set; }
    }
}