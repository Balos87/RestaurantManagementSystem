using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.Tables
{
    public class UpdateTableDto
    {
        [Required]
        public int TableNumber { get; set; }
        [Required]
        public int Seats { get; set; }
        public string Description { get; set; }
    }
}