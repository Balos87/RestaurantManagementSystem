using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.DTOs.BookingDTOs;
using RestaurantManagementSystem.DTOs.Bookings;
using RestaurantManagementSystem.DTOs.TableDTOs;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ITableRepository _tableRepository;

        public BookingService(IBookingRepository bookingRepository, ICustomerRepository customerRepository, ITableRepository tableRepository)
        {
            _bookingRepository = bookingRepository;
            _customerRepository = customerRepository;
            _tableRepository = tableRepository;
        }

        public async Task<int> CreateBookingServiceAsync(CreateBookingDto createBookingDto)
        {
            var customer = await _customerRepository.ReadCustomerRepoAsync(createBookingDto.CustomerId)
                ?? throw new ArgumentException("Sorry, but could not find a customer with the ID provided.");

            var table = await _tableRepository.ReadTableInformationAsync(createBookingDto.TableId)
                ?? throw new ArgumentException("Sorry, but the database does not contain a table with that ID.");

            if (table.Seats < createBookingDto.NumberOfGuests)
            {
                throw new InvalidOperationException("Unfortunately, the table does not have enough seats for the number of guests requested.");
            }

            var reservationEnd = createBookingDto.ReservationDateTime.AddHours(2);

            var overlappingBookings = await _bookingRepository.CheckOverlappingBookingsAsync(createBookingDto.TableId, createBookingDto.ReservationDateTime, reservationEnd);

            if (overlappingBookings.Any())
            {
                throw new InvalidOperationException("Sorry, but that table is not available at the selected time.");
            }

            var booking = new Booking()
            {
                CustomerId = createBookingDto.CustomerId,
                NumberOfGuests = createBookingDto.NumberOfGuests,
                ReservationDateTime = createBookingDto.ReservationDateTime,
                EndDateTime = reservationEnd,
                BookingTables = new List<BookingTable>
                {
                    new BookingTable()
                    {
                        TableId = createBookingDto.TableId,
                        ReservationStartDateTime = createBookingDto.ReservationDateTime,
                        ReservationEndDateTime = reservationEnd
                    }
                }
            };
            await _bookingRepository.CreateBookingRepoAsync(booking);

            return booking.BookingId;
        }


        public async Task<BookingSingleDto> ReadBookingServiceAsync(int bookingId)
        {
            var booking = await _bookingRepository.ReadBookingRepoAsync(bookingId);
            if (booking == null)
            {
                return null;
            }

            var viewModel = new BookingSingleDto()
            {
                CustomerId = booking.CustomerId,
                FirstName = booking.Customer.FirstName,
                LastName = booking.Customer.LastName,
                ReservationDateTime = booking.ReservationDateTime,
                EndDateTime = booking.EndDateTime,
                Tables = booking.BookingTables.Select(bt => new TableDto()
                {
                    TableId = bt.TableId,
                    TableNumber = bt.Table.TableNumber,
                    Seats = bt.Table.Seats
                }).ToList()
            };

            return viewModel;
        }

        public async Task<IEnumerable<BookingDto>> ReadAllBookingsServiceAsync()
        {
            var bookings = await _bookingRepository.ReadAllBookingsRepoAsync();

            var viewModel = bookings.Select(booking => new BookingDto()
            {
                BookingId = booking.BookingId,
                CustomerId = booking.CustomerId,
                FirstName = booking.Customer.FirstName,
                LastName = booking.Customer.LastName,
                ReservationDateTime = booking.ReservationDateTime,
                EndDateTime = booking.EndDateTime,
                Tables = booking.BookingTables.Select(bt => new TableDto()
                {
                    TableId = bt.Table.TableId,
                    TableNumber = bt.Table.TableNumber,
                    Seats = bt.Table.Seats
                }).ToList()
            });

            return viewModel;
        }

        public async Task<IEnumerable<BookingDto>> ReadAllBookingsByDateServiceAsync(DateTime date)
        {
            var bookings = await _bookingRepository.ReadAllBookingsByDateRepoAsync(date.Date);

            var viewModel = bookings.Select(booking => new BookingDto()
            {
                BookingId = booking.BookingId,
                CustomerId = booking.CustomerId,
                FirstName = booking.Customer.FirstName,
                LastName = booking.Customer.LastName,
                ReservationDateTime = booking.ReservationDateTime,
                EndDateTime = booking.EndDateTime,
                Tables = booking.BookingTables.Select(bt => new TableDto()
                {
                    TableId = bt.Table.TableId,
                    TableNumber = bt.Table.TableNumber,
                    Seats = bt.Table.Seats
                }).ToList()
            });

            return viewModel;
        }

        public async Task<IActionResult> UpdateBookingServiceAsync(int bookingId, UpdateBookingDto updateBookingDto)
        {
            var booking = await _bookingRepository.ReadBookingRepoAsync(bookingId);
            if (booking == null)
            {
                return new NotFoundObjectResult($"Sorry, but no booking with ID {bookingId} could be found.");
            }

            var overlappingBookings = await _bookingRepository.CheckOverlappingBookingsAsync(
            updateBookingDto.TableId,
            updateBookingDto.ReservationDateTime,
            updateBookingDto.EndDateTime);

            if (overlappingBookings.Any())
            {
                return new ConflictObjectResult("The table is unfortunately not available at the selected time.");
            }

            var table = await _tableRepository.ReadTableInformationAsync(updateBookingDto.TableId);
            if (table == null)
            {
                return new NotFoundObjectResult("The selected table does not exist.");
            }

            if (table.Seats < updateBookingDto.NumberOfGuests)
            {
                return new ConflictObjectResult("The selected table does not have enough seats for the number of guests requested.");
            }

            booking.NumberOfGuests = updateBookingDto.NumberOfGuests;
            booking.ReservationDateTime = updateBookingDto.ReservationDateTime;
            booking.EndDateTime = updateBookingDto.EndDateTime;

            var bookingTable = booking.BookingTables.FirstOrDefault();
            if (bookingTable != null)
            {
                bookingTable.TableId = updateBookingDto.TableId;
                bookingTable.ReservationStartDateTime = updateBookingDto.ReservationDateTime;
                bookingTable.ReservationEndDateTime = updateBookingDto.EndDateTime;
            }

            await _bookingRepository.UpdateBookingRepoAsync(booking);

            return new OkResult();
        }

        public async Task<bool> DeleteBookingServiceAsync(int bookingId)
        {
            return await _bookingRepository.DeleteBookingRepoAsync(bookingId);
        }
    }
}
