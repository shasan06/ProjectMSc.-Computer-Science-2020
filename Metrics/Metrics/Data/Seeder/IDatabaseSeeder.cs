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

        private void SeedComplexity()
        {
            //lets check if the complexity has already been seed, 
            //if so, then we exit

            if (_context.Complexities.Any()) //<- Sabrina, make sure you understand what this line is doing in case add more 
            {
                return;
            }

            //this is how you seed the initial complexities
            var complexities = new Complexity[]
            {
                new Complexity()
                {
                    Add=0,
                    Compare=0,
                    Count=1,                    
                    LevelId=1,
                    Range=0,
                    Subtract=0,
                    //this is how you add multiple images to a complexity in the Seeder
                    Image = new List<Image>
                    {
                        new Image()
                        {
                            Title = "Image 1 for Complexity 1",
                            ImageName = "~/images/level1/image_1.jpg"

                        },
                        new Image()
                        {
                            Title = "Image 2 for Complexity 1",
                            ImageName = "~/images/level1/image_1of1.png"
                        },
                         new Image()
                        {
                            Title = "Image 3 for Complexity 1",
                            ImageName = "~/images/level1/image_2.png"

                        },
                        new Image()
                        {
                            Title = "Image 4 for Complexity 1",
                            ImageName = "~/images/level1/image_2of2.png"
                        },
                         new Image()
                        {
                            Title = "Image 5 for Complexity 1",
                            ImageName = "~/images/level1/image_3.png"

                        },
                        new Image()
                        {
                            Title = "Image 6 for Complexity 1",
                            ImageName = "~/images/level1/image_3of3.png"
                        },
                         new Image()
                        {
                            Title = "Image 7 for Complexity 1",
                            ImageName = "~/images/level1/image_4.png"

                        },
                        new Image()
                        {
                            Title = "Image 8 for Complexity 1",
                            ImageName = "~/images/level1/image_4of4.png"
                        },
                         new Image()
                        {
                            Title = "Image 9 for Complexity 1",
                            ImageName = "~/images/level1/image_5.png"

                        },
                        new Image()
                        {
                            Title = "Image 10 for Complexity 1",
                            ImageName = "~/images/level1/image_5of5.png"
                        },
                    }
                },
                new Complexity()
                {
                    Add=2,
                    Compare=2,
                    Count=2,
                    LevelId=2,
                    Range=2,
                    Subtract=2,
                    Image = new List<Image>
                    {
                        new Image()
                        {
                            Title = "Image 2",
                            ImageName = "Name"
                        },
                        new Image()
                        {
                            Title = "Image2",
                            ImageName = "Name2"
                        },
                    }
                }

            };
            _context.Complexities.AddRange(complexities);
            _context.SaveChanges();
        }
        public void Seed()
        {
            SeedComplexity();
        }
    }
}
