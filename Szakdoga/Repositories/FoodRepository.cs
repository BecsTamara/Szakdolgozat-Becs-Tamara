using AutoMapper;
using Szakdoga.Contracts;
using Szakdoga.Data;
using Szakdoga.Models;
using Szakdoga.Models.Food;
using Szakdoga.Configurations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Szakdoga.Repositories
{
    public class FoodRepository : GenericRepository<Food>, IFoodRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IFoodTypeRepository foodTypeRepository;
        private readonly IFoodAllergyTypeRepository foodAllergyTypeRepository;
        private readonly IFoodAllergyRepository foodAllergyRepository;

        public FoodRepository(ApplicationDbContext context, IMapper mapper,
            IFoodTypeRepository foodTypeRepository,
            IFoodAllergyTypeRepository foodAllergyTypeRepository,
            IFoodAllergyRepository foodAllergyRepository) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.foodTypeRepository = foodTypeRepository;
            this.foodAllergyTypeRepository = foodAllergyTypeRepository;
            this.foodAllergyRepository = foodAllergyRepository;
        }

        public async Task CreateFoodAsync(FoodCreateVM foodVM)
        {
            try
            {
                Food food = new Food
                {
                    Name = foodVM.Name,
                    FoodTypeId = foodVM.FoodTypeId,
                    Adult = foodVM.Adult,
                    Price = foodVM.Price,
                    Description = foodVM.Description,
                    Enabled = foodVM.Enabled
                };
                await AddAsync(food);
                foreach (var item in foodVM.Allergies)
                {
                    await foodAllergyRepository.AddAsync(new FoodAllergy
                    {
                        FoodAllergyTypeId = item,
                        FoodId = food.Id,
                    });
                }
            }
            catch (Exception)
            {
            }
        }

        public async Task<FoodDetailVM?> GetFoodVMAsync(int? id)
        {
            var food = await GetAsync(id);
            var vm = mapper.Map<FoodDetailVM>(food);
            vm.FoodType = await foodTypeRepository.GetAsync(food.FoodTypeId);
            vm.Allergies = new List<FoodAllergyType>();
            foreach (var item in await foodAllergyTypeRepository.GetAllAsync())
            {
                if (context.FoodAllergies.Where(x=>x.FoodId == food.Id && x.FoodAllergyTypeId == item.Id).Any())
                {
                    vm.Allergies.Add(item);
                }
            }
            return vm;
        }
        public async Task<FoodUpdateVM?> GetFoodUpdateVMAsync(int? id)
        {
            var food = await GetAsync(id);
            var vm = mapper.Map<FoodUpdateVM>(food);
            //vm.FoodTypeId = await foodTypeRepository.GetAsync(food.FoodTypeId);
            vm.FoodTypes = (await foodTypeRepository.GetAllAsync()).Select(i => i.Id).ToSelectList(1);
            vm.Allergies = new List<int>();
            vm.AllAllergies = context.FoodAllergyTypes.OrderBy(x => x.Name).Select(x => x.Id);
            vm.Allergies = context.FoodAllergies.Where(x => x.FoodId == food.Id).Select(x => x.FoodAllergyTypeId).ToList();
          /*  foreach (var item in await foodAllergyTypeRepository.GetAllAsync())
            {
                if (context.FoodAllergies.Any(x => x.FoodId == food.Id && x.FoodAllergyTypeId == item.Id))
                {
                    vm.Allergies.Add(item.Id);
                }
            }*/
            return vm;
        }

        public async Task UpdateFoodAsync(FoodUpdateVM foodVM)
        {
            var food = mapper.Map<Food>(foodVM);
            await this.UpdateAsync(food);
            await this.foodAllergyRepository.AddFoodAllergies(foodVM);
        }

        public async Task<List<FoodListVM>> GetFoodVMListAsync()
        {
            var list = new List<FoodListVM>();
            foreach (var item in await GetAllAsync())
            {
                var vm = mapper.Map<FoodListVM>(item);
                vm.FoodType = await foodTypeRepository.GetAsync(item.FoodTypeId);
                list.Add(vm);
            }
            return list;
        }
        public async Task< IEnumerable<SelectListItem>> GetAllFoods()
        {
            return (await this.GetFoodVMListAsync()).Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();


        }

    }
}
