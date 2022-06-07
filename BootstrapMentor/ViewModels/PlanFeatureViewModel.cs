using BootstrapMentor.Models;
using System.Collections.Generic;

namespace BootstrapMentor.ViewModels
{
    public class PlanFeatureViewModel
    {
        public List<Plan> Plans { get; set; }
        public List<FeatureItem> FeatureItems { get; set; }
    }
}
