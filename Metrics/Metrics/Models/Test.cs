using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class Test
    {
        //This class will be a temporary storage just to present the 10 questions to the user and collects 
        //its response and put it into the response table

        public int Testid { get; set; }  

        public int TestLevel { get; set; }

        public List<Question> TestsQ { get; set; }

        public string ImageName { get; set; }
        
    }
}
