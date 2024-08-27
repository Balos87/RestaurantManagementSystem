using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementSystem.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        //[ForeignKey(nameof(Models.Table))]
        //public int TableId { get; set; }
        //public Table Table { get; set; }

        [ForeignKey(nameof(Models.Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Range(1, 20)]
        public int NumberOfGuests { get; set; }

        [Required]
        public DateTime ReservationDateTime { get; set; }

        [Required]
        public DateTime EndDateTime { get; set; }

        public ICollection<BookingTable> BookingTables { get; set; }

    }
}
