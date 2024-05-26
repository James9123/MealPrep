using System.ComponentModel.DataAnnotations;

namespace MealPrep.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
