using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class Complexity
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public int Range { get; set; }
        public int Count { get; set; }
        public int Compare { get; set; }
        public int Add { get; set; }
        public int Subtract { get; set; }

        //This will hold the name of the image
        public string Image { get; set; }
    }
}
