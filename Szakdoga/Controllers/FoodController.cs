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
using Szakdoga.Contracts;
using Szakdoga.Data;
using Szakdoga.Models;
using Szakdoga.Models.Food;

namespace Szakdoga.Controllers
{
    [Authorize]
    public class FoodController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IFoodRepository foodRepository;
        private readonly IFoodTypeRepository foodTypeRepository;
        private readonly IFoodAllergyTypeRepository foodAllergyTypeRepository;

        public FoodController(ApplicationDbContext context, IMapper mapper,
            IFoodRepository foodRepository,
            IFoodTypeRepository foodTypeRepository,
            IFoodAllergyTypeRepository foodAllergyTypeRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.foodRepository = foodRepository;
            this.foodTypeRepository = foodTypeRepository;
            this.foodAllergyTypeRepository = foodAllergyTypeRepository;
        }

        // GET: Foods
        public async Task<IActionResult> Index()
        {
            return View(await foodRepository.GetFoodVMListAsync());
        }

        // GET: Foods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var food = await foodRepository.GetFoodVMAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }
        // GET: Foods/Create
        public async Task<IActionResult> Create()
        {
            ViewData["AllergyType"] = new SelectList(await _context.FoodAllergyTypes.ToListAsync(), "Id", "Name");
            var model = new FoodCreateVM
            {
                FoodTypes = new SelectList(await foodTypeRepository.GetAllAsync(), "Id", "Name"),
                FoodAllergyTypes = new SelectList(await foodAllergyTypeRepository.GetAllAsync(), "Id", "Name")
            };
            return View(model);
        }
        // POST: Tables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FoodCreateVM food)
        {
            if (ModelState.IsValid)
            {
                await foodRepository.CreateFoodAsync(food);
                return RedirectToAction(nameof(Index));
            }
            return View(food);
        }
        public IActionResult CreateAllergy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAllergy(FoodAllergyTypeVM Allergy)
        {
            if (ModelState.IsValid)
            {
                var model = mapper.Map<FoodAllergyType>(Allergy);
                await foodAllergyTypeRepository.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(Allergy);
        }
        public IActionResult CreateType()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateType(FoodTypeVM Type)
        {
            if (ModelState.IsValid)
            {
                var model = mapper.Map<FoodType>(Type);
                await foodTypeRepository.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(Type);
        }
        // GET: Foods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table = await foodRepository.GetFoodUpdateVMAsync(id);
            if (table == null)
            {
                return NotFound();
            }
            var foodVM = mapper.Map<FoodUpdateVM>(table);
            //foodVM.FoodTypes
            return View(foodVM);
        }

        // POST: Foods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FoodUpdateVM foodVM)
        {
            if (id != foodVM.Id)
            {
                return NotFound();
            }
            foodVM.CreatedUserId = this.HttpContext.User.Claims.Single(x => x.Type == ClaimTypes.NameIdentifier).Value;
            ModelState.Clear();
            TryValidateModel(foodVM);
            if (ModelState.IsValid)
            {
               
                try
                {
                    await foodRepository.UpdateFoodAsync(foodVM);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await foodRepository.Exists(foodVM.Id.Value))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return Redirect("/Food");
        }

        // GET: Foods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await foodRepository.GetAsync(id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // POST: Foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food = await foodRepository.GetAsync(id);
            await foodRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
