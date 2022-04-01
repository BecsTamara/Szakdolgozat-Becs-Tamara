using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Szakdoga.Contracts;
using Szakdoga.Data;
using Szakdoga.Models;

namespace Szakdoga.Repositories
{
    public class TableRepository : GenericRepository<Table>, ITableRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public TableRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<bool> CreateTableAsync(TableVM table)
        {
            try
            {
                await AddAsync(mapper.Map<Table>(table));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<TableVM> GetTableVMAsync(int id)
        {
            return mapper.Map<TableVM>(await GetAsync(id));
        }

        public async Task<List<TableVM>> GetTableVMListAsync()
        {
            return mapper.Map<List<TableVM>>(await GetAllAsync());
        }
        public async Task<IEnumerable<SelectListItem>> GetAllTables()
        {
            return (await this.GetTableVMListAsync()).Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();


        }
    }
}
