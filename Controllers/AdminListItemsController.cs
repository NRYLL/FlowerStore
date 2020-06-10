using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlowerStore.Data;
using FlowerStore.Models;
using Microsoft.AspNetCore.Authorization;

namespace FlowerStore.Controllers
{
    [Authorize(Roles = "CanManageFlower")]
    public class AdminListItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminListItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminListItems

        public async Task<IActionResult> Index()
        {
            return View(await _context.Flower.ToListAsync());
        }

        // GET: AdminListItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminListItem = await _context.Flower
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminListItem == null)
            {
                return NotFound();
            }

            return View(adminListItem);
        }

        // GET: AdminListItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminListItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Image,price,Quantity")] Flower adminListItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminListItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminListItem);
        }

        // GET: AdminListItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminListItem = await _context.Flower.FindAsync(id);
            if (adminListItem == null)
            {
                return NotFound();
            }
            return View(adminListItem);
        }

        // POST: AdminListItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Image,price,Quantity")] Flower adminListItem)
        {
            if (id != adminListItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminListItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminListItemExists(adminListItem.Id))
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
            return View(adminListItem);
        }

        // GET: AdminListItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminListItem = await _context.Flower
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminListItem == null)
            {
                return NotFound();
            }

            return View(adminListItem);
        }

        // POST: AdminListItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminListItem = await _context.Flower.FindAsync(id);
            _context.Flower.Remove(adminListItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminListItemExists(int id)
        {
            return _context.Flower.Any(e => e.Id == id);
        }
    }
}
