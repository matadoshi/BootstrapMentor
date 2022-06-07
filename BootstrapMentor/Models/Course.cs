using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapMentor.Models
{
    public class Course:BaseEntity
    {
        public int Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Category Category { get; set; }
        public Nullable<int> TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
