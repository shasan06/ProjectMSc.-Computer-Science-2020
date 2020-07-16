using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metrics.Models;



namespace Metrics.Data.Seeder
{
    /// <summary>
    /// This is run at the start of the application and is used to insert values 
    /// into the database that is needed for the application to run
    /// </summary>
    public interface IDatabaseSeeder
    {
        void Seed();
    }

    public class DatabaseSeeder : IDatabaseSeeder
    {
        private readonly ApplicationDbContext _context;

        public DatabaseSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        private void SeedImage()
        {
            //lets check if the complexity has already been seed, 
            //if so, then we exit

            if (_context.Images.Any()) //if there are any data in the database then exit the method, if not then add a new data in the database 
            {
                return;
            }
            //this is how you add multiple images to a question in the Seeder
            //Image = new List<Image>
            //this is how you seed the initial questions
            var images = new Image[]
            {
                new Image()
                {
                    Title = "Duck",
                    ImageName = "~/images/image/image_1.jpg"
                },

                new Image()
                {
                    Title = "Bottle",
                    ImageName = "~/images/image/image_1of1.png"
                },

                new Image()
                {
                    Title = "Balloon",
                    ImageName = "~/images/image/image_1of2.png"
                },

                new Image()
                {
                    Title = "Ball",
                    ImageName = "~/images/image/image_1of3.png"
                },

                new Image()
                {
                    Title = "Watch",
                    ImageName = "~/images/image/image_1of4.png"
                },

                new Image()
                {
                    Title = "Cat",
                    ImageName = "~/images/image/image_1of5.png"
                },

                new Image()
                {
                    Title = "Kite",
                    ImageName = "~/images/image/image_1of6.png"
                },

                new Image()
                {
                    Title = "Apple",
                    ImageName = "~/images/image/image_1of7.png"
                },

                new Image()
                {
                    Title = "Dog",
                    ImageName = "~/images/image/image_1of8.png"
                },

                new Image()
                {
                    Title = "Smile",
                    ImageName = "~/images/image/image_1of9.png"
                },
                new Image()
                {
                    Title = "Horse",
                    ImageName = "~/images/image/image_1of10.png"
                },
                new Image()
                {
                    Title = "Banana",
                    ImageName = "~/images/image/image_1of11.png"
                },
            };

            _context.Images.AddRange(images);
            _context.SaveChanges();
        }



        // now add the data to the questions
        private void SeedQuestion()
        {
            //lets check if the complexity has already been seed, 
            //if so, then we exit

            if (_context.Questions.Any()) //if there are any data in the database then exit the method, if not then add a new data in the database 
            {
                return;
            }
            //this is how you add multiple images to a question in the Seeder
            //Image = new List<Image>
            //this is how you seed the initial questions
            var questions = new Question[]
            {
                new Question()
                {
                    levelid = 1,
                    Opcode = "Count",
                    firstoperand = 1,
                    secondoperand = '?',
                    CorrectAnswer = "1"
    },

               new Question()
                {
                    levelid = 1,
                    Opcode = "Count",
                    firstoperand = 2,
                    secondoperand = '?',
                     CorrectAnswer = "2"
                },

                new Question()
                {
                    levelid = 1,
                    Opcode = "Count",
                    firstoperand = 3,
                    secondoperand = '?',
                    CorrectAnswer = "3"
                },

                new Question()
                {
                    levelid = 1,
                    Opcode = "Count",
                    firstoperand = 4,
                    secondoperand = '?',
                    CorrectAnswer = "4"
                },

                new Question()
                {
                    levelid = 1,
                    Opcode = "Count",
                    firstoperand = 5,
                    secondoperand = '?',
                    CorrectAnswer = "5"
                },
                //level changes to 2
                new Question()
                {
                    levelid = 2,
                    Opcode = "Count",
                    firstoperand = 6,
                    secondoperand = '?',
                    CorrectAnswer = "6"
                },

                new Question()
                {
                    levelid = 2,
                    Opcode = "Count",
                    firstoperand = 7,
                    secondoperand = '?',
                    CorrectAnswer = "7"
                },

                 new Question()
                {
                    levelid = 2,
                    Opcode = "Count",
                    firstoperand = 8,
                    secondoperand = '?',
                    CorrectAnswer = "8"
                },

                 new Question()
                {
                    levelid = 2,
                    Opcode = "Count",
                    firstoperand = 9,
                    secondoperand = '?',
                    CorrectAnswer = "9"
                },


                 new Question()
                {
                    levelid = 2,
                    Opcode = "Count",
                    firstoperand = 10,
                    secondoperand = '?',
                    CorrectAnswer = "10"
                },

                 //level changes to 3
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 11,
                    secondoperand = '?',
                    CorrectAnswer = "11"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 12,
                    secondoperand = '?',
                    CorrectAnswer = "12"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 13,
                    secondoperand = '?',
                    CorrectAnswer = "13"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 14,
                    secondoperand = '?',
                    CorrectAnswer = "14"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 15,
                    secondoperand = '?',
                    CorrectAnswer = "15"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 16,
                    secondoperand = '?',
                    CorrectAnswer = "16"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 17,
                    secondoperand = '?',
                    CorrectAnswer = "17"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 18,
                    secondoperand = '?',
                    CorrectAnswer = "18"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 19,
                    secondoperand = '?',
                    CorrectAnswer = "19"
                },
                new Question()
                {
                    levelid = 3,
                    Opcode = "Count",
                    firstoperand = 20,
                    secondoperand = '?',
                    CorrectAnswer = "20"
                },

                //level changes to 4 compare within 5

                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 1,
                    secondoperand = 3,
                    CorrectAnswer = "3"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 1,
                    secondoperand = 4,
                    CorrectAnswer = "4"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 2,
                    secondoperand = 3,
                    CorrectAnswer = "3"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 3,
                    secondoperand = 5,
                    CorrectAnswer = "5"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 1,
                    secondoperand = 5,
                    CorrectAnswer = "5"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 2,
                    secondoperand = 4,
                    CorrectAnswer = "4"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 3,
                    secondoperand = 4,
                    CorrectAnswer = "4"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 2,
                    secondoperand = 5,
                    CorrectAnswer = "5"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 5,
                    secondoperand = 4,
                    CorrectAnswer = "5"
                },
                new Question()
                {
                    levelid = 4,
                    Opcode = "Compare",
                    firstoperand = 3,
                    secondoperand = 1,
                    CorrectAnswer = "3"
                },

