using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.TableDTOs
{
    public class CreateTableDto
    {
        [Required]
        public int TableNumber { get; set; }

        [Required]
        public int Seats { get; set; }

    }
}