﻿using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        public string MaKh { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string Hinh { get; set; }
        public bool TrangThaiHd { get; set; }

        public ICollection<HoaDon> HoaDon { get; set; }
    }
}