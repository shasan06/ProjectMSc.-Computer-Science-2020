
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Metrics.Data;
using Metrics.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Web;
using Metrics.Extensions;
using System.Security.Cryptography.X509Certificates;

namespace Metrics.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Tempclass tests { get; set; }

        //public TestFactory tf;//
        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        private string GetTempClassSessionKey()
        {
            var user = HttpContext.Session.GetObject<Registration>("loggedInUser");
            var tempClassKey = $"{user.RegistrationId}-tempClass";
            return tempClassKey;
        }

        private Tempclass GetUserTempClass()
        {
            var tempClassKey = GetTempClassSessionKey();
            var tempClass = HttpContext.Session.GetObject<Tempclass>(tempClassKey);
            return tempClass;
        }

        private void SaveUserTempClass(Tempclass tempClass)
        {
            var tempClassKey = GetTempClassSessionKey();
            HttpContext.Session.SetObject<Tempclass>(tempClassKey, tempClass);
        }


        //Http GET

        public IActionResult QuestionAnswer_OLD(int lastQuestionAnswered = 0)
        {
            //This questions variable stores all the list of questions 
            var questions = _context.Questions.ToList();//4

            //Logic for generating the images
            string[] ImageArray = {"image_1.jpg", "image_1of1.png", "image_1of10.png", "image_1of11.png", "image_1of2.png", "image_1of3.png", "image_1of4.png", "image_1of5.png",
            "image_1of6.png", "image_1of7.png", "image_1of8.png", "image_1of9.png"};

            //QuestionAnswer qans = new QuestionAnswer();
            Tempclass tests = new Tempclass();//5
            //Logic for retrieving the data for the initial assessment
            //var test = new Test()
            //var tests = new Test();
            var rand = new Random();
            int l = rand.Next(0, 11);//3
            // QuestionAnswer QA = new QuestionAnswer();

            //ImageName = "image_1.jpg"
            //QA.ImageName = ImageArray;
            //store all the 10 questions in the variable TestsQ which is of type list
            tests.TestsQ = questions.Where(x => x.levelid == 1).Take(2).Concat(questions.Where(x => x.levelid == 2).Take(2)
               .Concat(questions.Where(x => x.levelid == 3).Take(2).Concat(questions.Where(x => x.levelid == 4).Take(2)
               .Concat(questions.Where(x => x.levelid == 5).Take(2)))))
               .ToList();//this is working//1

            if (tests.QAlst == null)
            {
                tests.QAlst = new List<QuestionAnswer>();

            }

            int k = 1;
            foreach (var q in tests.TestsQ)
            {
                QuestionAnswer qa = new QuestionAnswer(q);
                //qa.questionid = k++;
                qa.QuestionNumber = k++;
                qa.ImageName = ImageArray[(l + k) % 12];


                tests.QAlst.Add(qa);


            }//2




            //for (int i = 0; i < 10; i++)

            //{
            //  qa.QuestionNumber = i;
            //  if(qa.QuestionNumber==0)


            //return RedirectToAction("EndTest", "Test");
            var viewModel = tests.QAlst.Skip(lastQuestionAnswered).Take(1).First();
            return View(viewModel);
            //}
        }

        public IActionResult QuestionAnswer(int lastQuestionAnswered = 0)
        {
            var tempClass = GetUserTempClass();
            var tests = tempClass;
            var viewModel = tests.QAlst.Skip(lastQuestionAnswered).Take(1).First();
            return View(viewModel);
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Response(QuestionAnswer qa)
        {
            //The line below does nothing. might want to get it from the DB
            //Or keep updating the CorrectAnswer using hidden fields.
            qa.UserMark += qa.CorrectAnswer == qa.UserAnswer ? 10 : 0;

            var tempClass = GetUserTempClass();
            var questionAnswer = tempClass.QAlst.First(x => x.questionid == qa.questionid);
            questionAnswer.UserMark += qa.CorrectAnswer == qa.UserAnswer ? 10 : 0;
            SaveUserTempClass(tempClass);



            var parameters = new
            {
                lastQuestionAnswered = qa.QuestionNumber

            };
            //

            return (qa.QuestionNumber == 10) ? RedirectToAction("Reassessment", "EndTest", "Test") : RedirectToAction("QuestionAnswer", "Test", parameters);
        }

        public void Reassessment()
        {
            int score = 0;
            var tempClass = GetUserTempClass();
            foreach (var qa in tempClass.QAlst)
            {
                score += qa.UserMark;
            }

            //we for the first time that the user is at level o
            //using dictionary input in the func will be score, usercurrent level in func output assigned level to user
            //Dictionary<Func<double,int>, int> dict = new Dictionary<Func<double, int>, int>();
            //1)if the current level of the user is zero and the marks is 100.0 the assign -1 to the userlevel, notice that 0 is the boundary case
            if (tempClass.TestLevel == 0 && score == 100.00)
            {
                tempClass.TestLevel = -1;
            }
            else if (tempClass.TestLevel == 0 && score < 60.0)//this means if the user is at level 0 and has scored less than 60 or 70 there is no way to go below so can remain on the same level
            {
                tempClass.TestLevel = tempClass.TestLevel;
            }
            else if (tempClass.TestLevel == 0 && score > 80.0)//this means if the user is at level 0 and has scored above 80 then assign a level higher to the user 
            {  tempClass.TestLevel = tempClass.TestLevel + 1;//this means level 1 will be assigned to the user
            }

            //Now check if the user is at level -1 means the user has cleared the initial assessment of level 0 and is at level -1 of the second initial assessment
            else if (tempClass.TestLevel == -1 && score == 100.00)
            {
                tempClass.TestLevel = -2;
            }
            else if (tempClass.TestLevel == -1 && score < 60.0)//this means if the user is at level -1 and has scored less than 60 then this means he/she is weak in level 6 to 10 of the problems then assign level 6
            {
                tempClass.TestLevel = 6;
            }
            else if (tempClass.TestLevel == -1 && score > 80.0)//this means if the user is at level -1 and has scored above 80 then surely the user is not able to do the last two level of the questions so assigned level 9 
            {
                tempClass.TestLevel = 9;//this means level 1 will be assigned to the user
            }
            else if (tempClass.TestLevel == -2 && score == 100.00)//he/she can do all level 15 then assign the last level as 16, and check, 
            {
                tempClass.TestLevel = 16;
            }
            else if (tempClass.TestLevel == -2 && score < 60.0)//this means if the user is at level -2 and has scored less than 60 then this means he/she is weak in level 11 to 15 of the problems then assign level 11
            {
                tempClass.TestLevel = 11;
            }
            else if (tempClass.TestLevel == -2 && score > 80.0)//this means if the user is at level -2 and has scored above 80 then surely the user is not able to do the last two level of the questions so assigned level 14 
            {
                tempClass.TestLevel = 14;//this means level 1 will be assigned to the user
            }
            else if (tempClass.TestLevel == 16 && score == 100.0)
            {
                tempClass.TestLevel = 0; // what should i do to tell the user that he/she has completed all levels for the time being until i develop more//
            }

            else
            {

            }
            
        }

        public IActionResult EndTest()
        {
            ViewData["Message"] = "Thankyou taking the test";
            return View();
        }
    }
}


