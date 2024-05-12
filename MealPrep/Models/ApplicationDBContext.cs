using System;
using Microsoft.EntityFrameworkCore;

namespace MealPrep.Models
{
	
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        //protected override void 
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<Client> Clients { get; set; }

        
    }
}

