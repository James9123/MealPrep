using Microsoft.AspNetCore.Mvc;
using MealPrep.Models;

namespace MealPrep.Controllers
{
    public class MyMealsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MyMealsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.MyMeals.ToList());
        }

        public IActionResult Create()
        {
            return View();
            //return View(_db.AvaliableMeals.ToList());
            //return View(nextMeal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create([Bind("Id,Title,Description,Notes")] MealPlan nextMeal)
        {
            //need to check if model state is valid
            if (ModelState.IsValid)
            {
                //MealPlan nextMeal = new MealPlan(meal);
                _db.MyMeals.Add(nextMeal);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed categories
            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                Id = 1,
                Title = "Spaghetti1",
                Desc = "yay for noodles"
            });
        }
         
         */

    }
}
