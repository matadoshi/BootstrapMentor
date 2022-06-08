using BootstrapMentor.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapMentor.Controllers
{
    public class CoursesController : Controller
    {
        public readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.page = "Courses";
            return View(_context.Courses.Include(c => c.Category).Include(c => c.Trainer).ToList());
        }
    }
}
