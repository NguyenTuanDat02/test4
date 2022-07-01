
namespace GUI
{
    partial class frmLoaiPhong
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
            this.dgDSLoaiPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDSLoaiPhong
            // 
            this.dgDSLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSLoaiPhong.Location = new System.Drawing.Point(0, 150);
            this.dgDSLoaiPhong.Name = "dgDSLoaiPhong";
            this.dgDSLoaiPhong.Size = new System.Drawing.Size(673, 208);
            this.dgDSLoaiPhong.TabIndex = 0;
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 359);
            this.Controls.Add(this.dgDSLoaiPhong);
            this.Name = "frmLoaiPhong";
            this.Text = "frmLoaiPhong";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSLoaiPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDSLoaiPhong;
    }
}