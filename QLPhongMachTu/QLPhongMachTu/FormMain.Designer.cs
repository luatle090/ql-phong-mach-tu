namespace QLPhongMachTu
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonViTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCachDung = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSKhamBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuKhamBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSBenhNhanKhamBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuDungThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCaiDat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.toolStripMenuItem2,
            this.mnuHoaDonThanhToan,
            this.mnuBaoCao,
            this.mnuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBenhNhan,
            this.mnuLoaiBenh,
            this.toolStripSeparator1,
            this.mnuThuoc,
            this.mnuDonViTinh,
            this.mnuCachDung,
            this.toolStripSeparator2,
            this.mnuNhanVien});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuBenhNhan
            // 
            this.mnuBenhNhan.Name = "mnuBenhNhan";
            this.mnuBenhNhan.Size = new System.Drawing.Size(132, 22);
            this.mnuBenhNhan.Text = "Bệnh nhân";
            this.mnuBenhNhan.Click += new System.EventHandler(this.mnuBenhNhan_Click);
            // 
            // mnuLoaiBenh
            // 
            this.mnuLoaiBenh.Name = "mnuLoaiBenh";
            this.mnuLoaiBenh.Size = new System.Drawing.Size(132, 22);
            this.mnuLoaiBenh.Text = "Loại bệnh";
            this.mnuLoaiBenh.Click += new System.EventHandler(this.mnuLoaiBenh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // mnuThuoc
            // 
            this.mnuThuoc.Name = "mnuThuoc";
            this.mnuThuoc.Size = new System.Drawing.Size(132, 22);
            this.mnuThuoc.Text = "Thuốc";
            this.mnuThuoc.Click += new System.EventHandler(this.mnuThuoc_Click);
            // 
            // mnuDonViTinh
            // 
            this.mnuDonViTinh.Name = "mnuDonViTinh";
            this.mnuDonViTinh.Size = new System.Drawing.Size(132, 22);
            this.mnuDonViTinh.Text = "Đơn vị tính";
            this.mnuDonViTinh.Click += new System.EventHandler(this.mnuDonViTinh_Click);
            // 
            // mnuCachDung
            // 
            this.mnuCachDung.Name = "mnuCachDung";
            this.mnuCachDung.Size = new System.Drawing.Size(132, 22);
            this.mnuCachDung.Text = "Cách dùng";
            this.mnuCachDung.Click += new System.EventHandler(this.mnuCachDung_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(132, 22);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSKhamBenh,
            this.mnuPhieuKhamBenh});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem2.Text = "Khám bệnh";
            // 
            // mnuDSKhamBenh
            // 
            this.mnuDSKhamBenh.Name = "mnuDSKhamBenh";
            this.mnuDSKhamBenh.Size = new System.Drawing.Size(192, 22);
            this.mnuDSKhamBenh.Text = "Danh sách khám bệnh";
            this.mnuDSKhamBenh.Click += new System.EventHandler(this.mnuDSKhamBenh_Click);
            // 
            // mnuPhieuKhamBenh
            // 
            this.mnuPhieuKhamBenh.Name = "mnuPhieuKhamBenh";
            this.mnuPhieuKhamBenh.Size = new System.Drawing.Size(192, 22);
            this.mnuPhieuKhamBenh.Text = "Phiếu khám bệnh";
            this.mnuPhieuKhamBenh.Click += new System.EventHandler(this.mnuPhieuKhamBenh_Click);
            // 
            // mnuHoaDonThanhToan
            // 
            this.mnuHoaDonThanhToan.Name = "mnuHoaDonThanhToan";
            this.mnuHoaDonThanhToan.Size = new System.Drawing.Size(126, 20);
            this.mnuHoaDonThanhToan.Text = "Hóa đơn thanh toán";
            this.mnuHoaDonThanhToan.Click += new System.EventHandler(this.mnuHoaDonThanhToan_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSBenhNhanKhamBenh,
            this.mnuDoanhThu,
            this.mnuSuDungThuoc});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuDSBenhNhanKhamBenh
            // 
            this.mnuDSBenhNhanKhamBenh.Name = "mnuDSBenhNhanKhamBenh";
            this.mnuDSBenhNhanKhamBenh.Size = new System.Drawing.Size(230, 22);
            this.mnuDSBenhNhanKhamBenh.Text = "Danh sách bệnh nhân";
            this.mnuDSBenhNhanKhamBenh.Click += new System.EventHandler(this.mnuDSBenhNhanKhamBenh_Click);
            // 
            // mnuDoanhThu
            // 
            this.mnuDoanhThu.Name = "mnuDoanhThu";
            this.mnuDoanhThu.Size = new System.Drawing.Size(230, 22);
            this.mnuDoanhThu.Text = "Báo cáo doanh thu theo ngày";
            // 
            // mnuSuDungThuoc
            // 
            this.mnuSuDungThuoc.Name = "mnuSuDungThuoc";
            this.mnuSuDungThuoc.Size = new System.Drawing.Size(230, 22);
            this.mnuSuDungThuoc.Text = "Báo cáo sử dụng thuốc";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCaiDat,
            this.mnuDangNhap,
            this.mnuDangXuat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuCaiDat
            // 
            this.mnuCaiDat.Name = "mnuCaiDat";
            this.mnuCaiDat.Size = new System.Drawing.Size(132, 22);
            this.mnuCaiDat.Text = "Cài đặt";
            this.mnuCaiDat.Click += new System.EventHandler(this.mnuCaiDat_Click);
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(132, 22);
            this.mnuDangNhap.Text = "Đăng nhập";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(132, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 530);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "QUAN LY PHONG MACH TU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDonViTinh;
        private System.Windows.Forms.ToolStripMenuItem mnuCachDung;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonThanhToan;
        private System.Windows.Forms.ToolStripMenuItem mnuBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDSKhamBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuKhamBenh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuCaiDat;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDSBenhNhanKhamBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuSuDungThuoc;
    }
}

