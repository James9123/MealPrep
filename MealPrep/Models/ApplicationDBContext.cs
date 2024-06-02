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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                Id = 1,
                Title = "Roast Steak",
                Description = "A very fancy steak",
                ImageUrl = "./images/9.jpg",
            });
            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                Id = 2,
                Title = "Ice Cream",
                Description = "A delectable dessert",
                ImageUrl = "./images/7.jpg",
            });
            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                Id = 3,
                Title = "Burrito",
                Description = "Has Everything",
                ImageUrl = "./images/3.jpg",
            });
        }


        //public DbSet<Meal> MyMeals { get; set; }
    }

}
