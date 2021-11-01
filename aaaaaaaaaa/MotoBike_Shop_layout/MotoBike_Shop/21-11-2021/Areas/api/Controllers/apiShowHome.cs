using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using _21_11_2021.Areas.admin.Data;

namespace _21_11_2021.Areas.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class apiShowHome : ControllerBase
    {
        private readonly DPContext _context;
        public apiShowHome(DPContext context)
        {
            _context = context;
        }
        [HttpGet]
        public string GetDanhMuc()
        {
            var listDanhMuc = _context.danhMucs;
            var listNewDanhMuc = from p in _context.danhMucs
                                 select p;
            return JsonConvert.SerializeObject(listNewDanhMuc);
        }
    }
}
