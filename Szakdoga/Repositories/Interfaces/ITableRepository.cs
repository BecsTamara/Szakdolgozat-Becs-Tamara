using Microsoft.AspNetCore.Mvc.Rendering;
using Szakdoga.Data;
using Szakdoga.Models;

namespace Szakdoga.Contracts
{
    public interface ITableRepository : IGenericRepository<Table>
    {
        Task<List<TableVM>> GetTableVMListAsync();
        Task<TableVM> GetTableVMAsync(int id);
        Task<bool> CreateTableAsync(TableVM table);
        Task<IEnumerable<SelectListItem>> GetAllTables();
    }
}
