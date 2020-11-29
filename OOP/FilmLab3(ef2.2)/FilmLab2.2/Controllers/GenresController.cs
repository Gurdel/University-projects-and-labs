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
    public class GenresController : Controller
    {
        private readonly FilmContext _context;

        public GenresController(FilmContext context)
        {
            _context = context;
        }

        // GET: Genres
        public async Task<IActionResult> Index(string searchName)
        {
            ViewData["FilterName"] = searchName;
            var genres = from g in _context.Genres
                         select g;
            if (!String.IsNullOrEmpty(searchName))
            {
                genres = genres.Where(g => g.Name.Contains(searchName));
            }
            return View(await genres.AsNoTracking().ToListAsync());
        }

        // GET: Genres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = await _context.Genres
                .FirstOrDefaultAsync(m => m.ID == id);
            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        // GET: Genres/Create
        public IActionResult Create(int? id, bool? saveChangesError = false)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка створення жанру: такий жанр уже є!";
            }
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("Name")] Genre genre)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if ((from g in _context.Genres where g.Name == genre.Name select g).Any())
                    {
                        return RedirectToAction(nameof(Create), new { id = genre.ID, saveChangesError = true });
                    }
                    _context.Add(genre);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Помилка створення жанру!");
                return RedirectToAction(nameof(Create), new { id = genre.ID, saveChangesError = true });
            }
            return View(genre);
        }

        // GET: Genres/Edit/5
        public async Task<IActionResult> Edit(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = await _context.Genres.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка редагування жанру: такий жанр уже є!";
            }
            return View(genre);
        }

        // POST: Genres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var genre = await _context.Genres.FirstOrDefaultAsync(g => g.ID == id);
            if (await TryUpdateModelAsync<Genre>(
                genre,
                "",
                g => g.Name))
            {
                try
                {
                    if ((from g in _context.Genres where g.Name == genre.Name select g).Any())
                    {
                        return RedirectToAction(nameof(Edit), new { id = genre.ID, saveChangesError = true });
                    }
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Помилка редагування інформації про жанр");
                    return RedirectToAction(nameof(Edit), new { id = genre.ID, saveChangesError = true });
                }
            }
            return View(genre);
        }

        // GET: Genres/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = await _context.Genres
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (genre == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка видалення жанру: існує фільм із цим жанром!";
            }

            return View(genre);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                if ((from fg in _context.FilmsGenres where fg.GenreID == genre.ID select fg).Any())
                    return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
                _context.Genres.Remove(genre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool GenreExists(int id)
        {
            return _context.Genres.Any(e => e.ID == id);
        }
    }
}
