using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Areas.admin.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace _21_11_2021.Areas.admin.Controllers
{
    [Area("admin")]
    public class FootshowsController : Controller
    {
        private readonly DPContext _context;

        public FootshowsController(DPContext context)
        {
            _context = context;
        }

        // GET: admin/Footshows
        public async Task<IActionResult> Index()
        {
            return View(await _context.footshows.ToListAsync());
        }

        // GET: admin/Footshows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footshows = await _context.footshows
                .FirstOrDefaultAsync(m => m.IdFootShow == id);
            if (footshows == null)
            {
                return NotFound();
            }

            return View(footshows);
        }

        // GET: admin/Footshows/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/Footshows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFootShow,Hinh,TrangThai")] Footshows footshows, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footshows);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/footshow", footshows.IdFootShow + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                footshows.Hinh = footshows.IdFootShow + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(footshows);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footshows);
        }

        // GET: admin/Footshows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var footshows = await _context.footshows.FindAsync(id);
            if (footshows == null)
            {
                return NotFound();
            }
            return View(footshows);
        }

        // POST: admin/Footshows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Hinh,TrangThai")] Footshows footshows, IFormFile ful)
        {
            var foot = _context.footshows.Find(id);
            if (id != foot.IdFootShow)
            {
                return NotFound();
            }
            //them hinh
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/footshow", foot.IdFootShow + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await ful.CopyToAsync(stream);
            }
            foot.Hinh = foot.IdFootShow + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
            //
            if (footshows.Hinh == null)
            {
                foot.Hinh = footshows.Hinh;
            }
            if (ModelState.IsValid)
            {
                try
                {
                    foot.TrangThai = footshows.TrangThai;
                    _context.Update(foot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FootshowsExists(footshows.IdFootShow))
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
            return View(footshows);
        }

        // GET: admin/Footshows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footshows = await _context.footshows
                .FirstOrDefaultAsync(m => m.IdFootShow == id);
            if (footshows == null)
            {
                return NotFound();
            }

            return View(footshows);
        }

        // POST: admin/Footshows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var footshows = await _context.footshows.FindAsync(id);
            _context.footshows.Remove(footshows);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FootshowsExists(int id)
        {
            return _context.footshows.Any(e => e.IdFootShow == id);
        }
    }
}
