using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _21_11_2021.Areas.admin.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }
        public string TenHoaDon { get; set; }
        public int MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        public DateTime NgayDatHang { get; set; }
        public ICollection<ChiTietHoaDon> lstChiTietHoaDon { get; set; }
    }
}
