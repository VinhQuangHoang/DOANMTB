using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _21_11_2021.Areas.admin.Models
{
    public class DanhGia
    {
        [Key]
        public int MaSanPham { get; set; }
        [ForeignKey("MaSanPham")]
        public int SoSao { get; set; }
        public string ChiTiet { get; set; }
        public int IdDonHang { get; set; }
        [ForeignKey("IdDonHang")]
        public bool TrangThai { get; set; }

        public virtual SanPham MaSP { get; set; }
        public virtual DonHang IdDH { get; set; }

    }
}
