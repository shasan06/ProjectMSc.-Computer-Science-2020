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
        public int Operation { get; set; }
        public int Speed { get; set; }
       

    }
}
