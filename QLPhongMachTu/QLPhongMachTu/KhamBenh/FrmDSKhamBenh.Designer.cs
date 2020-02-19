namespace QLPhongMachTu
{
    partial class FrmDSKhamBenh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDSKhamBenh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNu = new System.Windows.Forms.RadioButton();
            this.chkNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNgaySInh = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColNu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.chkAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpNgayKham);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 70);
            this.panel1.TabIndex = 2;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(10, 12);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(83, 17);
            this.chkAll.TabIndex = 0;
            this.chkAll.Text = "Tất cả ngày";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÁM BỆNH NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(88, 44);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayKham.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnXoaTrang);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 32);
            this.panel2.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Location = new System.Drawing.Point(399, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(480, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(12, 6);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(74, 21);
            this.btnXoaTrang.TabIndex = 0;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(95, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 21);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(255, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 21);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(175, 6);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(74, 21);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvData);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 393);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khám";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNgayKham,
            this.ColMa,
            this.ColHoTen,
            this.ColGioiTinh,
            this.ColNu,
            this.ColNgaySinh,
            this.ColDiaChi,
            this.ColIDBenhNhan,
            this.ColIDNhanVien});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 16);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvData.Size = new System.Drawing.Size(668, 374);
            this.dgvData.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtMa);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbNgaySInh);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 81);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(88, 45);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(285, 45);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(223, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(88, 19);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(285, 19);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(223, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNu);
            this.groupBox1.Controls.Add(this.chkNam);
            this.groupBox1.Location = new System.Drawing.Point(542, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(69, 19);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(39, 17);
            this.chkNu.TabIndex = 1;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Checked = true;
            this.chkNam.Location = new System.Drawing.Point(6, 19);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(47, 17);
            this.chkNam.TabIndex = 0;
            this.chkNam.TabStop = true;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Địa chỉ";
            // 
            // lbNgaySInh
            // 
            this.lbNgaySInh.AutoSize = true;
            this.lbNgaySInh.Location = new System.Drawing.Point(6, 46);
            this.lbNgaySInh.Name = "lbNgaySInh";
            this.lbNgaySInh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaySInh.TabIndex = 9;
            this.lbNgaySInh.Text = "Ngày sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Họ tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã bệnh nhân";
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "IDPhieu";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColNgayKham
            // 
            this.ColNgayKham.DataPropertyName = "NgayKham";
            this.ColNgayKham.HeaderText = "Ngày khám";
            this.ColNgayKham.Name = "ColNgayKham";
            this.ColNgayKham.ReadOnly = true;
            // 
            // ColMa
            // 
            this.ColMa.DataPropertyName = "Ma";
            this.ColMa.HeaderText = "Mã bệnh nhân";
            this.ColMa.Name = "ColMa";
            this.ColMa.ReadOnly = true;
            // 
            // ColHoTen
            // 
            this.ColHoTen.DataPropertyName = "HoTen";
            this.ColHoTen.HeaderText = "Họ tên";
            this.ColHoTen.Name = "ColHoTen";
            this.ColHoTen.ReadOnly = true;
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.DataPropertyName = "Nam";
            this.ColGioiTinh.HeaderText = "Nam";
            this.ColGioiTinh.Name = "ColGioiTinh";
            this.ColGioiTinh.ReadOnly = true;
            this.ColGioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColGioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColGioiTinh.Width = 70;
            // 
            // ColNu
            // 
            this.ColNu.DataPropertyName = "Nu";
            this.ColNu.HeaderText = "Nữ";
            this.ColNu.Name = "ColNu";
            this.ColNu.ReadOnly = true;
            this.ColNu.Width = 70;
            // 
            // ColNgaySinh
            // 
            this.ColNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            dataGridViewCellStyle8.NullValue = null;
            this.ColNgaySinh.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColNgaySinh.HeaderText = "Ngày sinh";
            this.ColNgaySinh.Name = "ColNgaySinh";
            this.ColNgaySinh.ReadOnly = true;
            // 
            // ColDiaChi
            // 
            this.ColDiaChi.DataPropertyName = "DiaChi";
            this.ColDiaChi.HeaderText = "Địa chỉ";
            this.ColDiaChi.Name = "ColDiaChi";
            this.ColDiaChi.ReadOnly = true;
            // 
            // ColIDBenhNhan
            // 
            this.ColIDBenhNhan.DataPropertyName = "IDBenhNhan";
            this.ColIDBenhNhan.HeaderText = "IDBenhNhan";
            this.ColIDBenhNhan.Name = "ColIDBenhNhan";
            this.ColIDBenhNhan.ReadOnly = true;
            this.ColIDBenhNhan.Visible = false;
            // 
            // ColIDNhanVien
            // 
            this.ColIDNhanVien.DataPropertyName = "IDNhanVien";
            this.ColIDNhanVien.HeaderText = "IDLoaiBenh";
            this.ColIDNhanVien.Name = "ColIDNhanVien";
            this.ColIDNhanVien.ReadOnly = true;
            this.ColIDNhanVien.Visible = false;
            // 
            // btnReload
            // 
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(194, 41);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(25, 25);
            this.btnReload.TabIndex = 5;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FrmDSKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDSKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH KHÁM BỆNH NHÂN";
            this.Load += new System.EventHandler(this.FrmPhieuKhamBenh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkNu;
        private System.Windows.Forms.RadioButton chkNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNgaySInh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDNhanVien;
        private System.Windows.Forms.Button btnReload;
    }
}