using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metrics.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


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

            if (_context.Complexities.Any())
            {
                return;
            }

            var complexities = new Complexity[]
            {
                new Complexity()
                {
                    Add=1,
                    Compare=1,
                    Count=1,
                    Image="image_1.jpg",
                    LevelId=1,
                    Range=1,
                    Subtract=1,


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
