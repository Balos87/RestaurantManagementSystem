
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository.IRepository
{
    public interface ITableRepository
    {
        Task <Table>CreateTableAsync(Table table);
        Task <Table>ReadTableInformationAsync(int id);
        Task<IEnumerable<Table>> ReadAllTablesRepoAsync();
        Task UpdateTableRepoAsync(Table table);
        Task<bool> DeleteTableRepoAsync(int tableId, int tableNumber);
    }
}
