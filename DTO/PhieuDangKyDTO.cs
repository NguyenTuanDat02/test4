using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDangKyDTO
    {
        private string maphieudangky;
        private string makh;
        private string manv;
        private string maphong;
        private DateTime ngaylap;
        private DateTime ngaydi;
        private string maphieudichvu;
        private int tratruoc;

        public string Makh { get => makh; set => makh = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public DateTime Ngaydi { get => ngaydi; set => ngaydi = value; }
        public string Maphieudichvu { get => maphieudichvu; set => maphieudichvu = value; }
        public int Tratruoc { get => tratruoc; set => tratruoc = value; }
        public string Maphieudangky { get => maphieudangky; set => maphieudangky = value; }
    }
}
