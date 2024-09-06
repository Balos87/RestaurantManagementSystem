using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.DTOs.BookingDTOs;
using RestaurantManagementSystem.DTOs.Bookings;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Services.IServices
{
    public interface IBookingService
    {
        Task<int> CreateBookingServiceAsync(CreateBookingDto createBookingDto);
        Task<BookingSingleDto> ReadBookingServiceAsync(int bookingId);
        Task<IEnumerable<BookingDto>> ReadAllBookingsServiceAsync();
        Task<IEnumerable<BookingDto>> ReadAllBookingsByDateServiceAsync(DateTime date);
        Task<IActionResult> UpdateBookingServiceAsync(int bookingId, UpdateBookingDto updateBookingDto);
        Task<bool> DeleteBookingServiceAsync(int bookingId);
    }
}
