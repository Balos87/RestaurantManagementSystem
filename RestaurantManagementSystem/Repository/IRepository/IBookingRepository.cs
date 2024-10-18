using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository.IRepository
{
    public interface IBookingRepository
    {   
        Task<Booking> CreateBookingRepoAsync(Booking booking);
        Task<Booking> ReadBookingRepoAsync(int bookingId);
        Task<IEnumerable<Booking>> ReadAllBookingsRepoAsync();
        Task<IEnumerable<Booking>> ReadAllBookingsByDateRepoAsync(DateTime date);
        Task<Booking> UpdateBookingRepoAsync(Booking booking);
        Task<bool> DeleteBookingRepoAsync(int bookingId);
        Task<IEnumerable<BookingTable>> CheckOverlappingBookingsAsync(int tableId, DateTime reservationStart, DateTime reservationEnd);
        Task<IEnumerable<Booking>> GetConflictingBookingsAsync(DateTime reservationDateTime);
    }
}
