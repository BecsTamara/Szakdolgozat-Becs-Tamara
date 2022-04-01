using Szakdoga.Data;
using Szakdoga.Repositories.Interfaces;

namespace Szakdoga.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
