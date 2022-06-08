using BootstrapMentor.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapMentor.Controllers
{
    public class TrainersController : Controller
    {
        public readonly AppDbContext _context;
        public TrainersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.page = "Trainers";

            return View(_context.Trainers.Include(c=>c.Position).ToList());
        }
    }
}
