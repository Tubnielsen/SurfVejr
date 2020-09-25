using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Surfvejr.Data;
using Surfvejr.Models;

namespace Surfvejr.Controllers
{
    public class SurfSpotsController : Controller
    {
        private readonly SurfsUpContext _context;

        public SurfSpotsController(SurfsUpContext context)
        {
            _context = context;
        }

        // GET: SurfSpots
        public async Task<IActionResult> Index()
        {
            return View(await _context.SurfSpots.ToListAsync());
        }

        // GET: SurfSpots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfSpot = await _context.SurfSpots
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfSpot == null)
            {
                return NotFound();
            }

            return View(surfSpot);
        }

        // GET: SurfSpots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SurfSpots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,latitude,longitude")] SurfSpot surfSpot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surfSpot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(surfSpot);
        }

        // GET: SurfSpots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfSpot = await _context.SurfSpots.FindAsync(id);
            if (surfSpot == null)
            {
                return NotFound();
            }
            return View(surfSpot);
        }

        // POST: SurfSpots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,latitude,longitude")] SurfSpot surfSpot)
        {
            if (id != surfSpot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surfSpot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurfSpotExists(surfSpot.Id))
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
            return View(surfSpot);
        }

        // GET: SurfSpots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfSpot = await _context.SurfSpots
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfSpot == null)
            {
                return NotFound();
            }

            return View(surfSpot);
        }

        // POST: SurfSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surfSpot = await _context.SurfSpots.FindAsync(id);
            _context.SurfSpots.Remove(surfSpot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurfSpotExists(int id)
        {
            return _context.SurfSpots.Any(e => e.Id == id);
        }
    }
}
