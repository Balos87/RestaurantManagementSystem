using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.TableDTOs
{
    public class DeleteTableDto
    {
        [Required]
        public int TableNumber { get; set; }
    }
}
