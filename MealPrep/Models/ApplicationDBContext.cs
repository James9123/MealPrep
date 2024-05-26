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
        public DbSet<Recipe> Recipes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed categories
            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                Id = 1,
                Title = ":v)",
                Desc = ")v:"
            });
        }

    }
}

