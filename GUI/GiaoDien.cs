using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmgiaodien : Form
    {
        public frmgiaodien()
        {
            InitializeComponent();
        }
        frmchucvu fCV;
        frmNhanVien fNV;
        frmDichVu fDV;
        frmHoaDon fHD;
        frmKhachHang fKH;
        frmLoaiPhong fLP;
        frmPhieuDangKy fPDK;
        frmPhong fP;

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("bạn có chắc chắn muốn thoát ?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void nhanvienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fNV == null || fCV.IsDisposed)
            {
                fNV = new frmNhanVien();
                this.Hide();
                fNV.Show();
            }

        }

        private void chứcVụToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (fCV == null || fCV.IsDisposed)
            {
                fCV = new frmchucvu();
                fCV.Show();
            }

        }

        private void phòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fP == null || fP.IsDisposed)
            {
                fP = new frmPhong();
                fP.Show();
            }
        }

        private void loạiPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fLP == null || fLP.IsDisposed)
            {
                fLP = new frmLoaiPhong();
                fLP.Show();
            }
        }

        private void phiếuĐăngKýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fPDK == null || fCV.IsDisposed)
            {
                fPDK = new frmPhieuDangKy();
                fPDK.Show();
            }
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fHD == null || fHD.IsDisposed)
            {
                fHD = new frmHoaDon();
                fHD.Show();
            }
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fDV == null || fDV.IsDisposed)
            {
                fDV = new frmDichVu();
                fDV.Show();
            }
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fKH == null || fKH.IsDisposed)
            {
                fKH = new frmKhachHang();
                fKH.Show();
            }
        }
    }

  
}
