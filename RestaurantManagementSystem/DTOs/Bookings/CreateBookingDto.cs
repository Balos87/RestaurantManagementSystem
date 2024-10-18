using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.Bookings
{
    public class CreateBookingDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int TableId { get; set; }

        [Required]
        public DateTime ReservationDateTime { get; set; }

        [Required]
        public int NumberOfGuests { get; set; }
    }
}
