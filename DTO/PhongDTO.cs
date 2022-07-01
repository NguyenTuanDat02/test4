using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class PhongDTO
    {
        private string maphong;
        private string tenphong;
        private string tinhtrang;
        private string maloaiphong;
        private int giaphong;
        private string donvi;

        public string Maphong { get => maphong; set => maphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Maloaiphong { get => maloaiphong; set => maloaiphong = value; }
        public int Giaphong { get => giaphong; set => giaphong = value; }
        public string Donvi { get => donvi; set => donvi = value; }
    }
}
