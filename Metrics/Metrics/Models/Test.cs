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
        //its Answers and put it into the TestPermanent table

        public int Testid { get; set; }

        public int Registrationid { get; set; }

        public int TestLevel { get; set; }

        public DateTime TimeStamp { get; set; }

        public double Score { get; set; }

        public List<Question> TestsQ { get; set; }

        public List<Question> TestsA { get; set; }

        public string ImageName { get; set; }

        
    }
}
