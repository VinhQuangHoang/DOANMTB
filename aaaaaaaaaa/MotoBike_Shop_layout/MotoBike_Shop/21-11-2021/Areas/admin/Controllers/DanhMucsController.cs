using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Areas.admin.Models;
using Newtonsoft.Json;

namespace _21_11_2021.Areas.admin.Controllers
{
    [Area("admin")]
    public class DanhMucsController : Controller
    {
        private readonly DPContext _context;

        public DanhMucsController(DPContext context)
        {
            _context = context;
        }

        // GET: admin/DanhMucs
        public async Task<IActionResult> Index()
        {
            return View(await _context.danhMucs.ToListAsync());
        }

        // GET: admin/DanhMucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhMuc = await _context.danhMucs
                .FirstOrDefaultAsync(m => m.MaDanhMuc == id);
            if (danhMuc == null)
            {
                return NotFound();
            }

            return View(danhMuc);
        }

        // GET: admin/DanhMucs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/DanhMucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDanhMuc,TenDanhMuc,TrangThai")] DanhMuc danhMuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(danhMuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(danhMuc);
        }

        // GET: admin/DanhMucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhMuc = await _context.danhMucs.FindAsync(id);
            if (danhMuc == null)
            {
                return NotFound();
            }
            return View(danhMuc);
        }

        // POST: admin/DanhMucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaDanhMuc,TenDanhMuc,TrangThai")] DanhMuc danhMuc)
        {
            if (id != danhMuc.MaDanhMuc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(danhMuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DanhMucExists(danhMuc.MaDanhMuc))
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
            return View(danhMuc);
        }

        // GET: admin/DanhMucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhMuc = await _context.danhMucs
                .FirstOrDefaultAsync(m => m.MaDanhMuc == id);
            if (danhMuc == null)
            {
                return NotFound();
            }

            return View(danhMuc);
        }

        // POST: admin/DanhMucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var danhMuc = await _context.danhMucs.FindAsync(id);
            _context.danhMucs.Remove(danhMuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteModal(int? id)
        {
            if (id == null)
            {
                return Json("Not Found!!!!!");
            }
            var danhMuc = await _context.danhMucs.FindAsync(id);
            _context.danhMucs.Remove(danhMuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> IdShowModal(int? id)
        {
            var danhMuc = _context.danhMucs.Where(x => x.MaDanhMuc == id).ToList();
            ViewBag.Id = _context.danhMucs.Where(x => x.MaDanhMuc == id).Select(x => x.MaDanhMuc);
            ViewBag.Name = _context.danhMucs.Where(x => x.MaDanhMuc == id).Select(x => x.TenDanhMuc);
            ViewBag.Status = _context.danhMucs.Where(x => x.MaDanhMuc == id).Select(x => x.TrangThai);
            return View();
        }
        private bool DanhMucExists(int id)
        {
            return _context.danhMucs.Any(e => e.MaDanhMuc == id);
        }
    }
}
