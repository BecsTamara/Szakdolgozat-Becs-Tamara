using Szakdoga.Contracts;
using Szakdoga.Data;

namespace Szakdoga.Repositories
{
    public class FoodTypeRepository : GenericRepository<FoodType>, IFoodTypeRepository
    {
        public FoodTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
