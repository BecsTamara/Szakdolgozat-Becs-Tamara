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

namespace Szakdoga.Controllers
{
    [Authorize]
    public class TableController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly ITableRepository tableRepository;

        public TableController(ApplicationDbContext context , IMapper mapper,
            ITableRepository tableRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.tableRepository = tableRepository;
        }

        // GET: Tables
        public async Task<IActionResult> Index()
        {
            return View(await tableRepository.GetTableVMListAsync());
        }

        // GET: Tables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var table = await tableRepository.GetTableVMAsync((int)id);
            if (table == null)
            {
                return NotFound();
            }
            return View(table);
        }

        // GET: Tables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TableVM table)
        {
            
            if (ModelState.IsValid)
            {
              if ( await tableRepository.CreateTableAsync(table))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(table);
                }
            }
            return View(table);
        }

        // GET: Tables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var table = await tableRepository.GetTableVMAsync((int)id);
            if (table == null)
            {
                return NotFound();
            }
           
            return View(table);
        }

        // POST: Tables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,TableVM tableVM)
        {
            if (id != tableVM.Id)
            {
                return NotFound();
            }

            tableVM.CreatedUserId = this.HttpContext.User.Claims.Single(x => x.Type == ClaimTypes.NameIdentifier).Value;
            ModelState.Clear();
            TryValidateModel(tableVM);
            if (ModelState.IsValid)
            {
                var table = mapper.Map<Table>(tableVM);
                try
                {
                    await tableRepository.UpdateAsync(table);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableExists(table.Id))
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
            return View(tableVM);
        }

        // GET: Tables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table = await tableRepository.GetAsync(id);
            if (table == null)
            {
                return NotFound();
            }

            return View(table);
        }

        // POST: Tables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var table = await tableRepository.GetAsync(id);
            await tableRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        private bool TableExists(int id)
        {
            return _context.Tables.Any(e => e.Id == id);
        }
    }
}
