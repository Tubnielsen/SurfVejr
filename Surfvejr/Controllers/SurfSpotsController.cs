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
                .Include(s => s.SpotData)
                .AsNoTracking()
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
        public async Task<IActionResult> Create([Bind("Name,Latitude,Longitude")] SurfSpot surfSpot)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(surfSpot);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException)
            {
                //Error log.
                ModelState.AddModelError("", "Unable to save create new entry.");
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
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var SurfSpotToUpdate = await _context.SurfSpots.FirstOrDefaultAsync(s => s.Id == id);
            if (await TryUpdateModelAsync<SurfSpot>(
                SurfSpotToUpdate,
                "",
                s => s.Name, s => s.Latitude, s => s.Longitude))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException)
                {
                    //Error log
                    ModelState.AddModelError("", "Unable to edit surf spot.");
                }
            }
            return View(SurfSpotToUpdate);
        }

        // GET: SurfSpots/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfSpot = await _context.SurfSpots
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfSpot == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] = "Failed to delete.";
            }

            return View(surfSpot);
        }

        // POST: SurfSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surfSpot = await _context.SurfSpots.FindAsync(id);
            if (surfSpot == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.SurfSpots.Remove(surfSpot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException)
            {
                //Can use the exception to log an error.
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool SurfSpotExists(int id)
        {
            return _context.SurfSpots.Any(e => e.Id == id);
        }
    }
}
