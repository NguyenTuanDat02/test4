using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string makh;
        private string tenkh;
        private string gioiTinh;
        private string cmnd;
        private string diachi;
        private string quoctich;
        private int sodt;
        
        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Quoctich { get => quoctich; set => quoctich = value; }
        public int Sodt { get => sodt; set => sodt = value; }
    }
}
