using System.Collections.Generic;

namespace BootstrapMentor.Models
{
    public class Plan:BaseEntity
    {
        public int Price { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsAdvanced { get; set; }
        public List<PlanFeature> PlanFeatures { get; set; }
    }
}
