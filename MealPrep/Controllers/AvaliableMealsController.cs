using MealPrep.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPrep.Controllers
{
    public class AvaliableMealsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AvaliableMealsController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            return View(_db.AvaliableMeals.ToList());
        }

        
    }
}
