using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Models;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Sanpham(int? id)
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
            ViewBag.ListSP = _context.sanPhams.Where(x => x.MaLoaiSanPham == id).ToList();
            return View();
        }
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
