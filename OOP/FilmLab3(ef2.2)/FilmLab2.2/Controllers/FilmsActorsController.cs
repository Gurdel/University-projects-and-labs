using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmLab2._2.Data;
using FilmLab2._2.Models;

namespace FilmLab2._2.Controllers
{
    public class FilmsActorsController : Controller
    {
        private readonly FilmContext _context;

        public FilmsActorsController(FilmContext context)
        {
            _context = context;
        }

        // GET: FilmsActors
        public async Task<IActionResult> Index(string searchFilm, string searchActor)
        {
            ViewData["FilterFilm"] = searchFilm;
            ViewData["FilterActor"] = searchActor;
            var filmContext = from c in _context.FilmsActors.Include(f => f.Actor).Include(f => f.Film)
                              select c;
            if (!String.IsNullOrEmpty(searchFilm))
            {
                var fid = from f in _context.Films where f.Name.Contains(searchFilm) select f.ID;
                filmContext = filmContext.Where(f => fid.Contains(f.FilmID));
            }
            if (!String.IsNullOrEmpty(searchActor))
            {
                var aid = from a in _context.Actors where a.Name.Contains(searchActor) select a.ID;
                filmContext = filmContext.Where(f => aid.Contains(f.ActorID));
            }
            return View(await filmContext.ToListAsync());
        }

        // GET: FilmsActors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmActor = await _context.FilmsActors
                .Include(f => f.Actor)
                .Include(f => f.Film)
                .FirstOrDefaultAsync(m => m.FilmActorID == id);
            if (filmActor == null)
            {
                return NotFound();
            }

            return View(filmActor);
        }

        // GET: FilmsActors/Create
        public IActionResult Create()
        {
            ViewData["ActorID"] = new SelectList(_context.Actors, "ID", "Name");
            ViewData["FilmID"] = new SelectList(_context.Films, "ID", "Name");
            return View();
        }

        // POST: FilmsActors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmActorID,ActorID,FilmID")] FilmActor filmActor)
        {
            if (ModelState.IsValid)
            {
                if (!(from fa in _context.FilmsActors where fa.FilmID == filmActor.FilmID && fa.ActorID == filmActor.ActorID select fa).Any())
                {
                    _context.Add(filmActor);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActorID"] = new SelectList(_context.Actors, "ID", "ID", filmActor.ActorID);
            ViewData["FilmID"] = new SelectList(_context.Films, "ID", "ID", filmActor.FilmID);
            return View(filmActor);
        }

        // GET: FilmsActors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmActor = await _context.FilmsActors.FindAsync(id);
            if (filmActor == null)
            {
                return NotFound();
            }
            ViewData["ActorID"] = new SelectList(_context.Actors, "ID", "ID", filmActor.ActorID);
            ViewData["FilmID"] = new SelectList(_context.Films, "ID", "ID", filmActor.FilmID);
            return View(filmActor);
        }

        // POST: FilmsActors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilmActorID,ActorID,FilmID")] FilmActor filmActor)
        {
            if (id != filmActor.FilmActorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmActor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmActorExists(filmActor.FilmActorID))
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
            ViewData["ActorID"] = new SelectList(_context.Actors, "ID", "ID", filmActor.ActorID);
            ViewData["FilmID"] = new SelectList(_context.Films, "ID", "ID", filmActor.FilmID);
            return View(filmActor);
        }

        // GET: FilmsActors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmActor = await _context.FilmsActors
                .Include(f => f.Actor)
                .Include(f => f.Film)
                .FirstOrDefaultAsync(m => m.FilmActorID == id);
            if (filmActor == null)
            {
                return NotFound();
            }

            return View(filmActor);
        }

        // POST: FilmsActors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filmActor = await _context.FilmsActors.FindAsync(id);
            _context.FilmsActors.Remove(filmActor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmActorExists(int id)
        {
            return _context.FilmsActors.Any(e => e.FilmActorID == id);
        }
    }
}
