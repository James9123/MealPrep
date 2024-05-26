using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MealPrep.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./MealManager.sqlite");
        }

        public DbSet<Meal> AvaliableMeals { get; set; }

        public DbSet<MealPlan> MyMeals { get; set; }




        //public DbSet<Meal> MyMeals { get; set; }
    }

}
