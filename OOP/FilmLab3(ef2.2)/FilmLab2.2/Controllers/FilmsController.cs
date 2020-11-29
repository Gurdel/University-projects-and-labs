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
    public class FilmsController : Controller
    {
        private readonly FilmContext _context;

        public FilmsController(FilmContext context)
        {
            _context = context;
        }

        // GET: Films
        public async Task<IActionResult> Index(string searchName, int? searchYear, 
            string searchProducer, string searchActor, string searchGenre)
        {
            ViewData["FilterName"] = searchName;
            ViewData["FilterYear"] = searchYear;
            ViewData["FilterProducer"] = searchProducer;
            ViewData["FilterActor"] = searchActor;
            ViewData["FilterGenre"] = searchGenre;

            var films = from f in _context.Films
                .Include(p => p.Producer)
                .Include(fg => fg.FilmsGenres).ThenInclude(g => g.Genre)
                .Include(fa => fa.FilmsActors).ThenInclude(a => a.Actor)
                        select f;
            if (!String.IsNullOrEmpty(searchName))
            {
                films = films.Where(f => f.Name.Contains(searchName));
            }
            if (searchYear != null)
            {
                films = films.Where(f => f.Year == searchYear);
            }
            if (!String.IsNullOrEmpty(searchProducer))
            {
                films = films.Where(f => f.Producer.Name.Contains(searchProducer));
            }
            if (!String.IsNullOrEmpty(searchActor))
            {
                films = films.Where(f => f.FilmsActors.Any(a => a.Actor.Name.Contains(searchActor)));
            }
            if (!String.IsNullOrEmpty(searchGenre))
            {
                films = films.Where(f => f.FilmsGenres.Any(g => g.Genre.Name.Contains(searchGenre)));
            }

            return View(await films.AsNoTracking().ToListAsync());
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .Include(p => p.Producer)
                .Include(fg => fg.FilmsGenres).ThenInclude(g => g.Genre)
                .Include(fa => fa.FilmsActors).ThenInclude(a => a.Actor)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Films/Create
        public IActionResult Create(int? id, bool? saveChangesError = false)
        {
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "Name");
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка створення фільму: такий фільм уже є!";
            }
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("Name,Year,ProducerID")] Film film)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if ((from f in _context.Films where f.Name == film.Name && f.Year == film.Year select f).Any())
                    {
                        return RedirectToAction(nameof(Create), new { id = film.ID, saveChangesError = true });
                    }
                    _context.Add(film);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Помилка створення фільму!");
                return RedirectToAction(nameof(Create), new { id = film.ID, saveChangesError = true });
            }
            return View(film);
        }

        // GET: Films/Edit/5
        public async Task<IActionResult> Edit(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Films.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка редагування фільму: такий фільм уже є!";
            }
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "Name");
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id, [Bind("ID,Name,Year,ProducerID")] Film film)
        {
            if (id != film.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if ((from f in _context.Films where f.ID != film.ID && f.Name == film.Name && f.Year == film.Year select f).Any())
                    {
                        return RedirectToAction(nameof(Edit), new { id = film.ID, saveChangesError = true });
                    }
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return RedirectToAction(nameof(Edit), new { id = film.ID, saveChangesError = true });
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // GET: Films/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .Include(p => p.Producer)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (film == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка видалення фільму!";
            }

            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Films.FindAsync(id);
            if (film == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.Films.Remove(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool FilmExists(int id)
        {
            return _context.Films.Any(e => e.ID == id);
        }
    }
}
