using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Areas.admin.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace _21_11_2021.Areas.admin.Controllers
{
    [Area("admin")]
    public class TinTucsController : Controller
    {
        private readonly DPContext _context;

        public TinTucsController(DPContext context)
        {
            _context = context;
        }

        // GET: admin/TinTucs
        public async Task<IActionResult> Index()
        {
            return View(await _context.tinTucs.ToListAsync());
        }

        // GET: admin/TinTucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.tinTucs
                .FirstOrDefaultAsync(m => m.MaTinTuc == id);
            if (tinTuc == null)
            {
                return NotFound();
            }

            return View(tinTuc);
        }

        // GET: admin/TinTucs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/TinTucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTinTuc,TenTinTuc,Hinh,ChiTiet,NoiBat,TrangThai,MoTa")] TinTuc tinTuc, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tinTuc);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/tintuc", tinTuc.MaTinTuc + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                tinTuc.Hinh = tinTuc.MaTinTuc + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(tinTuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tinTuc);
        }

        // GET: admin/TinTucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.tinTucs.FindAsync(id);
            if (tinTuc == null)
            {
                return NotFound();
            }
            return View(tinTuc);
        }

        // POST: admin/TinTucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TenTinTuc,Hinh,ChiTiet,NoiBat,TrangThai,MoTa")] TinTuc tinTuc, IFormFile ful)
        {
            var tintuc = _context.tinTucs.Find(id);
            if (id != tintuc.MaTinTuc)
            {
                return NotFound();
            }
            tintuc.Hinh = tinTuc.Hinh;
                if (tintuc.Hinh == null)
                {
                    var data = from img in _context.tinTucs
                               where img.MaTinTuc == id
                               select img;
                    foreach (var item in data)
                    {
                        tintuc.Hinh = item.Hinh;
                    }
                }
                else
                {
                    //them hinh
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/tintuc", tintuc.Hinh + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ful.CopyToAsync(stream);
                    }
                    tintuc.Hinh = tintuc.MaTinTuc + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    //
                }
            if (ModelState.IsValid)
            {
                try
                {
                    tintuc.ChiTiet = tinTuc.ChiTiet;
                    tintuc.NoiBat = tinTuc.NoiBat;
                    tintuc.TrangThai = tinTuc.TrangThai;
                    tintuc.MoTa = tinTuc.MoTa;
                    _context.Update(tintuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinTucExists(tinTuc.MaTinTuc))
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
            return View(tinTuc);
        }

        // GET: admin/TinTucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.tinTucs
                .FirstOrDefaultAsync(m => m.MaTinTuc == id);
            if (tinTuc == null)
            {
                return NotFound();
            }

            return View(tinTuc);
        }

        // POST: admin/TinTucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinTuc = await _context.tinTucs.FindAsync(id);
            _context.tinTucs.Remove(tinTuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteModal(int? id)
        {
            if (id == null)
            {
                return Json("Not Found!!!!!");
            }
            var tinTuc = await _context.tinTucs.FindAsync(id);
            _context.tinTucs.Remove(tinTuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool TinTucExists(int id)
        {
            return _context.tinTucs.Any(e => e.MaTinTuc == id);
        }
    }
}
