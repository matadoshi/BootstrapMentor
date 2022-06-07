using BootstrapMentor.DAL;
using BootstrapMentor.Models;
using BootstrapMentor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapMentor.Controllers
{
    public class PricingController : Controller
    {
        public readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            List<Plan> plans = _context.Plans.Include(c => c.PlanFeatures).ToList();
            List<FeatureItem> featureItems = _context.FeatureItems.ToList();
            PlanFeatureViewModel planFeatureViewModel = new PlanFeatureViewModel
            {
                Plans = plans,
                FeatureItems = featureItems
            };
            return View(planFeatureViewModel);
        }
    }
}
