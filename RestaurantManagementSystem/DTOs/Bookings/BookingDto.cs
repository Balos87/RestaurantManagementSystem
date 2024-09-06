using RestaurantManagementSystem.DTOs.TableDTOs;

namespace RestaurantManagementSystem.DTOs.Bookings
{
    public class BookingDto
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<TableDto> Tables { get; set; }
    }
}
