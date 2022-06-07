using System.Collections.Generic;

namespace BootstrapMentor.Models
{
    public class PlanFeature
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public Plan Plans { get; set; }
        public int FeatureItemsId { get; set; }
        public FeatureItem FeatureItems { get; set; }
    }
}
