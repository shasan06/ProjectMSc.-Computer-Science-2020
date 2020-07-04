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
        public string Range { get; set; }
        public string Operation { get; set; }
        public string Speed { get; set; }
       

    }
}
