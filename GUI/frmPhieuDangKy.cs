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
    public partial class frmPhieuDangKy : Form
    {
        public frmPhieuDangKy()
        {
            InitializeComponent();
        }

        private void frmPhieuDangKy_Load(object sender, EventArgs e)
        {
            HienThiPhieuDangKyLenDataGrid();
        }
        private void HienThiPhieuDangKyLenDataGrid()
        {
            List<PhieuDangKyDTO> lstPhieuDangKy = PhieuDangKyBUS.LayDSPhieuDangKy();
            dgDSPhieuDangKy.DataSource = lstPhieuDangKy;
            dgDSPhieuDangKy.Columns["Maphieudangky"].HeaderText = "Mã Phiếu Đăng Ký";
            dgDSPhieuDangKy.Columns["Makh"].HeaderText = "Tên Khách Hàng";
            dgDSPhieuDangKy.Columns["Manv"].HeaderText = "Mã Nhân Viên";
            dgDSPhieuDangKy.Columns["Maphong"].HeaderText = "Mã Phòng";
            dgDSPhieuDangKy.Columns["Ngaylap"].HeaderText = "Ngày Lập";
            dgDSPhieuDangKy.Columns["Ngaydi"].HeaderText = "Ngày Đi";
            dgDSPhieuDangKy.Columns["Tratruoc"].HeaderText = "Trả Trước";
            dgDSPhieuDangKy.Columns["Maphieudichvu"].HeaderText = "Mã Phiếu Dịch Vụ";
            dgDSPhieuDangKy.Columns["Maphieudangky"].Width = 90;
            dgDSPhieuDangKy.Columns["Makh"].Width = 90;
            dgDSPhieuDangKy.Columns["Manv"].Width = 90;
            dgDSPhieuDangKy.Columns["Maphong"].Width = 90;
            dgDSPhieuDangKy.Columns["Ngaylap"].Width = 90;
            dgDSPhieuDangKy.Columns["Ngaydi"].Width = 90;
            dgDSPhieuDangKy.Columns["Tratruoc"].Width = 70;
            dgDSPhieuDangKy.Columns["Maphieudichvu"].Width = 90;


        }
    }

}