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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            HienThiLoaiPhongLenDataGrid();
        }
        private void HienThiLoaiPhongLenDataGrid()
        {
            List<LoaiPhongDTO> lstLoaiPhong = LoaiPhongBUS.LayDSLoaiPhong();
            dgDSLoaiPhong.DataSource = lstLoaiPhong;
            dgDSLoaiPhong.Columns["Maloaiphong"].HeaderText = "Mã Loại Phòng";
            dgDSLoaiPhong.Columns["Maloaiphong"].HeaderText = "Tên Loại Phòng";
            dgDSLoaiPhong.Columns["Trangbi"].HeaderText = "Trang Bị";
            dgDSLoaiPhong.Columns["Maloaiphong"].Width = 90;
            dgDSLoaiPhong.Columns["Maloaiphong"].Width = 200;
            dgDSLoaiPhong.Columns["Trangbi"].Width = 120;
           


        }
    }
}
