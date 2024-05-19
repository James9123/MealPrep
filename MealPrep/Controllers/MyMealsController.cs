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
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create([Bind("Id,Title,Description")] Meal meal)
        {
            //need to check if model state is valid
            if (ModelState.IsValid)
            {
                MealPlan nextMeal = new MealPlan(meal);
                _db.MyMeals.Add(nextMeal);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
