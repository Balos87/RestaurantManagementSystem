using RestaurantManagementSystem.Services.IServices;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.DTOs.TableDTOs;
using RestaurantManagementSystem.Models;
using System;
using System.Threading.Tasks;
using RestaurantManagementSystem.DTOs.CustomerDTOs;
using RestaurantManagementSystem.Repository;

namespace RestaurantManagementSystem.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task CreateTableAsync(CreateTableDto createTableDto)
        {
            var table = new Table()
            {
                TableNumber = createTableDto.TableNumber,
                Seats = createTableDto.Seats
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
                Seats = table.Seats
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
                Seats = table.Seats
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

            await _tableRepository.UpdateTableRepoAsync(table);
            return true;
        }

        public async Task<bool> DeleteTableServiceAsync(int tableId, DeleteTableDto deleteTableDto)
        {
            return await _tableRepository.DeleteTableRepoAsync(tableId, deleteTableDto.TableNumber);
        }

    }
}
