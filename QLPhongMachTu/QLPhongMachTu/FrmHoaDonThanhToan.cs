using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongMachTuBUS;
using QLPhongMachTuDTO;
using QLPhongMachTuDAO;


namespace QLPhongMachTu
{
    public partial class FrmHoaDonThanhToan : Form
    {
        ThanhToanBUS ttBUS = new ThanhToanBUS();

        DataTable tb_DataPhieuKham = new DataTable();
        PhieuKhamBenhBUS bus = new PhieuKhamBenhBUS();
        ThanhToanDTO ttIndex;

        int _idNhanVien = 1;

        string _qdTienKham = "QD4.1";
        decimal _tienKham = 0;

        string _qdTienThuoc = "QD4.2";
        decimal _tienThuoc = 0;

        public FrmHoaDonThanhToan()
        {
            InitializeComponent();
        }

        private void FrmHoaDonThanhToan_Load_1(object sender, EventArgs e)
        {
            dtpNgayThanhToan.Value = DateTime.Now.Date;
            dtpNgayKham.Value = DateTime.Now.Date;

            LoadTienKham();
            LoadDataPhieuKhamBenh();

            LoadData();

            this.dgvPhieuKham.CurrentCellChanged += new System.EventHandler(this.dgvPhieuKham_CurrentCellChanged);
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = ttBUS.LoadData(dtpNgayThanhToan.Value, false);

            dgvData.DataSource = dt;
        }

        private void LoadTienKham()
        {
            ConfigBUS bus = new ConfigBUS();
            _tienKham = bus.GetGiaTriQuiDinh(_qdTienKham);
            _tienThuoc = bus.GetGiaTriQuiDinh(_qdTienThuoc);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataPhieuKhamBenh();
        }

        private void LoadDataPhieuKhamBenh()
        {
            
            tb_DataPhieuKham = bus.LoadData(dtpNgayKham.Value.Date, false);

            dgvPhieuKham.DataSource = tb_DataPhieuKham;
        }

        private void dgvPhieuKham_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvPhieuKham.Rows.Count < 1 || dgvPhieuKham.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvPhieuKham.CurrentRow.Index;
                int id = (int)dgvPhieuKham.Rows[i].Cells["ColIDPhieuKham"].Value;

                dateTimePicker1.Value = dtpNgayKham.Value;
                txtHoTen.Text = dgvPhieuKham.Rows[i].Cells["ColHoTen"].Value.ToString();
                txtTienKham.Text = _tienKham.ToString() ;

                decimal tienThuoc = bus.TinhTienThuoc(id);
                txtTienThuoc.Text = tienThuoc.ToString();

                ttIndex = new ThanhToanDTO();
                ttIndex.hoTen = txtHoTen.Text;
                ttIndex.idPhieu = id;
                ttIndex.tienKham = _tienKham;
                ttIndex.tienThuoc = tienThuoc;
                ttIndex.ngayThanhToan = dtpNgayThanhToan.Value.Date;
                ttIndex.idNhanVien = _idNhanVien;

                ttIndex.id = 1;

            }
            catch (Exception ex)
            {
                ttIndex.id = -1;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvPhieuKham.Rows.Count < 1 || dgvPhieuKham.CurrentCellAddress.Y < 0) return;

            try
            {
                if (ttIndex.id < 1) return;

                Int64 re =  ttBUS.Insert(ttIndex);

                if (re > 0)
                {
                    LoadData();
                    MessageBox.Show("Thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (re == -2)
                    {
                        MessageBox.Show("Thông tin đã được thanh toán!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Không thành công! Vui lòng thực hiện lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xãy ra vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgayThanhToan_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
