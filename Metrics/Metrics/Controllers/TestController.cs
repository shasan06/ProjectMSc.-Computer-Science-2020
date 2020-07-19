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
       
        public  IActionResult Index([Bind("Testid","Registrationid","TestLevel","TimeStamp","Score","TestsQ","TestsPQ","TestsA","ImageName")]Test tests)
        {
           


            //This questions variable stores all the list of questions 
            var questions = _context.Questions.ToList();

            //Logic for generating the images
            string[] ImageArray = {"image_1.jpg", "image_1of1.png", "image_1of10.png", "image_1of11.png", "image_1of2.png", "image_1of3.png", "image_1of4.png", "image_1of5.png",
            "image_1of6.png", "image_1of7.png", "image_1of8.png", "image_1of9.png"};


            //Logic for retrieving the data for the initial assessment
            //var test = new Test()
            //var tests = new Test();
            // var rand = new Random();

            //ImageName = "image_1.jpg"
            tests.ImageName = ImageArray;
            //store all the 10 questions in the variable TestsQ which is of type list
            tests.TestsQ = questions.Where(x => x.levelid == 1).Take(2).Concat(questions.Where(x => x.levelid == 2).Take(2)
               .Concat(questions.Where(x => x.levelid == 3).Take(2).Concat(questions.Where(x => x.levelid == 4).Take(2)
               .Concat(questions.Where(x => x.levelid == 5).Take(2)))))
               .ToList();//this is working

            var rand = new Random();
            int l = rand.Next(0, 11);

            for (int i = 0; i < 10; i++)

            {
                tests.RNDM = (l + i)%12;
                tests.TestsPQ = tests.TestsQ[i];
                ViewData["Message"] = "";

                if (tests.TestsPQ.CorrectAnswer.Equals(tests.TestsA))
                {
                    tests.Score += 10;
                    tests.ScoreQ[i] = 10;
                    ViewData["Message"] = "Correct";
                    //return View(tests);
                    //adding the score in the test



                }

                //if the user answer in incorrect
                else
                {
                    tests.Score += 0;
                    tests.ScoreQ[i] = 0;
                    ViewData["Message"] = "Incorrect";
                    //return View(tests);



                }
                return View(tests);
            }
            //get any first question from the TestsQ into another variable named TestsPQ   

            //tests.Add(test);
            return View(tests);

}


        //Http POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update ([Bind("Testid","Registrationid","TestLevel","TimeStamp","Score")] Test test)
        {
            var t = new TestPermanentTable
            {
                TestPermanentTableid = test.Testid,
                Registrationid = test.Registrationid,
                TestLevel = test.TestLevel,
                TimeStamp = test.TimeStamp,
                Score = test.Score
                

            };

            _context.TestPermanentTables.Add(t);
            await _context.SaveChangesAsync();
            ModelState.Clear();
            
            return View(test);
        }
    }

}







