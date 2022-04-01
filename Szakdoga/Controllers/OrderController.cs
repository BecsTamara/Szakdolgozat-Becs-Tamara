#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Szakdoga.Contracts;
using Szakdoga.Data;
using Szakdoga.Models;
using Szakdoga.Models.Food;
using Szakdoga.Models.Order;
using Szakdoga.Repositories.Interfaces;

namespace Szakdoga.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IFoodRepository foodRepository;
        private readonly ITableRepository tableRepository;
        private readonly IOrderRepository orderRepository;
        private readonly IOrderFoodsRepository orderfoodsRepository;


        public OrderController(ApplicationDbContext context, IMapper mapper,
            IFoodRepository foodRepository, ITableRepository tableRepository, IOrderRepository orderRepository, IOrderFoodsRepository orderfoodsRepository
         )
        {
            _context = context;
            this.mapper = mapper;
            this.foodRepository = foodRepository;
            this.tableRepository = tableRepository;
            this.orderRepository = orderRepository;
            this.orderfoodsRepository = orderfoodsRepository;
        }
        public async Task<IActionResult> CreateOrder()
        {
            OrderCreateVM orderVM = new OrderCreateVM();
            orderVM.FoodItems = await this.foodRepository.GetAllFoods();
            orderVM.TableItems = await this.tableRepository.GetAllTables();
            return View(orderVM);
        }

        [HttpPost]
        public async Task<string> GetFoodUnitPrice([FromBody] FoodGetPriceVM data)
        {
            data.FoodPrice = (await foodRepository.GetAsync(data.FoodId)).Price;
            return JsonConvert.SerializeObject(data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrder([FromBody] NewOrderVM data)
        {
            try
            {
                Order order = await orderRepository.AddAsync(new Order()
                {
                    Name = (await tableRepository.GetAsync(data.TableId)).Name,
                    TableId = data.TableId
                });
                foreach (var item in data.Foods)
                {
                    await orderfoodsRepository.AddAsync(new OrderFood()
                    {
                        FoodId = item.FoodId,
                        Description = item.Description,
                        Discount = item.Discount,
                        OrderId = order.Id,
                        Quantity = item.Quantity
                    });
                }
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
               
            }
           
        }

    }
}
