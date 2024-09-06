using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;

namespace RestaurantManagementSystem.Repository
{
    public class TableRepository : ITableRepository
    {
        private readonly RestaurantManagementSystemContext _context;

        public TableRepository(RestaurantManagementSystemContext context)
        {
            _context = context;
        }

        public async Task<Table> CreateTableAsync(Table table)
        {
            try
            {
                await _context.Tables.AddAsync(table);
                await _context.SaveChangesAsync();
                return table;
            }
            catch (Exception)
            {
                throw new Exception("Could not add table to database.");
            }
        }

        public async Task<Table> ReadTableInformationAsync(int tableId)
        {
            try
            {
                return await _context.Tables.SingleOrDefaultAsync(t => t.TableId == tableId);
            }       
            catch(Exception)
            {
                throw new Exception("could not fetch table data from the database.");
            }
        }

        public async Task<IEnumerable<Table>> ReadAllTablesRepoAsync()
        {
            try
            {
                return await _context.Tables.ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Could not fetch table data from database.");
            }
        }

        public async Task UpdateTableRepoAsync(Table table)
        {
            _context.Tables.Update(table);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteTableRepoAsync(int tableId, int tableNumber)
        {
            var tableToDelete = await _context.Tables
                .FirstOrDefaultAsync(t => t.TableId == tableId && t.TableNumber == tableNumber);

            if (tableToDelete == null)
            {
                return false;
            }

            _context.Tables.Remove(tableToDelete);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
