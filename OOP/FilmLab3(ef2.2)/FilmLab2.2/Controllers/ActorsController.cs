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
    public class ActorsController : Controller
    {
        private readonly FilmContext _context;

        public ActorsController(FilmContext context)
        {
            _context = context;
        }

        // GET: Actors
        public async Task<IActionResult> Index(string searchName, int? searchBirth, int? searchDeath)
        {
            ViewData["FilterName"] = searchName;
            ViewData["FilterBirth"] = searchBirth;
            ViewData["FilterDeath"] = searchDeath;

            var actors = from a in _context.Actors
                         select a;
            if (!String.IsNullOrEmpty(searchName))
            {
                actors = actors.Where(a => a.Name.Contains(searchName));
            }
            if (searchBirth != null)
            {
                actors = actors.Where(a => a.Birth == searchBirth);
            }
            if (searchDeath != null)
            {
                actors = actors.Where(a => a.Death == searchDeath);
            }

            return View(await actors.AsNoTracking().ToListAsync());
        }

        // GET: Actors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.Actors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // GET: Actors/Create
        public IActionResult Create(int? id, bool? saveChangesError = false, bool? validationError = false)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка створення актора: такий актор уже є!";
            }
            if (validationError.GetValueOrDefault())
            {
                ViewData["ValidationErrorMessage"] =
                    "Помилка створення актора: некоректні роки!";
            }
            return View();
        }

        // POST: Actors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("Name,Birth,Death")] Actor actor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if ((from a in _context.Actors where a.Name == actor.Name && a.Birth == actor.Birth && a.Death == actor.Death select a).Any()) 
                    {
                        return RedirectToAction(nameof(Create), new { id = actor.ID, saveChangesError = true });
                    }
                    if (actor.Death != null && actor.Death < actor.Birth)
                        return RedirectToAction(nameof(Create), new { id = actor.ID, validationError = true });
                    _context.Add(actor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Помилка створення актора!");
                return RedirectToAction(nameof(Create), new { id = actor.ID, saveChangesError = true });
            }
            return View(actor);
        }

        // GET: Actors/Edit/5
        public async Task<IActionResult> Edit(int? id, bool? saveChangesError = false, bool? validationError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.Actors.FindAsync(id);
            if (actor == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка редагування актора: такий актор уже є!";
            }
            if (validationError.GetValueOrDefault())
            {
                ViewData["ValidationErrorMessage"] =
                    "Помилка редагування актора: некоректні роки!";
            }
            return View(actor);
        }

        // POST: Actors/Edit/5
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
            var actor = await _context.Actors.FirstOrDefaultAsync(a => a.ID == id);
            
            if (await TryUpdateModelAsync<Actor>(
                actor,
                "",
                a => a.Name, a => a.Birth, a => a.Death))
            {
                try
                {
                    if ((from a in _context.Actors where a.Name == actor.Name && a.Birth == actor.Birth && a.Death == actor.Death select a).Any())
                    {
                        return RedirectToAction(nameof(Edit), new { id = actor.ID, saveChangesError = true });
                    }
                    if (actor.Death != null && actor.Death < actor.Birth)
                        return RedirectToAction(nameof(Edit), new { id = actor.ID, validationError = true });
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Помилка редагування інформації про актора");
                    return RedirectToAction(nameof(Edit), new { id = actor.ID, saveChangesError = true });
                }
            }
            return View(actor);
        }

        // GET: Actors/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.Actors
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (actor == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка видалення актора: існує фільм із цим актором!";
            }

            return View(actor);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await _context.Actors.FindAsync(id);
            if (actor == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                if ((from fa in _context.FilmsActors where fa.ActorID == actor.ID select fa).Any())
                    return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
                _context.Actors.Remove(actor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool ActorExists(int id)
        {
            return _context.Actors.Any(e => e.ID == id);
        }
    }
}
