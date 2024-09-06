using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;

namespace RestaurantManagementSystem.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly RestaurantManagementSystemContext _context;

        public BookingRepository(RestaurantManagementSystemContext context)
        {
            _context = context;
        }

        public async Task<Booking> CreateBookingRepoAsync(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<Booking> ReadBookingRepoAsync(int bookingId)
        {
            return await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.BookingTables)
                .ThenInclude(bt => bt.Table)
                .SingleOrDefaultAsync(b => b.BookingId == bookingId);
        }

        public async Task<IEnumerable<Booking>> ReadAllBookingsRepoAsync()
        {
            return await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.BookingTables)
                .ThenInclude(bt => bt.Table)
                .ToListAsync();
        }

        public async Task<IEnumerable<Booking>> ReadAllBookingsByDateRepoAsync(DateTime date)
        {
            return await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.BookingTables)
                .ThenInclude(bt => bt.Table)
                .Where(b => b.ReservationDateTime.Date == date)
                .ToListAsync();
        }

        public async Task<Booking> UpdateBookingRepoAsync(Booking booking)
        {
            foreach (var bookingTable in booking.BookingTables)
            {
                _context.BookingTables.Update(bookingTable);
            }

            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<bool> DeleteBookingRepoAsync(int bookingId)
        {
            var booking = await ReadBookingRepoAsync(bookingId);
            if (booking == null)
            {
                return false;
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<BookingTable>> CheckOverlappingBookingsAsync(int tableId, DateTime reservationStart, DateTime reservationEnd)
        {
            return await _context.BookingTables
                .Where(bt => bt.TableId == tableId &&
                             bt.ReservationStartDateTime < reservationEnd &&
                             bt.ReservationEndDateTime > reservationStart)
                .ToListAsync();
        }

        public async Task<IEnumerable<Booking>> CheckBookingsForTableAsync(int tableId, DateTime reservationDateTime)
        {
            return await _context.BookingTables
                .Where(bt => bt.TableId == tableId &&
                             bt.ReservationStartDateTime < reservationDateTime.AddHours(2) &&
                             bt.ReservationEndDateTime > reservationDateTime)
                .Select(bt => bt.Booking)
                .ToListAsync();
        }
    }
}
