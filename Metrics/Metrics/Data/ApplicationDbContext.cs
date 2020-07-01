using System;
using System.Collections.Generic;
using System.Text;
using Metrics.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Metrics.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Complexity> Complexities { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
