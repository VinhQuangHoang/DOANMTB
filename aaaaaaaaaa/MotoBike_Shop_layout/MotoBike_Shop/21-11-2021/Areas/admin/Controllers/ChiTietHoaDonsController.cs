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
    public class ChiTietHoaDonsController : Controller
    {
        private readonly DPContext _context;

        public ChiTietHoaDonsController(DPContext context)
        {
            _context = context;
        }

        // GET: admin/ChiTietHoaDons
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.chiTietHoaDons.Include(c => c.MaHD);
            return View(await dPContext.ToListAsync());
        }

        // GET: admin/ChiTietHoaDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.chiTietHoaDons
                .Include(c => c.MaHD)
                .FirstOrDefaultAsync(m => m.MaChiTietHoaDon == id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // GET: admin/ChiTietHoaDons/Create
        public IActionResult Create()
        {
            ViewData["IdDonHang"] = new SelectList(_context.hoaDons, "MaHoaDon", "MaHoaDon");
            return View();
        }

        // POST: admin/ChiTietHoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChiTietHoaDon,MaHoaDon,MaSanPham,SoLuong,Gia,ChietKhau,ThanhTien,IdDonHang")] ChiTietHoaDon chiTietHoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDonHang"] = new SelectList(_context.hoaDons, "MaHoaDon", "MaHoaDon", chiTietHoaDon.IdDonHang);
            return View(chiTietHoaDon);
        }

        // GET: admin/ChiTietHoaDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.chiTietHoaDons.FindAsync(id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }
            ViewData["IdDonHang"] = new SelectList(_context.hoaDons, "MaHoaDon", "MaHoaDon", chiTietHoaDon.IdDonHang);
            return View(chiTietHoaDon);
        }

        // POST: admin/ChiTietHoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaChiTietHoaDon,MaHoaDon,MaSanPham,SoLuong,Gia,ChietKhau,ThanhTien,IdDonHang")] ChiTietHoaDon chiTietHoaDon)
        {
            if (id != chiTietHoaDon.MaChiTietHoaDon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonExists(chiTietHoaDon.MaChiTietHoaDon))
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
            ViewData["IdDonHang"] = new SelectList(_context.hoaDons, "MaHoaDon", "MaHoaDon", chiTietHoaDon.IdDonHang);
            return View(chiTietHoaDon);
        }

        // GET: admin/ChiTietHoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.chiTietHoaDons
                .Include(c => c.MaHD)
                .FirstOrDefaultAsync(m => m.MaChiTietHoaDon == id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // POST: admin/ChiTietHoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietHoaDon = await _context.chiTietHoaDons.FindAsync(id);
            _context.chiTietHoaDons.Remove(chiTietHoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonExists(int id)
        {
            return _context.chiTietHoaDons.Any(e => e.MaChiTietHoaDon == id);
        }
    }
}
