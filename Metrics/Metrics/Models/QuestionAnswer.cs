using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class QuestionAnswer : Question
    {
        //This is a temporary class that extends the Question class
        //This will be passed as a list to the temporary class
        public string ImageName { get; set; }

        public int QuestionNumber { get; set; }

       // public List<QuestionAnswer> QAlst { get; set; }
        public string UserAnswer { get; set; }

        public string Answeroutcome { get; set; }
        public int UserMark { get; set; }

        //This class will be passed as the whole object to the temp class 
        //as alist and will be used for analysis

        public QuestionAnswer()
        {

        }

        public QuestionAnswer(Question q)
        {
            questionid = q.questionid;

            levelid = q.levelid;

            Opcode = q.Opcode;

            firstoperand = q.firstoperand;

            secondoperand = q.secondoperand;

            CorrectAnswer = q.CorrectAnswer;

            UserAnswer = "";

            UserMark = 0;

        //public virtual ICollection<Image> Image { get; set; }
        //because one complexity can have multiple images
        //This will hold the name of the image
    }
    }
}
