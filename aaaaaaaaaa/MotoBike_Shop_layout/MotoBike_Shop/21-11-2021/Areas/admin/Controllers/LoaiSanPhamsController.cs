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
    public class LoaiSanPhamsController : Controller
    {
        private readonly DPContext _context;

        public LoaiSanPhamsController(DPContext context)
        {
            _context = context;
        }

        // GET: admin/LoaiSanPhams
        public async Task<IActionResult> Index()
        {
            return View(await _context.loaiSanPhams.ToListAsync());
        }

        // GET: admin/LoaiSanPhams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPham = await _context.loaiSanPhams
                .FirstOrDefaultAsync(m => m.MaLoaiSanPham == id);
            if (loaiSanPham == null)
            {
                return NotFound();
            }

            return View(loaiSanPham);
        }

        // GET: admin/LoaiSanPhams/Create
        public IActionResult Create()
        {
            ViewBag.DanhMuc = _context.danhMucs.ToList();
            return View();
        }

        // POST: admin/LoaiSanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLoaiSanPham,TenLoaiSanPham,MaDanhMuc,TrangThai")] LoaiSanPham loaisanpham)
        {
            ViewBag.DanhMuc = _context.danhMucs.ToList();
            if (ModelState.IsValid)
            {
                _context.Add(loaisanpham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaisanpham);
        }

        // GET: admin/LoaiSanPhams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.DanhMuc = _context.danhMucs.ToList();
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPham = await _context.loaiSanPhams.FindAsync(id);
            if (loaiSanPham == null)
            {
                return NotFound();
            }
            return View(loaiSanPham);
        }

        // POST: admin/LoaiSanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaLoaiSanPham,TenLoaiSanPham,MaDanhMuc,TrangThai")] LoaiSanPham loaiSanPham)
        {
            ViewBag.DanhMuc = _context.danhMucs.ToList();
            if (id != loaiSanPham.MaLoaiSanPham)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiSanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSanPhamExists(loaiSanPham.MaLoaiSanPham))
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
            return View(loaiSanPham);
        }

        // GET: admin/LoaiSanPhams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPham = await _context.loaiSanPhams
                .FirstOrDefaultAsync(m => m.MaLoaiSanPham == id);
            if (loaiSanPham == null)
            {
                return NotFound();
            }

            return View(loaiSanPham);
        }

        // POST: admin/LoaiSanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiSanPham = await _context.loaiSanPhams.FindAsync(id);
            _context.loaiSanPhams.Remove(loaiSanPham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiSanPhamExists(int id)
        {
            return _context.loaiSanPhams.Any(e => e.MaLoaiSanPham == id);
        }
    }
}
