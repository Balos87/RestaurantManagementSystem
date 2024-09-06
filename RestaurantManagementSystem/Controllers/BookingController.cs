using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.DTOs.BookingDTOs;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateBookingControllerAsync([FromBody] CreateBookingDto createBookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var bookingId = await _bookingService.CreateBookingServiceAsync(createBookingDto);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{bookingId}")]
        public async Task<IActionResult> ReadBookingControllerAsync(int bookingId)
        {
            var bookingDto = await _bookingService.ReadBookingServiceAsync(bookingId);
            if (bookingDto == null)
            {
                return NotFound();
            }
            return Ok(bookingDto);
        }

        [HttpGet("bookings")]
        public async Task<IActionResult> ReadAllBookingsControllerAsync()
        {
            var bookingDto = await _bookingService.ReadAllBookingsServiceAsync();
            return Ok(bookingDto);
        }

        [HttpGet("by-date/{date}")]
        public async Task<IActionResult> ReadAllBookingsByDateControllerAsync(DateTime date)
        {
            var bookingDto = await _bookingService.ReadAllBookingsByDateServiceAsync(date);
            if (bookingDto == null || !bookingDto.Any())
            {
                return NotFound();
            }

            return Ok(bookingDto);
        }

        [HttpPut("update/{bookingId}")]
        public async Task<IActionResult> UpdateBookingControllerAsync(int bookingId, [FromBody] UpdateBookingDto updateBookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _bookingService.UpdateBookingServiceAsync(bookingId, updateBookingDto);
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("delete/{bookingId}")]
        public async Task<IActionResult> DeleteBookingControllerAsync(int bookingId)
        {
            var success = await _bookingService.DeleteBookingServiceAsync(bookingId);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
