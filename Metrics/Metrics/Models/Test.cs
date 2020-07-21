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

        public int RNDM { get; set; }

        public DateTime TimeStamp { get; set; }

        public double Score { get; set; }

        public List<Question> TestsQ { get; set; }

        public List<int> ScoreQ { get; set; }

        public Question TestsPQ { get; set; }

        //the view can send what question it just did and then the controller can get the next one.
        //so I am adding a question number property to Test and sending that to the view in a hidden field so the 
        //user doesn't see it.
        //When the view sends the question back to the controller, the controller knows what question was just done.
        public Question QuestionNO { get; set; }
        public string TestsA { get; set; }

        public string[] ImageName { get; set; }

        
    }
}
