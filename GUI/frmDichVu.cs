using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void HienThiDichVuLenDataGrid()
        {
            List<DichVuDTO> lstDichVu = DichVuBUS.LayDSDichVu();
            dgDSDichVu.DataSource = lstDichVu;
            dgDSDichVu.Columns["Maphieudichvu"].HeaderText = "Mã Phiếu Dịch Vụ";
            dgDSDichVu.Columns["Maphieudangky"].HeaderText = "Mã Phiếu Đăng Ký";
            dgDSDichVu.Columns["Tendichvu"].HeaderText = "Tên Dịch Vụ";
            dgDSDichVu.Columns["Giadichvu"].HeaderText = "Giá Dịch Vụ";
            dgDSDichVu.Columns["Maphieudichvu"].Width = 90;
            dgDSDichVu.Columns["Maphieudangky"].Width = 90;
            dgDSDichVu.Columns["Tendichvu"].Width = 150;
            dgDSDichVu.Columns["Giadichvu"].Width = 100;


        }

        private void dgDSDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            HienThiDichVuLenDataGrid();
        }

      
    }
}
