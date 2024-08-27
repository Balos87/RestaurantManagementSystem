using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementSystem.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [ForeignKey("Menu")]
        public int MenuId { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string DishName { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
        // Lägg till så den är false från början i context modelBuilder.
    }
}
