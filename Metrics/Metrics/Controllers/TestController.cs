
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

        public IActionResult Index()
        {



            //This questions variable stores all the list of questions 
            var questions = _context.Questions.ToList();

            //Logic for generating the images
            string[] ImageArray = {"image_1.jpg", "image_1of1.png", "image_1of10.png", "image_1of11.png", "image_1of2.png", "image_1of3.png", "image_1of4.png", "image_1of5.png",
            "image_1of6.png", "image_1of7.png", "image_1of8.png", "image_1of9.png"};

            Tempclass tests = new Tempclass();
            //Logic for retrieving the data for the initial assessment
            //var test = new Test()
            //var tests = new Test();
            var rand = new Random();
            int l = rand.Next(0, 11);
            // QuestionAnswer QA = new QuestionAnswer();

            //ImageName = "image_1.jpg"
            //QA.ImageName = ImageArray;
            //store all the 10 questions in the variable TestsQ which is of type list
            tests.TestsQ = questions.Where(x => x.levelid == 1).Take(2).Concat(questions.Where(x => x.levelid == 2).Take(2)
               .Concat(questions.Where(x => x.levelid == 3).Take(2).Concat(questions.Where(x => x.levelid == 4).Take(2)
               .Concat(questions.Where(x => x.levelid == 5).Take(2)))))
               .ToList();//this is working

            if (tests.QAlst == null)
            {
                tests.QAlst = new List<QuestionAnswer>();

            }

            int k = 1;
            foreach (var q in tests.TestsQ)
            {
                QuestionAnswer qa = new QuestionAnswer(q);
                qa.questionid = k++;
                qa.ImageName = ImageArray[(l + k) % 12];


                tests.QAlst.Add(qa);


            }



            //This part is a problem bcoz the return will always start from the first question
             for (int i = 0; i < 10; i++)

                 {
                //public IActionResult Index()

                return View(tests.QAlst[i]);
                //tests.QAlst[i];
                //return RedirectToAction("tests.QAlst[i]");
                //return RedirectToAction("QuestionAnswer");



                //tests.RNDM = (l + i) % 12;

            }

            /*TempData["question"] = tests.TestsQ;
            TempData["score"] = 0;
            TempData.Keep();

            return RedirectToAction("PresentQuestion");*/


            //}
             return View(tests.QAlst[5]);
            //return RedirectToAction("PresentQuestion");
        }

        /*public IActionResult PresentQuestion()
        {
            Tempclass tests = new Tempclass();
            Queue<List<QuestionAnswer>> q = new Queue<List<QuestionAnswer>>();

            for(int i=0; i<10; i++)
            {
                (Queue<List<QuestionAnswer>>) tests.QAlst[i];
                
            }
           // List<Question> q = null;
            //I am using the queue structure
            if (TempData["question"]!=null)
            {
                Queue<List<Question>> qlist = (Queue<List<Question>>)TempData["question"];
                if(qlist.Count>0)
                {
                    q = qlist.Peek();
                    test.Q = q;//here is the problem
                    qlist.Dequeue();
                    TempData["question"] = qlist;
                    TempData["score"] = 0;
                    TempData.Keep();
                }
                //if all the question end
                else
                {
                    return RedirectToAction("EndExam");
                }
            }
            return View(test.Q);*/

/////////////////////////////////////////////////////
            public IActionResult QuestionAnswer()
        {
            return View();
        }
        }

        


    }  

           


            
















                







