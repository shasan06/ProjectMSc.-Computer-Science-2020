using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class Question
    {
        public int questionid { get; set; }

        public int levelid { get; set; }

        public string Opcode { get; set; }

        public int firstoperand { get; set; }

        public int secondoperand { get; set; }

        //public virtual ICollection<Image> Image { get; set; }
        //because one complexity can have multiple images
        //This will hold the name of the image
    }
}
