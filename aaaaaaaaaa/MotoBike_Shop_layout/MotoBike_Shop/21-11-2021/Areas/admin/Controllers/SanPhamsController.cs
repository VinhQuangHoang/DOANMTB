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
    public class SanPhamsController : Controller
    {
        private readonly DPContext _context;

        public SanPhamsController(DPContext context)
        {
            _context = context;
        }

        // GET: admin/SanPhams
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.sanPhams.Include(s => s.KMai).Include(s => s.Loai);
            return View(await dPContext.ToListAsync());
        }

        // GET: admin/SanPhams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.SanPham = _context.sanPhams.ToList();
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.sanPhams
                .Include(s => s.KMai)
                .Include(s => s.Loai)
                .FirstOrDefaultAsync(m => m.MaSanPham == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // GET: admin/SanPhams/Create
        public IActionResult Create()
        {
            ViewBag.Json = "";
            ViewBag.MaLoai = _context.loaiSanPhams.ToList();
            ViewBag.KM = _context.khuyenMais.ToList();
            ViewData["MaKhuyenMai"] = new SelectList(_context.khuyenMais, "MaKhuyenMai", "MaKhuyenMai");
            ViewData["MaLoaiSanPham"] = new SelectList(_context.loaiSanPhams, "MaLoaiSanPham", "MaLoaiSanPham");
            return View();
        }

        // POST: admin/SanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSanPham,HinhAnh,TenSanPham,Gia,GiaKhuyenMai,GiaDaKhuyenMai,ChiTiet,MaKhuyenMai,MaLoaiSanPham,HangMuc,TrangThai")] SanPham sanPham, IFormFile ful)
        {
            ViewBag.MaLoai = _context.loaiSanPhams.ToList();
            ViewBag.KM = _context.khuyenMais.ToList();
            var data = from pay in _context.khuyenMais
                       where pay.MaKhuyenMai == sanPham.MaKhuyenMai
                       select pay;
            foreach(var item in data)
            {
                sanPham.GiaKhuyenMai = item.GiamGia;
                sanPham.GiaDaKhuyenMai = sanPham.Gia - item.GiamGia;
            }    
            if (ModelState.IsValid)
            {
                _context.Add(sanPham);
                await _context.SaveChangesAsync();
                try
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pro", sanPham.MaSanPham + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ful.CopyToAsync(stream);
                    }
                    sanPham.HinhAnh = sanPham.MaSanPham + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                }
                catch
                {
                    sanPham.HinhAnh = sanPham.MaSanPham.ToString() + ".png";
                }
                
                string hinh = sanPham.MaSanPham.ToString() + ".png";
                if(sanPham.HinhAnh == hinh)
                {
                    _context.Update(sanPham);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }    
                else
                {
                    ViewBag.Json = "Sai định dạng hình chỉ được định dạng PNG !";
                    return View(sanPham);
                }    
                
            }
            //ViewData["MaKhuyenMai"] = new SelectList(_context.khuyenMais, "MaKhuyenMai", "MaKhuyenMai", sanPham.MaKhuyenMai);
            //ViewData["MaLoaiSanPham"] = new SelectList(_context.loaiSanPhams, "MaLoaiSanPham", "MaLoaiSanPham", sanPham.MaLoaiSanPham);
            return View(sanPham);
        }

        // GET: admin/SanPhams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Json = "";
            ViewBag.MaLoai = _context.loaiSanPhams.ToList();
            ViewBag.KM = _context.khuyenMais.ToList();
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.sanPhams.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            //ViewData["MaKhuyenMai"] = new SelectList(_context.khuyenMais, "MaKhuyenMai", "MaKhuyenMai", sanPham.MaKhuyenMai);
            //ViewData["MaLoaiSanPham"] = new SelectList(_context.loaiSanPhams, "MaLoaiSanPham", "MaLoaiSanPham", sanPham.MaLoaiSanPham);
            return View(sanPham);
        }

        // POST: admin/SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HinhAnh,TenSanPham,Gia,GiaKhuyenMai,GiaDaKhuyenMai,ChiTiet,MaKhuyenMai,MaLoaiSanPham,HangMuc,TrangThai")] SanPham sanPham, IFormFile ful)
        {
            ViewBag.MaLoai = _context.loaiSanPhams.ToList();
            ViewBag.KM = _context.khuyenMais.ToList();
            var sanpham = _context.sanPhams.Find(id);
            //ktra ma san pham co ton tai
            if (id != sanpham.MaSanPham)
            {
                return NotFound();
            }
            //them hinh
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pro", sanpham.MaSanPham + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                sanpham.HinhAnh = sanpham.MaSanPham + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
            }
            catch
            {
                sanpham.HinhAnh = id + ".png";
            }
            //ktra ma loai san pham
            if (sanPham.MaLoaiSanPham == 0)
            {
                var data = from img in _context.sanPhams
                           where img.MaSanPham == id
                           select img;
                foreach (var item in data)
                {
                    sanPham.MaLoaiSanPham = item.MaLoaiSanPham;
                }
            }
            //ktra ma khuyen mai
            if (sanPham.MaKhuyenMai == 0)
            {
                var data = from img in _context.sanPhams
                           where img.MaSanPham == id
                           select img;
                foreach (var item in data)
                {
                    sanPham.MaKhuyenMai = item.MaKhuyenMai;
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    //linq ma khuyen mai
                    var data = from pay in _context.khuyenMais
                               where pay.MaKhuyenMai == sanPham.MaKhuyenMai
                               select pay;
                    sanpham.TenSanPham = sanPham.TenSanPham;
                    sanpham.Gia = sanPham.Gia;
                    //chinh sua gia tien
                    foreach (var item in data)
                    {
                        sanpham.GiaKhuyenMai = item.GiamGia;
                        sanpham.GiaDaKhuyenMai = sanPham.Gia - item.GiamGia;
                    }
                    sanpham.ChiTiet = sanPham.ChiTiet;
                    sanpham.MaKhuyenMai = sanPham.MaKhuyenMai;
                    sanpham.MaLoaiSanPham = sanPham.MaLoaiSanPham;
                    sanpham.HangMuc = sanPham.HangMuc;
                    sanpham.TrangThai = sanPham.TrangThai;
                    if(sanpham.HinhAnh == id.ToString() + ".png")
                    {
                        await _context.SaveChangesAsync();
                        _context.Update(sanpham);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Json = "Sai định dạng hình chỉ được định dạng PNG !";
                        return View(sanpham);
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamExists(sanPham.MaSanPham))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(sanpham);
        }

        // GET: admin/SanPhams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sanPham = await _context.sanPhams
                .Include(s => s.KMai)
                .Include(s => s.Loai)
                .FirstOrDefaultAsync(m => m.MaSanPham == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // POST: admin/SanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sanPham = await _context.sanPhams.FindAsync(id);
            _context.sanPhams.Remove(sanPham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamExists(int id)
        {
            return _context.sanPhams.Any(e => e.MaSanPham == id);
        }
    }
}
