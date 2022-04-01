using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Szakdoga.Configurations;
using Szakdoga.Models;
using Szakdoga.Repositories.Interfaces;

namespace Szakdoga.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IOrderRepository orderRepository;

        public HomeController(ILogger<HomeController> logger, IMapper mapper, IEmployeeRepository employeeRepository, IOrderRepository orderRepository)
        {
            _logger = logger;
            this.mapper = mapper;
            this.employeeRepository = employeeRepository;
            this.orderRepository = orderRepository;

        }

        public async Task<IActionResult> Index()
        {

            return View(mapper.Map<List<OrderCreateVM>>(await orderRepository.GetAllAsync()));
        }
        public async Task<IActionResult> Admin()
        {
            return View(mapper.Map<List<EmployeeVM>>(await employeeRepository.GetAllAsync()));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}