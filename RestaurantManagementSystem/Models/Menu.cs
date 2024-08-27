using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string MenuName { get; set; }

        public ICollection<Dish> Dishes { get; set; }
    }
}
