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

        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var meal = _db.MyMeals.FirstOrDefault(m => m.Id == id);
            if (meal == null)
            {
                return NotFound();
            }
            return View(meal);
        }

        //Post
        [HttpPost]

        public IActionResult Edit(int id, [Bind("Id,Meal,Title,Description,Amount,Notes")] MealPlan mealplan)
        {
            if (ModelState.IsValid)
            {
                if (id != mealplan.Id)
                {
                    return NotFound();
                }
                _db.MyMeals.Update(mealplan);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mealplan);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var mealplan = _db.MyMeals.FirstOrDefault(m => m.Id == id);
            if (mealplan == null)
            {
                return NotFound();
            }

            return View(mealplan);
        }

        [HttpPost]

        public IActionResult Delete(int id, bool NotUsed)
        {
            var mealplan = _db.MyMeals.FirstOrDefault(m => m.Id == id);
            if (mealplan != null)
            {
                _db.MyMeals.Remove(mealplan);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
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
