using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementSystem.Models
{
    public class BookingTable
    {
        [Key]
        public int BookingTableId { get; set; }

        [ForeignKey(nameof(Models.Table))]
        public int TableId { get; set; }
        public Table Table { get; set; }

        [ForeignKey(nameof(Models.Booking))]
        public int BookingId { get; set; }
        public Booking Booking { get; set; }

        [Required]
        public DateTime ReservationStartDateTime { get; set; }
        [Required]
        public DateTime ReservationEndDateTime { get; set; }

    }
}
