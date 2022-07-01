
namespace GUI
{
    partial class frmPhieuDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgDSPhieuDangKy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPhieuDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDSPhieuDangKy
            // 
            this.dgDSPhieuDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSPhieuDangKy.Location = new System.Drawing.Point(-1, 224);
            this.dgDSPhieuDangKy.Name = "dgDSPhieuDangKy";
            this.dgDSPhieuDangKy.Size = new System.Drawing.Size(659, 176);
            this.dgDSPhieuDangKy.TabIndex = 1;
            // 
            // frmPhieuDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 400);
            this.Controls.Add(this.dgDSPhieuDangKy);
            this.Name = "frmPhieuDangKy";
            this.Text = "frmPhieuDangKy";
            this.Load += new System.EventHandler(this.frmPhieuDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPhieuDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDSPhieuDangKy;
    }
}