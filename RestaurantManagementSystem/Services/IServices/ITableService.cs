
using RestaurantManagementSystem.DTOs.CustomerDTOs;
using RestaurantManagementSystem.DTOs.TableDTOs;
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

    }
}
