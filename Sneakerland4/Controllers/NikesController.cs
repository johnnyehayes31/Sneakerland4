#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sneakerland4.Data;

namespace Sneakerland4.Controllers
{
    public class NikesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NikesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Nikes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nike.ToListAsync());
        }

        // GET: Nikes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nikes = await _context.Nike
                .FirstOrDefaultAsync(m => m.NikeId == id);
            if (nikes == null)
            {
                return NotFound();
            }

            return View(nikes);
        }

        // GET: Nikes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NikeId,NikeName,NikeClothing,NikeShoes")] Nikes nikes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nikes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nikes);
        }

        // GET: Nikes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nikes = await _context.Nike.FindAsync(id);
            if (nikes == null)
            {
                return NotFound();
            }
            return View(nikes);
        }

        // POST: Nikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NikeId,NikeName,NikeClothing,NikeShoes")] Nikes nikes)
        {
            if (id != nikes.NikeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nikes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NikesExists(nikes.NikeId))
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
            return View(nikes);
        }

        // GET: Nikes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nikes = await _context.Nike
                .FirstOrDefaultAsync(m => m.NikeId == id);
            if (nikes == null)
            {
                return NotFound();
            }

            return View(nikes);
        }

        // POST: Nikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nikes = await _context.Nike.FindAsync(id);
            _context.Nike.Remove(nikes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NikesExists(int id)
        {
            return _context.Nike.Any(e => e.NikeId == id);
        }
    }
}
