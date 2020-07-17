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

namespace Metrics.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

       public IActionResult Index(int registrationId)
        {   // This responses variable stores the responses of the registered user only
            var responses = _context.TestPermanentTables
                                    .Where(x => x.Registrationid == registrationId)
                                    .ToList();

            //This questions variable stores all the list of questions 
            var questions = _context.Questions.ToList();

            //tests is a new object of type List<Test>
            var tests = new List<Test>();

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

            //Logic for retrieving the data for the initial assessment
            var test = new Test()
            {
                ImageName = "image_1.jpg",
                //from questions database get the two questions from level 1
                TestsQ = questions.Where(x => x.levelid == 1).Take(2).Concat(questions.Where(x => x.levelid == 2).Take(2)).ToList()


                    //questions.Where(x => x.levelid == 1).Take(2).Concat(questions.Where(x => x.levelid == 2).Take(2)
                    //.Concat(questions.Where(x => x.levelid == 3).Take(2).Concat(questions.Where(x => x.levelid == 4).Take(2).Concat(questions.Where(x => x.levelid == 5).Take(2)).








            };
            tests.Add(test);
            return View(tests);

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
}

