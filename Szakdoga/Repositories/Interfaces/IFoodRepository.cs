using Microsoft.AspNetCore.Mvc.Rendering;
using Szakdoga.Data;
using Szakdoga.Models;
using Szakdoga.Models.Food;

namespace Szakdoga.Contracts
{
    public interface IFoodRepository : IGenericRepository<Food>
    {
        Task<List<FoodListVM>> GetFoodVMListAsync();
        Task<FoodDetailVM?> GetFoodVMAsync(int? id);
        Task CreateFoodAsync(FoodCreateVM foodVM);
        Task<FoodUpdateVM?> GetFoodUpdateVMAsync(int? id);
        Task UpdateFoodAsync(FoodUpdateVM foodVM);
        Task<IEnumerable<SelectListItem>> GetAllFoods();

    }
}
