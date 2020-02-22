namespace QLPhongMachTu
{
    partial class FrmHoaDonThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonThanhToan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.GroupBox();
            this.dgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.ColIDPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChkNam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColChkNu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ColSTT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoTen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTienKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTienThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpNgayThanhToan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 59);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày thanh toán";
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(15, 22);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayThanhToan.TabIndex = 9;
            this.dtpNgayThanhToan.ValueChanged += new System.EventHandler(this.dtpNgayThanhToan_ValueChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN THANH TOÁN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group
            // 
            this.group.Controls.Add(this.dgvPhieuKham);
            this.group.Controls.Add(this.panel2);
            this.group.Dock = System.Windows.Forms.DockStyle.Left;
            this.group.Location = new System.Drawing.Point(0, 59);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(241, 466);
            this.group.TabIndex = 3;
            this.group.TabStop = false;
            this.group.Text = "DS bệnh nhân cần xuất";
            // 
            // dgvPhieuKham
            // 
            this.dgvPhieuKham.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuKham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIDPhieuKham,
            this.dataGridViewTextBoxColumn2,
            this.ColMaBenhNhan,
            this.ColHoTen,
            this.ColChkNam,
            this.ColChkNu,
            this.ColNgaySinh,
            this.ColTrieuChung,
            this.ColLoaiBenh,
            this.ColNhanVien,
            this.ColIDNhanVien,
            this.ColIDLoaiBenh});
            this.dgvPhieuKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuKham.Location = new System.Drawing.Point(3, 54);
            this.dgvPhieuKham.Name = "dgvPhieuKham";
            this.dgvPhieuKham.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuKham.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuKham.Size = new System.Drawing.Size(235, 409);
            this.dgvPhieuKham.TabIndex = 3;
            // 
            // ColIDPhieuKham
            // 
            this.ColIDPhieuKham.DataPropertyName = "ID";
            this.ColIDPhieuKham.HeaderText = "ID";
            this.ColIDPhieuKham.Name = "ColIDPhieuKham";
            this.ColIDPhieuKham.ReadOnly = true;
            this.ColIDPhieuKham.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NgayKham";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày khám";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColMaBenhNhan
            // 
            this.ColMaBenhNhan.DataPropertyName = "Ma";
            this.ColMaBenhNhan.HeaderText = "Mã bệnh nhân";
            this.ColMaBenhNhan.Name = "ColMaBenhNhan";
            this.ColMaBenhNhan.ReadOnly = true;
            this.ColMaBenhNhan.Visible = false;
            // 
            // ColHoTen
            // 
            this.ColHoTen.DataPropertyName = "HoTen";
            this.ColHoTen.HeaderText = "Họ tên";
            this.ColHoTen.Name = "ColHoTen";
            this.ColHoTen.ReadOnly = true;
            // 
            // ColChkNam
            // 
            this.ColChkNam.DataPropertyName = "Nam";
            this.ColChkNam.HeaderText = "Nam";
            this.ColChkNam.Name = "ColChkNam";
            this.ColChkNam.ReadOnly = true;
            // 
            // ColChkNu
            // 
            this.ColChkNu.DataPropertyName = "Nu";
            this.ColChkNu.HeaderText = "Nữ";
            this.ColChkNu.Name = "ColChkNu";
            this.ColChkNu.ReadOnly = true;
            // 
            // ColNgaySinh
            // 
            this.ColNgaySinh.DataPropertyName = "NgaySinh";
            this.ColNgaySinh.HeaderText = "Ngày sinh";
            this.ColNgaySinh.Name = "ColNgaySinh";
            this.ColNgaySinh.ReadOnly = true;
            // 
            // ColTrieuChung
            // 
            this.ColTrieuChung.DataPropertyName = "TrieuChung";
            this.ColTrieuChung.HeaderText = "Triệu chứng";
            this.ColTrieuChung.Name = "ColTrieuChung";
            this.ColTrieuChung.ReadOnly = true;
            this.ColTrieuChung.Visible = false;
            // 
            // ColLoaiBenh
            // 
            this.ColLoaiBenh.DataPropertyName = "LoaiBenh";
            this.ColLoaiBenh.HeaderText = "Dự đoán loại bệnh";
            this.ColLoaiBenh.Name = "ColLoaiBenh";
            this.ColLoaiBenh.ReadOnly = true;
            this.ColLoaiBenh.Visible = false;
            // 
            // ColNhanVien
            // 
            this.ColNhanVien.DataPropertyName = "NhanVien";
            this.ColNhanVien.HeaderText = "Bác sĩ khám";
            this.ColNhanVien.Name = "ColNhanVien";
            this.ColNhanVien.ReadOnly = true;
            // 
            // ColIDNhanVien
            // 
            this.ColIDNhanVien.DataPropertyName = "IDNhanVien";
            this.ColIDNhanVien.HeaderText = "IDNhanVien";
            this.ColIDNhanVien.Name = "ColIDNhanVien";
            this.ColIDNhanVien.ReadOnly = true;
            this.ColIDNhanVien.Visible = false;
            // 
            // ColIDLoaiBenh
            // 
            this.ColIDLoaiBenh.DataPropertyName = "IDDoanBenh";
            this.ColIDLoaiBenh.HeaderText = "IDDoanBenh";
            this.ColIDLoaiBenh.Name = "ColIDLoaiBenh";
            this.ColIDLoaiBenh.ReadOnly = true;
            this.ColIDLoaiBenh.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.dtpNgayKham);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 38);
            this.panel2.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(202, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(30, 25);
            this.btnReload.TabIndex = 9;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(96, 8);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayKham.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày khám";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtTienThuoc);
            this.groupBox2.Controls.Add(this.txtTienKham);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.btnXuat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(241, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 126);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(240, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Enabled = false;
            this.txtTienThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThuoc.Location = new System.Drawing.Point(334, 52);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.ReadOnly = true;
            this.txtTienThuoc.Size = new System.Drawing.Size(135, 20);
            this.txtTienThuoc.TabIndex = 5;
            // 
            // txtTienKham
            // 
            this.txtTienKham.Enabled = false;
            this.txtTienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKham.Location = new System.Drawing.Point(87, 52);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.ReadOnly = true;
            this.txtTienKham.Size = new System.Drawing.Size(147, 20);
            this.txtTienKham.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(334, 26);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(135, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(159, 87);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiền thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày khám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền khám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvData);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(241, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 340);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DS hóa đơn đã xuất";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT2,
            this.ColHoTen2,
            this.ColNgayKham,
            this.ColTienKham,
            this.ColTienThuoc});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 16);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(477, 321);
            this.dgvData.TabIndex = 0;
            // 
            // ColSTT2
            // 
            this.ColSTT2.DataPropertyName = "NgayThanhToan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.ColSTT2.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColSTT2.HeaderText = "Ngày thanh toán";
            this.ColSTT2.Name = "ColSTT2";
            this.ColSTT2.ReadOnly = true;
            // 
            // ColHoTen2
            // 
            this.ColHoTen2.DataPropertyName = "HoTen";
            this.ColHoTen2.HeaderText = "Họ tên";
            this.ColHoTen2.Name = "ColHoTen2";
            this.ColHoTen2.ReadOnly = true;
            this.ColHoTen2.Width = 150;
            // 
            // ColNgayKham
            // 
            this.ColNgayKham.DataPropertyName = "NgayKham";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.ColNgayKham.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColNgayKham.HeaderText = "Ngày khám";
            this.ColNgayKham.Name = "ColNgayKham";
            this.ColNgayKham.ReadOnly = true;
            // 
            // ColTienKham
            // 
            this.ColTienKham.DataPropertyName = "TienKham";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColTienKham.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColTienKham.HeaderText = "Tiền khám";
            this.ColTienKham.Name = "ColTienKham";
            this.ColTienKham.ReadOnly = true;
            // 
            // ColTienThuoc
            // 
            this.ColTienThuoc.DataPropertyName = "TienThuoc";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColTienThuoc.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColTienThuoc.HeaderText = "Tiền thuốc";
            this.ColTienThuoc.Name = "ColTienThuoc";
            this.ColTienThuoc.ReadOnly = true;
            // 
            // FrmHoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.group);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHoaDonThanhToan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN THANH TOÁN";
            this.Load += new System.EventHandler(this.FrmHoaDonThanhToan_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTienThuoc;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPhieuKham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChkNam;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChkNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoaiBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDLoaiBenh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoTen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTienKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTienThuoc;
    }
}