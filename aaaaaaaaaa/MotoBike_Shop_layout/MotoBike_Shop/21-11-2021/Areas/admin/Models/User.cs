using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _21_11_2021.Areas.admin.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Rank { get; set; }
        public string Address { get; set; }

        public string Role { get; set; }

        public ICollection<HoaDon> lstHoaDon { get; set; }
    }
}
