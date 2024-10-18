using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }

        public int TableNumber { get; set; }

        public int Seats { get; set; }
        public string Description { get; set; }

        public ICollection<BookingTable> BookingTables { get; set; }
    }
}
