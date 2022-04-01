using Szakdoga.Contracts;
using Szakdoga.Data;

namespace Szakdoga.Repositories
{
    public class FoodAllergyTypeRepository : GenericRepository<FoodAllergyType>, IFoodAllergyTypeRepository
    {
        public FoodAllergyTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
