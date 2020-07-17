using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    //This Test Table will be permanent after the test presented from temporarytest table it will be stored here
    public class TestPermanentTable
    {
        
        //it will have a composite key = questionid, testid, registrationid
        
        public int TestPermanentTableid { get; set; }

        public int Registrationid { get; set; }
        //This wil be a level which contains collection of 10 qusetions for the test
        public int TestLevel { get; set; }

        public DateTime TimeStamp { get; set; }

        public double Score { get; set; }

        
    }
}
