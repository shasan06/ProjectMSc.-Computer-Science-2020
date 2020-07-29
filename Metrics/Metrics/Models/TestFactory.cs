using Metrics.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class TestFactory
    {
        private readonly ApplicationDbContext _context;

        public Tempclass tests { get; set; }
        
        public TestFactory() { }
        public TestFactory(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateQAlist(Registration userlevel)
        {
            tests = new Tempclass();
            //Logic for generating the images
            string[] ImageArray = {"image_1.jpg", "image_1of1.png", "image_1of10.png", "image_1of11.png", "image_1of2.png", "image_1of3.png", "image_1of4.png", "image_1of5.png",
            "image_1of6.png", "image_1of7.png", "image_1of8.png", "image_1of9.png"};


            var rand = new Random();
            int l = rand.Next(0, 11);

            //creating questionandanswers object
            if (tests.QAlst == null)
            {
                tests.QAlst = new List<QuestionAnswer>();

            }

            //now calling the factory to  buid the test and will be stored in the tests.TestQ
            TestBuilder(userlevel.Level);
            int k = 1;
            foreach (var q in tests.TestsQ)
            {
                QuestionAnswer qa = new QuestionAnswer(q);
                //qa.questionid = k++;
                qa.QuestionNumber = k++;
                qa.ImageName = ImageArray[(l + k) % 12];


                tests.QAlst.Add(qa);


            }
        }

        //The testbuider method just builds the test as per the users level
        public void TestBuilder(int level)
        {
            switch(level)
            {
                case 0:

                    tests.TestsQ = _context.Questions.Where(x => x.levelid == 1).Take(2).Concat(_context.Questions.Where(x => x.levelid == 2).Take(2)
                    .Concat(_context.Questions.Where(x => x.levelid == 3).Take(2).Concat(_context.Questions.Where(x => x.levelid == 4).Take(2)
                    .Concat(_context.Questions.Where(x => x.levelid == 5).Take(2)))))
                    .ToList();//this is working
                break;
                case -1:

                    tests.TestsQ = _context.Questions.Where(x => x.levelid == 6).Take(2).Concat(_context.Questions.Where(x => x.levelid == 7).Take(2)
                    .Concat(_context.Questions.Where(x => x.levelid == 8).Take(2).Concat(_context.Questions.Where(x => x.levelid == 9).Take(2)
                    .Concat(_context.Questions.Where(x => x.levelid == 10).Take(2)))))
                    .ToList();//this is working
                break;
                case -2:

                    tests.TestsQ = _context.Questions.Where(x => x.levelid == 11).Take(2).Concat(_context.Questions.Where(x => x.levelid == 12).Take(2)
                    .Concat(_context.Questions.Where(x => x.levelid == 13).Take(2).Concat(_context.Questions.Where(x => x.levelid == 14).Take(2)
                    .Concat(_context.Questions.Where(x => x.levelid == 15).Take(2)))))
                    .ToList();//this is working
                break;

                //now the boundary cases for level 1 and for level 16
                case 1:

                    tests.TestsQ = _context.Questions.Where(x => x.levelid == 1).Take(7)
                        .Concat(_context.Questions.Where(x => x.levelid == 2).Take(3)).ToList();//this is working
                break;
                case 16:

                    tests.TestsQ = _context.Questions.Where(x => x.levelid == 16).Take(7)
                        .Concat(_context.Questions.Where(x => x.levelid == 15).Take(3)).ToList();//this is working
                    break;

                    //this default is for all the rest of the userlevels i.e from 2 to 15
                default:
                    tests.TestsQ = _context.Questions.Where(x => x.levelid == (level - 1)).Take(3)
                        .Concat(_context.Questions.Where(x => x.levelid == (level)).Take(4)
                        .Concat(_context.Questions.Where(x => x.levelid == (level + 1)).Take(3))).ToList();

                    break;
            }
        }
    }
}
