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
    public class ProducersController : Controller
    {
        private readonly FilmContext _context;

        public ProducersController(FilmContext context)
        {
            _context = context;
        }

        // GET: Producers
        public async Task<IActionResult> Index(string searchName, int? searchBirth, int? searchDeath)
        {
            ViewData["FilterName"] = searchName;
            ViewData["FilterBirth"] = searchBirth;
            ViewData["FilterDeath"] = searchDeath;

            var producers = from p in _context.Producers
                         select p;
            if (!String.IsNullOrEmpty(searchName))
            {
                producers = producers.Where(p => p.Name.Contains(searchName));
            }
            if (searchBirth != null)
            {
                producers = producers.Where(p => p.Birth == searchBirth);
            }
            if (searchDeath != null)
            {
                producers = producers.Where(p => p.Death == searchDeath);
            }

            return View(await producers.AsNoTracking().ToListAsync());
        }

        // GET: Producers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        // GET: Producers/Create
        public IActionResult Create(int? id, bool? saveChangesError = false, bool? validationError = false)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка створення продюсера: такий продюсер уже є!";
            }
            if (validationError.GetValueOrDefault())
            {
                ViewData["ValidationErrorMessage"] =
                    "Помилка створення продюсера: некоректні роки!";
            }
            return View();
        }

        // POST: Producers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("Name,Birth,Death")] Producer producer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if ((from p in _context.Producers where p.Name == producer.Name && p.Birth == producer.Birth && p.Death == producer.Death select p).Any())
                    {
                        return RedirectToAction(nameof(Create), new { id = producer.ID, saveChangesError = true });
                    }
                    if (producer.Death != null && producer.Death < producer.Birth)
                        return RedirectToAction(nameof(Create), new { id = producer.ID, validationError = true });
                    _context.Add(producer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Помилка створення продюсера!");
                return RedirectToAction(nameof(Create), new { id = producer.ID, saveChangesError = true });
            }
            return View(producer);
        }

        // GET: Producers/Edit/5
        public async Task<IActionResult> Edit(int? id, bool? saveChangesError = false, bool? validationError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка редагування продюсера: такий продюсер уже є!";
            }
            if (validationError.GetValueOrDefault())
            {
                ViewData["ValidationErrorMessage"] =
                    "Помилка редагування продюсера: некоректні роки!";
            }
            return View(producer);
        }

        // POST: Producers/Edit/5
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
            var producer = await _context.Producers.FirstOrDefaultAsync(p => p.ID == id);
            if (await TryUpdateModelAsync<Producer>(
                producer,
                "",
                p => p.Name, p => p.Birth, p => p.Death))
            {
                try
                {
                    if ((from p in _context.Producers where p.Name == producer.Name && p.Birth == producer.Birth && p.Death == producer.Death select p).Any())
                    {
                        return RedirectToAction(nameof(Edit), new { id = producer.ID, saveChangesError = true });
                    }
                    if (producer.Death != null && producer.Death < producer.Birth)
                        return RedirectToAction(nameof(Edit), new { id = producer.ID, validationError = true });
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Помилка редагування інформації про продюсера");
                    return RedirectToAction(nameof(Edit), new { id = producer.ID, saveChangesError = true });
                }
            }
            return View(producer);
        }

        // GET: Producers/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (producer == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Помилка видалення продюсера: у продюсера є фільми!";
            }

            return View(producer);
        }

        // POST: Producers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producer = await _context.Producers.FindAsync(id);

            if (producer == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                if ((from f in _context.Films where f.ProducerID == producer.ID select f).Any())
                    return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
                _context.Producers.Remove(producer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool ProducerExists(int id)
        {
            return _context.Producers.Any(e => e.ID == id);
        }
    }
}
