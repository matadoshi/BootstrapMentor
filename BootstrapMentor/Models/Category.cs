using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapMentor.Models
{
    public class Category:BaseEntity
    {
        List<Course> Courses { get; set; }
    }
}
