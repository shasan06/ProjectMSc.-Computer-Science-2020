
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
using Microsoft.AspNetCore.Razor.TagHelpers;

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
            // return (qa.QuestionNumber == 10) ? RedirectToAction("EndTest", "Test") : RedirectToAction("QuestionAnswer", "Test", parameters);
        }

        public void Reassessment()
        {
            var tempClass = GetUserTempClass();
            var r = new Registration();
            var t = new Test();
            {
                int score = 0;


                foreach (var qa in tempClass.QAlst)
                {
                    score += qa.UserMark;
                }




                //1)Algorithm for the initial assessment
                //if the current level of the user is zero and less than  and the score is 100, simply assigned Level-1 to the user so that it can take the next initial assessment

                if (tempClass.TestLevel <= 0 && score == 100.00 || tempClass.TestLevel == -1 && score == 100 || tempClass.TestLevel == -2 && score == 100)
                {
                    r.Level = r.Level - 1;
                }

                else if (tempClass.TestLevel == 0 && score != 100 || tempClass.TestLevel == -1 && score != 100 || tempClass.TestLevel == -2 && score != 100)//if the user is at level 0 and the score is not equal to 100, then check which level to be assigned to the user
                {

                    //1)sort the QAlist according by the level
                    var sortlist = tempClass.QAlst.OrderBy(x => x.levelid).ToList();

                    int Marks = 0;
                    for (int i = 0; i < 10; i++)// loop through the marks of the 10 questions and store into Marks
                    {
                        Marks += sortlist[i].UserMark;
                        //Now check by pair if the sum is 20 or not, if yes then check the next pair
                        //if the marks are not 20 then assign the level
                        if (i % 2 == 1 && Marks != ((i + 1) / 2) * 20)
                        {
                            r.Level = (i + 1) / 2 + Math.Abs(r.Level) * 5;//this will give the current level of the user for the initial assessment that is 0, -1, -2
                        }

                    }
                }
                //Algorithm for all the cases that is from level 1 to 16 after the level is set as the now the algorithm will change
                //here users marks will decide the user level
                //score above 70 go up
                else if (score > 70)
                {
                    r.Level = r.Level + 1;
                }
                //score below 70 go down
                else if (score < 70)
                {
                    r.Level = r.Level - 1;
                }
                //score 70 remain at the same level

                else // if the score 70 remain same level
                {
                    r.Level = r.Level;
                }

                //Now add all the datails in the database


            }
            if (tempClass.TestLevel == 0)
            {

                t.Testid = tempClass.Testid;
                t.Registrationid = tempClass.Registrationid;
                t.TestLevel = tempClass.TestLevel;
                t.TimeStamp = tempClass.TimeStamp;
                t.Score = tempClass.Score;
                _context.Tests.Add(t);
                _context.Registrations.Add(r);
                _context.SaveChangesAsync();
            }
            



            else
            {
                _context.Update(r);
                _context.Update(t);
                _context.SaveChangesAsync();
            }

        }

    



            
        public IActionResult EndTest()
        {
            ViewData["Message"] = "Thankyou taking the test";
            return View();
        }
    }
}


