using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _21_11_2021.Areas.admin.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string GioiTinh { get; set; }
        public bool TrangThai { get; set; }
        public string Hang { get; set; }
        public ICollection<DanhGia> lsDanhGia { get; set; }
        public ICollection<HoaDon> lstHoaDon { get; set; }
    }
}
