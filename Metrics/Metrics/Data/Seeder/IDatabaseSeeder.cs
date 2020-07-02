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
                    Add=1,
                    Compare=1,
                    Count=1,                    
                    LevelId=1,
                    Range=1,
                    Subtract=1,
                    //this is how you add multiple images to a complexity in the Seeder
                    Image = new List<Image>
                    {
                        new Image()
                        {
                            Title = "Image 1 for Complexity 1",
                            ImageName = "Name"
                        },
                        new Image()
                        {
                            Title = "Image2 for Complexity 1",
                            ImageName = "Name2"
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
