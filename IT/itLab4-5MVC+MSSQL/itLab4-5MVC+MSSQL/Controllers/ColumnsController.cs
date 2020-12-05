using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using itLab4_5MVC_MSSQL;
using System.IO;

namespace itLab4_5MVC_MSSQL.Controllers
{
    public class ColumnsController : Controller
    {
        private readonly itSUTBDContext _context;

        public ColumnsController(itSUTBDContext context)
        {
            _context = context;
        }

        // GET: Columns
        public async Task<IActionResult> Index()
        {
            var itSUTBDContext = _context.Column.Include(c => c.Table).Include(d => d.Data);
            ViewBag.CorRowId = _context.Row.Select(r => r.Id);
            return View(await itSUTBDContext.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string textToSearch)
        {
            if (string.IsNullOrEmpty(textToSearch))
            {
                var itSUTBDContext1 = _context.Column.Include(c => c.Table).Include(d => d.Data);
                ViewBag.CorRowId = _context.Row.Select(r => r.Id);
                return View(await itSUTBDContext1.ToListAsync());
            }
            var correctData = _context.Data.Where(d => d.Data1.Contains(textToSearch));
            var correctRowId = correctData.Select(r => r.RowId).Distinct();
            var itSUTBDContext = _context.Column.Include(d => d.Data);
            var itSUTBDContext2 = _context.Column.Include(d => d.Data.Where(r => correctRowId.Contains(r.RowId)));
            ViewBag.CorRowId = correctRowId;
            return View(await itSUTBDContext.ToListAsync());
        }

        // GET: Columns/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<string> paths = _context.Data.Where(r => r.RowId == id).Where(c => c.Column.Type == "path").Select(d => d.Data1).ToList();
            ViewBag.Paths = paths;
            List<string> texts = new List<string>();
            if (paths[0] != null)
            {
                foreach (string s in paths)
                {
                    StreamReader sr = new StreamReader(s, System.Text.Encoding.UTF8);
                    texts.Add(sr.ReadToEnd());
                    sr.Close();
                }
            }
            ViewBag.Texts = texts;
            return View();
        }

        // GET: Columns/Create
        public IActionResult Create()
        {
            ViewData["TableId"] = new SelectList(_context.Table, "Id", "Id");
            return View();
        }

        // POST: Columns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,TableId")] Column column)
        {
            if (ModelState.IsValid)
            {
                _context.Add(column);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TableId"] = new SelectList(_context.Table, "Id", "Id", column.TableId);
            return View(column);
        }

        // GET: Columns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var column = await _context.Column.FindAsync(id);
            if (column == null)
            {
                return NotFound();
            }
            ViewData["TableId"] = new SelectList(_context.Table, "Id", "Id", column.TableId);
            return View(column);
        }

        // POST: Columns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,TableId")] Column column)
        {
            if (id != column.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(column);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColumnExists(column.Id))
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
            ViewData["TableId"] = new SelectList(_context.Table, "Id", "Id", column.TableId);
            return View(column);
        }

        // GET: Columns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var column = await _context.Column
                .Include(c => c.Table)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (column == null)
            {
                return NotFound();
            }

            return View(column);
        }

        // POST: Columns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var column = await _context.Column.FindAsync(id);
            _context.Column.Remove(column);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColumnExists(int id)
        {
            return _context.Column.Any(e => e.Id == id);
        }
    }
}
