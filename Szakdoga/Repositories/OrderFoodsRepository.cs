using AutoMapper;
using Szakdoga.Contracts;
using Szakdoga.Data;
using Szakdoga.Models;
using Szakdoga.Models.Food;
using Szakdoga.Configurations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Szakdoga.Repositories.Interfaces;

namespace Szakdoga.Repositories
{
    public class OrderFoodsRepository : GenericRepository<OrderFood>, IOrderFoodsRepository
    {
        public OrderFoodsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
