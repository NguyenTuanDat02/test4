using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HoaDonDTO
    {
        private string mahoadon;
        private DateTime ngaythanhtoan;
        private int sotiendattruoc;
        private string donvi;
        private string manhanvien;

        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public DateTime Ngaythanhtoan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public int Sotiendattruoc { get => sotiendattruoc; set => sotiendattruoc = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
    }
}
