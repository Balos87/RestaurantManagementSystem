using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }

        [Range(1, 20)]
        public int TableNumber { get; set; }

        [Range(1, 10)]
        public int Seats { get; set; }

        public ICollection<BookingTable> BookingTables { get; set; }
    }
}
