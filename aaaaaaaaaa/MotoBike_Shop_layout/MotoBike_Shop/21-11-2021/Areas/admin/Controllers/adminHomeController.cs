using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace _21_11_2021.Areas.admin.Controllers
{
    [Area("Admin")]
    public class adminHomeController : Controller
    {
        
        //private readonly ILogger<adminHomeController> _logger;
        private readonly DPContext _context;

        //public adminHomeController(ILogger<adminHomeController> logger)
        //{
        //    _logger = logger;
        //}


        public adminHomeController(DPContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            //var danhmuc = _context.danhMucs.;
            //for (int i = 0; i < 6; i++)
            //{
            //    ViewBag.DanhMuc = danhmuc;
            //    i++;

            //}
            //return View();
            return View();

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
