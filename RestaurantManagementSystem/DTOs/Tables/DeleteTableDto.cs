using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.Tables
{
    public class DeleteTableDto
    {
        [Required]
        public int TableNumber { get; set; }
    }
}
