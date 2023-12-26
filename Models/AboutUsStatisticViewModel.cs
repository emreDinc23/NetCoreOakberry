using NetCoreOakberry.Persistence.Entities;

namespace NetCoreOakberry.Models
{
    public class AboutUsStatisticViewModel
    {
        public int TotalProperties { get; set; }
        public int QualifiedRealtors { get; set; }
        public AboutUs AboutUsData { get; set; }
    }
}