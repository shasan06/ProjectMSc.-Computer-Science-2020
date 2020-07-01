using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class Image
    {
        public int id { get; set; }

        //navigation property
        public Complexity complexity { get; set; }

        public Registration registration { get; set; }

        public Response response { get; set; }
    }
}
