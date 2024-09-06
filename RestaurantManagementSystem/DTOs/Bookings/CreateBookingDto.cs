using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.BookingDTOs
{
    public class CreateBookingDto
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int TableId { get; set; }

        [Required]
        public DateTime ReservationDateTime { get; set; }

        [Required]
        public int NumberOfGuests { get; set; }
    }
}
