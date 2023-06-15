using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCourse
{
    public class Exercise
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImagePath { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}
