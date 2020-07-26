using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    //created this class because properties like the string of array could not be stored in the database 
    public class Tempclass : Test
    {
       public List<Question> TestsQ { get; set; }

       public List<QuestionAnswer> QAlst { get; set; }

        
        public int RNDM { get; set; }

        //This temporary class will be passed to the view 
        //something like return view(List[i]) or List.Next()

        

        
    }
}
