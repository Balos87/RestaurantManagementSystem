
using RestaurantManagementSystem.DTOs.Users;
using RestaurantManagementSystem.DTOs.Tables;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Services.IServices
{
    public interface ITableService
    {
        Task CreateTableAsync(CreateTableDto createTableDto);
        Task<TableDto> ReadTableInformationAsync(int id);
        Task<IEnumerable<TableDto>> ReadAllTablesAsync();
        Task<bool> UpdateTableInformationServiceAsync(int tableId, UpdateTableDto updateTableDto);
        Task<bool> DeleteTableServiceAsync(int tableId, DeleteTableDto deleteTableDto);
        Task<IEnumerable<TableDto>> GetAvailableTablesAsync(DateTime reservationDateTime, int numberOfGuests);

    }
}
