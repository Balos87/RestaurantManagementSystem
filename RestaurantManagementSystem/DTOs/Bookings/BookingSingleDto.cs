using RestaurantManagementSystem.DTOs.Tables;

namespace RestaurantManagementSystem.DTOs.Bookings
{
    public class BookingSingleDto
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<TableDto> Tables { get; set; }
        public int NumberOfGuests { get; set; }
    }
}
