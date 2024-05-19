using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace MealPrep.Models
{
    public class MealPlan
    {
        [Key]
        public int Id { get; set; }
        
        public Meal? Meal { get; set; }
        public int Amount { get; set; }

        public MealPlan()
        {
        }

        public MealPlan(Meal? meal)
        {
            Meal = meal;
        }

        
    }
}
