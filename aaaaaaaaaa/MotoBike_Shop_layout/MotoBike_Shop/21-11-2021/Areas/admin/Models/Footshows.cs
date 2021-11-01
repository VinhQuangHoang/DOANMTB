using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _21_11_2021.Areas.admin.Models
{
    public class Footshows
    {
        [Key]
        public int IdFootShow { get; set; }
        public string Hinh { get; set; }
        public bool TrangThai { get; set; }
    }
}
