using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlowerStore.Data;
using FlowerStore.Models;

namespace FlowerStore.Controllers
{
    public class FlowerdetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlowerdetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Flowerdetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flowerdetails.ToListAsync());
        }

        // GET: Flowerdetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowerdetails = await _context.Flowerdetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flowerdetails == null)
            {
                return NotFound();
            }

            return View(flowerdetails);
        }

        // GET: Flowerdetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flowerdetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Image,Name,Price,Quantity")] Flowerdetails flowerdetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flowerdetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flowerdetails);
        }

        // GET: Flowerdetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowerdetails = await _context.Flowerdetails.FindAsync(id);
            if (flowerdetails == null)
            {
                return NotFound();
            }
            return View(flowerdetails);
        }

        // POST: Flowerdetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Image,Name,Price,Quantity")] Flowerdetails flowerdetails)
        {
            if (id != flowerdetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flowerdetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlowerdetailsExists(flowerdetails.Id))
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
            return View(flowerdetails);
        }

        // GET: Flowerdetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowerdetails = await _context.Flowerdetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flowerdetails == null)
            {
                return NotFound();
            }

            return View(flowerdetails);
        }

        // POST: Flowerdetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flowerdetails = await _context.Flowerdetails.FindAsync(id);
            _context.Flowerdetails.Remove(flowerdetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlowerdetailsExists(int id)
        {
            return _context.Flowerdetails.Any(e => e.Id == id);
        }
    }
}
