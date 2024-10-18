using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementSystem.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [ForeignKey(nameof(Models.Menu))]
        public int? MenuId { get; set; }
        public Menu Menu { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string DishName { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
        public bool Popular { get; set; }
    }
}
