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

namespace Metrics.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Http GET
        public IActionResult Index(int registrationId)
        {   // This responses variable stores the responses of the registered user only
            var responses = _context.TestPermanentTables
                                    .Where(x => x.Registrationid == registrationId)
                                    .ToList();

            //This questions variable stores all the list of questions 
            var questions = _context.Questions.ToList();

            //tests is a new object of type List<Test>


            //now loop through the reponses
            //foreach (var response in responses)
            //{
            //get the questions from the database whose id matches with???? bring it to List and store it in testQuestions variable


            //Now create a new Test object and store it in test variable
            /*var test = new Test()
            {
                TestLevel = response.TestLevel,
                Testid = response.Testid,
                TestsQ = testQuestions,
                ImageName = "image_1.jpg"
            };*/
            //add test to the tests-- is tests in the database dosent exist? but only a modal is there ? 

            //Logic for generating the images
            string[] ImageArray = {"image_1.jpg", "image_1of1.png", "image_1of10.png", "image_1of11.png", "image_1of2.png", "image_1of3.png", "image_1of4.png", "image_1of5.png",
            "image_1of6.png", "image_1of7.png", "image_1of8.png", "image_1of9.png"};


            //Logic for retrieving the data for the initial assessment
            //var test = new Test()
            var tests = new Test();
            // var rand = new Random();

            //ImageName = "image_1.jpg"
            tests.ImageName = ImageArray;
            //store all the 10 questions in the variable TestsQ which is of type list
            tests.TestsQ = questions.Where(x => x.levelid == 1).Take(2).Concat(questions.Where(x => x.levelid == 2).Take(2)
               .Concat(questions.Where(x => x.levelid == 3).Take(2).Concat(questions.Where(x => x.levelid == 4).Take(2)
               .Concat(questions.Where(x => x.levelid == 5).Take(2)))))
               .ToList();//this is working

            for (int i = 0; i < 10; i++)

            {
                tests.TestsPQ = tests.TestsQ[i];
            }
            //get any first question from the TestsQ into another variable named TestsPQ   

            //tests.Add(test);
            return View(tests);





            //questions.Where(x => x.levelid == 1).Take(2).Concat(questions.Where(x => x.levelid == 2).Take(2)
            //.Concat(questions.Where(x => x.levelid == 3).Take(2).Concat(questions.Where(x => x.levelid == 4).Take(2).Concat(questions.Where(x => x.levelid == 5).Take(2)).

            //I am using a dictionary to see the most efficient way to add the questions
            //List<Dictionary<string, int> dict = new List<Dictionary<string, int>>();

            //TestsQ = questions.Where(dict => dict.levelid == 1).Take(2).ToDictiona







        }

        //Http POST

        public async Task<IActionResult> QuestionAnswer([Bind("Testid","Registrationid","TestLevel","TimeStamp","Score","TestsQ","TestsPQ", "TestsA","ImageName")] Test test)
        {
            if (ModelState.IsValid)
            {

                //var t = new Test();

                //users answer is stored in TestsA property
                //Console.WriteLine($"{test.TestsPQ.CorrectAnswer}");

                //Now check if the user answer is correct
                
                if (test.TestsPQ.CorrectAnswer.Equals(test.TestsA ))
                {
                    //adding the score in the test
                    test.Score += 10;
                    ViewData["Message"] = "~images/tick.png";
                    return View("Index");
                }
                
                //if the user answer in incorrect
                else
                {
                    test.Score += 0;
                    ViewData["Message"] = "~images/cross.png";
                    return View("Index");
                }
                


            }
            return RedirectToAction("Index");
        }
    }

}





    //Test Factory
    //THERE ARE SO MANY THINGS WRONG WITH THE CODE BELOW, commenting it out
    //public void TestFactory(int level)
    //{
    //    switch (level)
    //    {
    //            case 0:

    //                //selecting only two questions from level 1
    //                for (int i = 0; i < 2; i++) {
    //                    var questions = from q in _context.Questions.
    //                                    OrderBy(q => q.levelid.ToString("1"))
    //                                    select q;
    //                }
    //                //again selecting only two questions from level 2
    //                for (int i = 0; i < 2; i++)
    //                {
    //                    var questions = from q in _context.Questions.
    //                                    OrderBy(q => q.levelid.ToString("2"))
    //                                    select q;
    //                }

    //                //again selecting only two questions from level 3
    //                for (int i = 0; i < 2; i++)
    //                {
    //                    var questions = from q in _context.Questions.
    //                                    OrderBy(q => q.levelid.ToString("3"))
    //                                    select q;
    //                }

    //                //again selecting only two questions from level 4
    //                for (int i = 0; i < 2; i++)
    //                {
    //                    var questions = from q in _context.Questions.
    //                                    OrderBy(q => q.levelid.ToString("4"))
    //                                    select q;
    //                }

    //                //again selecting only two questions from level 4
    //                for (int i = 0; i < 2; i++)
    //                {
    //                    var questions = from q in _context.Questions.
    //                                    OrderBy(q => q.levelid.ToString("5"))
    //                                    select q;
    //                }

    //                // save the questions into the test table
    //                var testVM = new Test
    //                {
    //                    TestsQ = await questions.ToList();
    //                };
    //                break;
    //    }
    //    return View(testVM);
    //}


