using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongDTO
    {
        private string maloaiphong;
        private string tenloaiphong;
        private string trangbi;

        public string Maloaiphong { get => maloaiphong; set => maloaiphong = value; }
        public string Tenloaiphong { get => tenloaiphong; set => tenloaiphong = value; }
        public string Trangbi { get => trangbi; set => trangbi = value; }
    }
}