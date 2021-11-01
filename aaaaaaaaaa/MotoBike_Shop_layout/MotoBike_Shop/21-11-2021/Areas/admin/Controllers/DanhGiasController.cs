using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Areas.admin.Models;

namespace _21_11_2021.Areas.admin.Controllers
{
    [Area("admin")]
    public class DanhGiasController : Controller
    {
        private readonly DPContext _context;

        public DanhGiasController(DPContext context)
        {
            _context = context;
        }

        // GET: admin/DanhGias
        public async Task<IActionResult> Index()
        {
            return View(await _context.danhGias.ToListAsync());
        }

        // GET: admin/DanhGias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhGia = await _context.danhGias
                .FirstOrDefaultAsync(m => m.MaSanPham == id);
            if (danhGia == null)
            {
                return NotFound();
            }

            return View(danhGia);
        }

        // GET: admin/DanhGias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/DanhGias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSanPham,SoSao,ChiTiet,IdDonHang,TrangThai")] DanhGia danhGia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(danhGia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(danhGia);
        }

        // GET: admin/DanhGias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhGia = await _context.danhGias.FindAsync(id);
            if (danhGia == null)
            {
                return NotFound();
            }
            return View(danhGia);
        }

        // POST: admin/DanhGias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaSanPham,SoSao,ChiTiet,IdDonHang,TrangThai")] DanhGia danhGia)
        {
            if (id != danhGia.MaSanPham)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(danhGia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DanhGiaExists(danhGia.MaSanPham))
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
            return View(danhGia);
        }

        // GET: admin/DanhGias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhGia = await _context.danhGias
                .FirstOrDefaultAsync(m => m.MaSanPham == id);
            if (danhGia == null)
            {
                return NotFound();
            }

            return View(danhGia);
        }

        // POST: admin/DanhGias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var danhGia = await _context.danhGias.FindAsync(id);
            _context.danhGias.Remove(danhGia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DanhGiaExists(int id)
        {
            return _context.danhGias.Any(e => e.MaSanPham == id);
        }
    }
}
