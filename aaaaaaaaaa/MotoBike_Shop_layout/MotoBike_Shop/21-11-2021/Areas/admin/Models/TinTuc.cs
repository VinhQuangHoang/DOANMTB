using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _21_11_2021.Areas.admin.Models
{
    public class TinTuc
    {
        [Key]
        public int MaTinTuc { get; set; }
        public string TenTinTuc { get; set; } 
        public string MoTa { get; set; }
        public string Hinh { get; set; }
        public string ChiTiet { get; set; }
        public int NoiBat { get; set; }
        public bool TrangThai { get; set; }
    }
}
