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
    public class FilmsGenresController : Controller
    {
        private readonly FilmContext _context;

        public FilmsGenresController(FilmContext context)
        {
            _context = context;
        }

        // GET: FilmsGenres
        public async Task<IActionResult> Index(string searchFilm, string searchGenre)
        {
            ViewData["FilterFilm"] = searchFilm;
            ViewData["FilterGenre"] = searchGenre;
            var filmContext = from c in _context.FilmsGenres.Include(f => f.Film).Include(f => f.Genre)
                              select c;
            if (!String.IsNullOrEmpty(searchFilm))
            {
                var fid = from f in _context.Films where f.Name.Contains(searchFilm) select f.ID;
                filmContext = filmContext.Where(f => fid.Contains(f.FilmID));
            }
            if (!String.IsNullOrEmpty(searchGenre))
            {
                var gid = from g in _context.Genres where g.Name.Contains(searchGenre) select g.ID;
                filmContext = filmContext.Where(f => gid.Contains(f.GenreID));
            }
            return View(await filmContext.ToListAsync());
        }

        // GET: FilmsGenres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmGenre = await _context.FilmsGenres
                .Include(f => f.Film)
                .Include(f => f.Genre)
                .FirstOrDefaultAsync(m => m.FilmGenreID == id);
            if (filmGenre == null)
            {
                return NotFound();
            }

            return View(filmGenre);
        }

        // GET: FilmsGenres/Create
        public IActionResult Create()
        {
            ViewData["FilmID"] = new SelectList(_context.Films, "ID", "Name");
            ViewData["GenreID"] = new SelectList(_context.Genres, "ID", "Name");
            return View();
        }

        // POST: FilmsGenres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmGenreID,GenreID,FilmID")] FilmGenre filmGenre)
        {
            if (ModelState.IsValid)
            {
                if (!(from fg in _context.FilmsGenres where fg.FilmID == filmGenre.FilmID && fg.GenreID == filmGenre.GenreID select fg).Any())
                {
                    _context.Add(filmGenre);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FilmID"] = new SelectList(_context.Films, "ID", "ID", filmGenre.FilmID);
            ViewData["GenreID"] = new SelectList(_context.Genres, "ID", "ID", filmGenre.GenreID);
            return View(filmGenre);
        }

        // GET: FilmsGenres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmGenre = await _context.FilmsGenres.FindAsync(id);
            if (filmGenre == null)
            {
                return NotFound();
            }
            ViewData["FilmID"] = new SelectList(_context.Films, "ID", "ID", filmGenre.FilmID);
            ViewData["GenreID"] = new SelectList(_context.Genres, "ID", "ID", filmGenre.GenreID);
            return View(filmGenre);
        }

        // POST: FilmsGenres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilmGenreID,GenreID,FilmID")] FilmGenre filmGenre)
        {
            if (id != filmGenre.FilmGenreID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmGenre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmGenreExists(filmGenre.FilmGenreID))
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
            ViewData["FilmID"] = new SelectList(_context.Films, "ID", "ID", filmGenre.FilmID);
            ViewData["GenreID"] = new SelectList(_context.Genres, "ID", "ID", filmGenre.GenreID);
            return View(filmGenre);
        }

        // GET: FilmsGenres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmGenre = await _context.FilmsGenres
                .Include(f => f.Film)
                .Include(f => f.Genre)
                .FirstOrDefaultAsync(m => m.FilmGenreID == id);
            if (filmGenre == null)
            {
                return NotFound();
            }

            return View(filmGenre);
        }

        // POST: FilmsGenres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filmGenre = await _context.FilmsGenres.FindAsync(id);
            _context.FilmsGenres.Remove(filmGenre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmGenreExists(int id)
        {
            return _context.FilmsGenres.Any(e => e.FilmGenreID == id);
        }
    }
}
