using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Areas.admin.Models;
using _21_11_2021.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _21_11_2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;


        public HomeController(DPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Sanpham(int? id, string searchString)
        {
            //List<SanPham> listproduct = new List<SanPham>();
            //foreach (var item in li)
            //{
            //    SanPham temp = new SanPham();
            //    temp.MaSanPham = item.MaSanPham;
            //    temp.TenSanPham = item.TenSanPham;
            //    temp.Loai = item.Loai;
            //    temp.HinhAnh = item.HinhAnh;
            //    listproduct.Add(temp);

            //    return View(listproduct);
            //}

            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();

            ViewData["CurrentFilter"] = searchString;

            var li = from x in _context.sanPhams
                     select x;

            if (!String.IsNullOrEmpty(searchString))
            {
                li = li.Where(x => x.TenSanPham.Contains(searchString) /*|| s.UEmail.Contains(searchString)*/);
            }

            if (id == null)
            {
                return NotFound();
            }
            ViewBag.ListSP = _context.sanPhams.Where(x => x.MaLoaiSanPham == id).ToList();
            return View(await li.AsNoTracking().ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Chitietsanpham(int? id)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Chitiet = _context.sanPhams.Where(x => x.MaSanPham == id).ToList();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