                //level changes to 5 compare with in 6 to 10

                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 6,
                    secondoperand = 10,
                    CorrectAnswer = "10"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 8,
                    secondoperand = 9,
                    CorrectAnswer = "9"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 7,
                    secondoperand = 8,
                    CorrectAnswer = "8"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 9,
                    secondoperand = 10,
                    CorrectAnswer = "10"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 10,
                    secondoperand = 6,
                    CorrectAnswer = "10"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 8,
                    secondoperand = 7,
                    CorrectAnswer = "8"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 6,
                    secondoperand = 7,
                    CorrectAnswer = "7"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 8,
                    secondoperand = 6,
                    CorrectAnswer = "8"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 9,
                    secondoperand = 7,
                    CorrectAnswer = "9"
                },
                new Question()
                {
                    levelid = 5,
                    Opcode = "Compare",
                    firstoperand = 10,
                    secondoperand = 7,
                    CorrectAnswer = "10"
                },

                //level changes to 6 compare 11-20
                new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 11,
                    secondoperand = 13,
                    CorrectAnswer = "13"
                },
                new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 12,
                    secondoperand = 14,
                    CorrectAnswer = "14"
                },
                new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 13,
                    secondoperand = 15,
                    CorrectAnswer = "15"
                },
                new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 14,
                    secondoperand = 18,
                    CorrectAnswer = "18"
                },
                 new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 19,
                    secondoperand = 15,
                    CorrectAnswer = "19"
                },

                 new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 16,
                    secondoperand = 20,
                    CorrectAnswer = "20"
                },

                  new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 17,
                    secondoperand = 18,
                    CorrectAnswer = "18"
                },
                  new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 18,
                    secondoperand = 19,
                    CorrectAnswer = "19"
                },

                  new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 20,
                    secondoperand = 17,
                    CorrectAnswer = "20"
                },
                  new Question()
                {
                    levelid = 6,
                    Opcode = "Compare",
                    firstoperand = 19,
                    secondoperand = 13,
                    CorrectAnswer = "19"
                },

                  //level changes to 7, count 21-50

                  new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 21,
                    secondoperand = '?',
                    CorrectAnswer = "21"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 22,
                    secondoperand = '?',
                    CorrectAnswer = "22"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 23,
                    secondoperand = '?',
                    CorrectAnswer = "23"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 24,
                    secondoperand = '?',
                    CorrectAnswer = "24"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 25,
                    secondoperand = '?',
                    CorrectAnswer = "25"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 26,
                    secondoperand = '?',
                    CorrectAnswer = "26"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 27,
                    secondoperand = '?',
                    CorrectAnswer = "27"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 28,
                    secondoperand = '?',
                    CorrectAnswer = "28"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 29,
                    secondoperand = '?',
                    CorrectAnswer = "29"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 30,
                    secondoperand = '?',
                    CorrectAnswer = "30"
                },

                  new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 31,
                    secondoperand = '?',
                    CorrectAnswer = "31"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 32,
                    secondoperand = '?',
                    CorrectAnswer = "32"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 33,
                    secondoperand = '?',
                    CorrectAnswer = "33"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 34,
                    secondoperand = '?',
                    CorrectAnswer = "34"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 35,
                    secondoperand = '?',
                    CorrectAnswer = "35"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 36,
                    secondoperand = '?',
                    CorrectAnswer = "36"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 37,
                    secondoperand = '?',
                    CorrectAnswer = "37"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 38,
                    secondoperand = '?',
                    CorrectAnswer = "38"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 39,
                    secondoperand = '?',
                    CorrectAnswer = "39"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 40,
                    secondoperand = '?',
                    CorrectAnswer = "40"
                },

                  new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 41,
                    secondoperand = '?',
                    CorrectAnswer = "41"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 42,
                    secondoperand = '?',
                    CorrectAnswer = "42"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 43,
                    secondoperand = '?',
                    CorrectAnswer = "43"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 44,
                    secondoperand = '?',
                    CorrectAnswer = "44"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 45,
                    secondoperand = '?',
                    CorrectAnswer = "45"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 46,
                    secondoperand = '?',
                    CorrectAnswer = "46"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 47,
                    secondoperand = '?',
                    CorrectAnswer = "47"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 48,
                    secondoperand = '?',
                    CorrectAnswer = "48"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 49,
                    secondoperand = '?',
                    CorrectAnswer = "49"
                },
                new Question()
                {
                    levelid = 7,
                    Opcode = "Count",
                    firstoperand = 50,
                    secondoperand = '?',
                    CorrectAnswer = "50"
                },

                //level changes to 8 compare 21-50
                new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 21,
                    secondoperand = 29,
                    CorrectAnswer = "29"
                },
                new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 50,
                    secondoperand = 48,
                    CorrectAnswer = "50"
                },
                new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 37,
                    secondoperand = 22,
                    CorrectAnswer = "37"
                },
                new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 39,
                    secondoperand = 49,
                    CorrectAnswer = "49"
                },
                 new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 44,
                    secondoperand = 22,
                    CorrectAnswer = "44"
                },

                 new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 27,
                    secondoperand = 47,
                    CorrectAnswer = "47"
                },

                  new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 25,
                    secondoperand = 50,
                    CorrectAnswer = "50"
                },
                  new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 36,
                    secondoperand = 39,
                    CorrectAnswer = "39"
                },

                  new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 41,
                    secondoperand = 31,
                    CorrectAnswer = "41"
                },
                  new Question()
                {
                    levelid = 8,
                    Opcode = "Compare",
                    firstoperand = 38,
                    secondoperand = 31,
                    CorrectAnswer = "38"
                },

                  //level changes to 9 dealing with addition within 5

                  new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 1,
                    secondoperand = 3,
                    CorrectAnswer = "4"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 1,
                    secondoperand = 4,
                    CorrectAnswer = "5"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 2,
                    secondoperand = 3,
                    CorrectAnswer = "5"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 3,
                    secondoperand = 5,
                    CorrectAnswer = "8"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 1,
                    secondoperand = 5,
                    CorrectAnswer = "6"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 2,
                    secondoperand = 4,
                    CorrectAnswer = "6"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 3,
                    secondoperand = 4,
                    CorrectAnswer = "7"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 2,
                    secondoperand = 5,
                    CorrectAnswer = "7"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 5,
                    secondoperand = 4,
                    CorrectAnswer = "9"
                },
                new Question()
                {
                    levelid = 9,
                    Opcode = "+",
                    firstoperand = 3,
                    secondoperand = 1,
                    CorrectAnswer = "4"
                },

                 //level changes to 10 dealing with subtraction within 5

                  new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 3,
                    secondoperand = 1,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 4,
                    secondoperand = 1,
                    CorrectAnswer = "3",
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 3,
                    secondoperand = 2,
                    CorrectAnswer = "1"
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 5,
                    secondoperand = 3,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 5,
                    secondoperand = 1,
                    CorrectAnswer = "4"
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 4,
                    secondoperand = 2,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 4,
                    secondoperand = 3,
                    CorrectAnswer = "1"
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 5,
                    secondoperand = 2,
                    CorrectAnswer = "3"
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 5,
                    secondoperand = 4,
                    CorrectAnswer = "1"
                },
                new Question()
                {
                    levelid = 10,
                    Opcode = "-",
                    firstoperand = 3,
                    secondoperand = 1,
                    CorrectAnswer = "2"
                },

                //level changes to 11 add within 6--10

                 new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 6,
                    secondoperand = 10,
                    CorrectAnswer = "16"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 8,
                    secondoperand = 9,
                    CorrectAnswer = "17"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 7,
                    secondoperand = 8,
                    CorrectAnswer = "15"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 9,
                    secondoperand = 10,
                    CorrectAnswer = "19"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 10,
                    secondoperand = 6,
                    CorrectAnswer = "16"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 8,
                    secondoperand = 7,
                    CorrectAnswer = "15"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 6,
                    secondoperand = 7,
                    CorrectAnswer = "13"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 8,
                    secondoperand = 6,
                    CorrectAnswer = "14"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 9,
                    secondoperand = 7,
                    CorrectAnswer = "16"
                },
                new Question()
                {
                    levelid = 11,
                    Opcode = "+",
                    firstoperand = 10,
                    secondoperand = 7,
                    CorrectAnswer = "17"
                },

                //level changes to 12 subtract within 6--10  
                 new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 10,
                    secondoperand = 6,
                    CorrectAnswer = "4"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 9,
                    secondoperand = 8,
                    CorrectAnswer = "1"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 8,
                    secondoperand = 7,
                    CorrectAnswer = "1"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 10,
                    secondoperand = 10,
                    CorrectAnswer = "0"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 9,
                    secondoperand = 6,
                    CorrectAnswer = "3"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 7,
                    secondoperand = 5,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 10,
                    secondoperand = 7,
                    CorrectAnswer = "3"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 8,
                    secondoperand = 6,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 9,
                    secondoperand = 7,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 12,
                    Opcode = "-",
                    firstoperand = 10,
                    secondoperand = 8,
                    CorrectAnswer = "2"
                },

                //level changes to 13 add within 11-20

                new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 11,
                    secondoperand = 13,
                    CorrectAnswer = "24"
                },
                new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 12,
                    secondoperand = 14,
                    CorrectAnswer = "26"
                },
                new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 13,
                    secondoperand = 15,
                    CorrectAnswer = "28"
                },
                new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 14,
                    secondoperand = 18,
                    CorrectAnswer = "32"
                },
                 new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 19,
                    secondoperand = 15,
                    CorrectAnswer = "34"
                },

                 new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 16,
                    secondoperand = 20,
                    CorrectAnswer = "36"
                },

                  new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 17,
                    secondoperand = 18,
                    CorrectAnswer = "35"
                },
                  new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 18,
                    secondoperand = 19,
                    CorrectAnswer = "37"
                },

                  new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 20,
                    secondoperand = 17,
                    CorrectAnswer = "37"
                },
                  new Question()
                {
                    levelid = 13,
                    Opcode = "+",
                    firstoperand = 19,
                    secondoperand = 13,
                    CorrectAnswer = "32"
                },

                  //level changes to 14 subtract with =in 11-20
                  new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 13,
                    secondoperand = 11,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 14,
                    secondoperand = 12,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 15,
                    secondoperand = 13,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 18,
                    secondoperand = 15,
                    CorrectAnswer = "3"
                },
                 new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 19,
                    secondoperand = 11,
                    CorrectAnswer = "8"
                },

                 new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 20,
                    secondoperand = 16,
                    CorrectAnswer = "4"
                },

                  new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 18,
                    secondoperand = 17,
                    CorrectAnswer = "1"
                },
                  new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 19,
                    secondoperand = 19,
                    CorrectAnswer = "0"
                },

                  new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 20,
                    secondoperand = 17,
                    CorrectAnswer = "3"
                },
                  new Question()
                {
                    levelid = 14,
                    Opcode = "-",
                    firstoperand = 19,
                    secondoperand = 13,
                    CorrectAnswer = "6"
                },

                  //level changes to 15 add within 21--50

                  new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 21,
                    secondoperand = 29,
                    CorrectAnswer = "50"
                },
                new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 50,
                    secondoperand = 48,
                    CorrectAnswer = "98"
                },
                new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 37,
                    secondoperand = 22,
                    CorrectAnswer = "59"
                },
                new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 39,
                    secondoperand = 49,
                    CorrectAnswer = "88"
                },
                 new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 44,
                    secondoperand = 22,
                    CorrectAnswer = "66"
                },

                 new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 27,
                    secondoperand = 47,
                    CorrectAnswer = "74"
                },

                  new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 25,
                    secondoperand = 50,
                    CorrectAnswer = "75"
                },
                  new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 36,
                    secondoperand = 39,
                    CorrectAnswer = "75"
                },

                  new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 41,
                    secondoperand = 31,
                    CorrectAnswer = "72"
                },
                  new Question()
                {
                    levelid = 15,
                    Opcode = "+",
                    firstoperand = 38,
                    secondoperand = 31,
                    CorrectAnswer = "69"
                },

                  //level changes to 16 subtract within 21--50
                  new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 29,
                    secondoperand = 21,
                    CorrectAnswer = "8"
                },
                new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 50,
                    secondoperand = 48,
                    CorrectAnswer = "2"
                },
                new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 37,
                    secondoperand = 22,
                    CorrectAnswer = "15"
                },
                new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 49,
                    secondoperand = 39,
                    CorrectAnswer = "10"
                },
                 new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 44,
                    secondoperand = 22,
                    CorrectAnswer = "22"
                },

                 new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 47,
                    secondoperand = 27,
                    CorrectAnswer = "20"
                },

                  new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 50,
                    secondoperand = 45,
                    CorrectAnswer = "5"
                },
                  new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 39,
                    secondoperand = 36,
                    CorrectAnswer = "3"
                },

                  new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 41,
                    secondoperand = 31,
                    CorrectAnswer = "10"
                },
                  new Question()
                {
                    levelid = 16,
                    Opcode = "-",
                    firstoperand = 38,
                    secondoperand = 31,
                    CorrectAnswer = "7"
                },
            };

            _context.Questions.AddRange(questions);
            _context.SaveChanges();
        }


        private void SeedComplexity()
        {//if the data is there in complexity table then exit the method
            if (_context.Complexities.Any())
            {
                return;
            }
            //if the data is not there then insert the data in the complexity table
            var complexities = new Complexity[]
            {

                new Complexity()
                {
                    LevelId = 1,
                    Range = "within 1--5",
                    Operation = "Count",
                    Speed = "2 min"
                },

                new Complexity()
                {
                    LevelId = 2,
                    Range = "within 6--5",
                    Operation = "Count",
                    Speed = "1 min"
                },

                new Complexity()
                {
                    LevelId = 3,
                    Range = "within 11--20",
                    Operation = "Count",
                    Speed = "half min"
                },
                new Complexity()
                {
                    LevelId = 4,
                    Range = "within 1--5",
                    Operation = "Compare",
                    Speed = "2 min"
                },
                new Complexity()
                {
                    LevelId = 5,
                    Range = "within 6--10",
                    Operation = "Compare",
                    Speed = "1 min"
                },
                new Complexity()
                {
                    LevelId = 6,
                    Range = "within 11--20",
                    Operation = "Compare",
                    Speed = "half min"
                },
                new Complexity()
                {
                    LevelId = 7,
                    Range = "within 21--50",
                    Operation = "Count",
                    Speed = "quarter min"
                },
                new Complexity()
                {
                    LevelId = 8,
                    Range = "within 21--50",
                    Operation = "Compare",
                    Speed = "quarter min"
                },
                new Complexity()
                {
                    LevelId = 9,
                    Range = "within 1--5",
                    Operation = "Add",
                    Speed = "2 min"
                },
                new Complexity()
                {
                    LevelId = 10,
                    Range = "within 1--5",
                    Operation = "Subtract",
                    Speed = "2 min"
                },
                new Complexity()
                {
                    LevelId = 11,
                    Range = "within 6--10",
                    Operation = "Add",
                    Speed = "1 min"
                },
                new Complexity()
                {
                    LevelId = 12,
                    Range = "within 6--10",
                    Operation = "Subtract",
                    Speed = "1 min"
                },
                new Complexity()
                {
                    LevelId = 13,
                    Range = "within 11--20",
                    Operation = "Add",
                    Speed = "half min"
                },
                new Complexity()
                {
                    LevelId = 14,
                    Range = "within 11--20",
                    Operation = "Subtract",
                    Speed = "half min"
                },
                new Complexity()
                {
                    LevelId = 15,
                    Range = "within 21--50",
                    Operation = "Add",
                    Speed = "quarter min"
                },
                new Complexity()
                {
                    LevelId = 16,
                    Range = "within 21--50",
                    Operation = "Subtract",
                    Speed = "quarter min"
                }
        };
            _context.Complexities.AddRange(complexities);
            _context.SaveChanges();

        }

    

        public void Seed()
        {
            SeedComplexity();
            SeedQuestion();
            SeedImage();
        }
    }

}




        
