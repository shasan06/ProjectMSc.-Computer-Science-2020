using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    //Responses is inherited from Questions
    public class Response : Question
    {
        public int Responseid { get; set; }
        //it will have a composite key = questionid, testid, registrationid
        public int Testid { get; set; }

        public int Registrationid { get; set; }
        //This wil be a level which contains collection of 10 qusetions for the test
        public int TestLevel { get; set; }

        public DateTime TimeStamp { get; set; }

        public string UserAnswer { get; set; }

        public double MarkObtained { get; set; }
    }
}
