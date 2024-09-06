using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository.IRepository
{
    public interface IBookingRepository
    {   //--- CRUD Operations ---
        Task<Booking> CreateBookingRepoAsync(Booking booking);
        Task<Booking> ReadBookingRepoAsync(int bookingId);
        Task<IEnumerable<Booking>> ReadAllBookingsRepoAsync();
        Task<IEnumerable<Booking>> ReadAllBookingsByDateRepoAsync(DateTime date);
        Task<Booking> UpdateBookingRepoAsync(Booking booking);
        Task<bool> DeleteBookingRepoAsync(int bookingId);
        //------------------------

        Task<IEnumerable<BookingTable>> CheckOverlappingBookingsAsync(int tableId, DateTime reservationStart, DateTime reservationEnd);
        Task<IEnumerable<Booking>> CheckBookingsForTableAsync(int tableId, DateTime reservationDateTime);



    }
}
