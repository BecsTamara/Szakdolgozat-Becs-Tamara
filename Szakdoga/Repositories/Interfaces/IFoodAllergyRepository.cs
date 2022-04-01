using Szakdoga.Data;
using Szakdoga.Models.Food;

namespace Szakdoga.Contracts
{
    public interface IFoodAllergyRepository : IGenericRepository<FoodAllergy>
    {
        Task DeleteFoodAllergies(int foodId);

        Task AddFoodAllergies(FoodUpdateVM food);
    }
}
