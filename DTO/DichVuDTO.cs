using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDTO
    {
        private string maphieudichvu;
        private string maphieudangky;
        private string tendichvu;
        private int giadichvu;

        public string Maphieudichvu { get => maphieudichvu; set => maphieudichvu = value; }
        public string Maphieudangky { get => maphieudangky; set => maphieudangky = value; }
        public string Tendichvu { get => tendichvu; set => tendichvu = value; }
        public int Giadichvu { get => giadichvu; set => giadichvu = value; }
    }
}
