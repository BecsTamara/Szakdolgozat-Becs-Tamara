using Szakdoga.Contracts;
using Szakdoga.Data;
using Szakdoga.Models.Food;

namespace Szakdoga.Repositories
{
    public class FoodAllergyRepository : GenericRepository<FoodAllergy>, IFoodAllergyRepository
    {
        private ApplicationDbContext context;
        public FoodAllergyRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task AddFoodAllergies(FoodUpdateVM food)
        {
            await this.DeleteFoodAllergies(food.Id.Value);
            foreach(int alId in food.Allergies)
            {
                context.FoodAllergies.Add(new FoodAllergy()
                {
                    FoodId = food.Id.Value,
                    FoodAllergyTypeId = alId
                });
            }
            await context.SaveChangesAsync();
        }

        public async Task DeleteFoodAllergies(int foodId)
        {
            if (context.FoodAllergies.Any(x => x.FoodId == foodId)) {
                context.FoodAllergies.RemoveRange(context.FoodAllergies.Where(x => x.FoodId == foodId));
                await context.SaveChangesAsync();
            }
        }


    }
}
