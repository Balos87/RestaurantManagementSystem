using RestaurantManagementSystem.Services.IServices;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.Models;
using System;
using System.Threading.Tasks;
using RestaurantManagementSystem.DTOs.Users;
using RestaurantManagementSystem.Repository;
using RestaurantManagementSystem.DTOs.Tables;

namespace RestaurantManagementSystem.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _tableRepository;
        private readonly IBookingRepository _bookingRepository;

        public TableService(ITableRepository tableRepository, IBookingRepository bookingRepository)
        {
            _tableRepository = tableRepository;
            _bookingRepository = bookingRepository;
        }

        public async Task CreateTableAsync(CreateTableDto createTableDto)
        {
            var table = new Table()
            {
                TableNumber = createTableDto.TableNumber,
                Seats = createTableDto.Seats,
                Description = createTableDto.Description,
            };

            await _tableRepository.CreateTableAsync(table);
        }

        public async Task<TableDto> ReadTableInformationAsync(int tableId)
        {
            var table = await _tableRepository.ReadTableInformationAsync(tableId);

            if (table == null)
            {
                return null;
            }

            var tableDto = new TableDto()
            {
                TableId = table.TableId,
                TableNumber = table.TableNumber,
                Seats = table.Seats,
                Description = table.Description,
            };

            return tableDto;
        }

        public async Task<IEnumerable<TableDto>> ReadAllTablesAsync()
        {
            var tables = await _tableRepository.ReadAllTablesRepoAsync();

            var tableDtos = tables.Select(table => new TableDto()
            {
                TableId = table.TableId,
                TableNumber = table.TableNumber,
                Seats = table.Seats,
                Description = table.Description,
            });

            return tableDtos;
        }

        public async Task<bool> UpdateTableInformationServiceAsync(int tableId, UpdateTableDto updateTableDto)
        {
            var table = await _tableRepository.ReadTableInformationAsync(tableId);
            if (table == null)
            {
                return false;
            }

            table.TableNumber = updateTableDto.TableNumber;
            table.Seats = updateTableDto.Seats;
            table.Description = updateTableDto.Description;

            await _tableRepository.UpdateTableRepoAsync(table);
            return true;
        }

        public async Task<bool> DeleteTableServiceAsync(int tableId, DeleteTableDto deleteTableDto)
        {
            return await _tableRepository.DeleteTableRepoAsync(tableId, deleteTableDto.TableNumber);
        }

        public async Task<IEnumerable<TableDto>> GetAvailableTablesAsync(DateTime reservationDateTime, int numberOfGuests)
        {
            var allTables = await _tableRepository.ReadAllTablesRepoAsync();

            var conflictingBookings = await _bookingRepository.GetConflictingBookingsAsync(reservationDateTime);

            var bookedTableIds = conflictingBookings
                .SelectMany(b => b.BookingTables)
                .Select(bt => bt.TableId)
                .Distinct()
                .ToList();

            var availableTables = allTables
                .Where(t => !bookedTableIds.Contains(t.TableId) && t.Seats >= numberOfGuests)
                .Select(t => new TableDto
                {
                    TableId = t.TableId,
                    TableNumber = t.TableNumber,
                    Seats = t.Seats,
                    Description = t.Description,
                });

            return availableTables;
        }
    }
}
