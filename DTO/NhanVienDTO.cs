using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string manv;
        private string tennv;
        private string gioiTinh;
        private string macv;
        private string diachi;
        private DateTime ngaysinh;
        private int sdt;

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Macv { get => macv; set => macv = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int Sdt { get => sdt; set => sdt = value; }
    }
}
