using AutoMapper;
using Szakdoga.Data;
using Szakdoga.Models;
using Szakdoga.Models.Food;

namespace Szakdoga.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Table, TableVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<FoodCreateVM, Food>().ReverseMap();
            CreateMap<FoodDetailVM, Food>().ReverseMap();
            CreateMap<FoodListVM, Food>().ReverseMap();
            CreateMap<FoodAllergyTypeVM, FoodAllergyType>().ReverseMap();
            CreateMap<FoodTypeVM, FoodType>().ReverseMap();
            CreateMap<FoodUpdateVM, Food>().ReverseMap();
            CreateMap<OrderCreateVM, Order>().ReverseMap();
        }
    }
}
