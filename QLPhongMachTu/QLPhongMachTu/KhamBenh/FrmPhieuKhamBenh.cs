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
    public partial class FrmPhieuKhamBenh : Form
    {
        int _idNhanVien = 1;

        DataTable tb_DataDSKham = new DataTable();
        DataTable tb_DataPhieuKham = new DataTable();
       // DataTable tb_DataCTThuoc = new DataTable();

        private DSKhamBenhBUS dsKhamBUS = new DSKhamBenhBUS();

        private PhieuKhamBenhBUS bus = new PhieuKhamBenhBUS();
        private PhieuKhamBenhDTO index = new PhieuKhamBenhDTO();

        public FrmPhieuKhamBenh()
        {
            InitializeComponent();
        }

        private void FrmPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            dtpNgayKham.Value = DateTime.Now.Date;

            LoadCboDoanBenh();
            LoadCboThuoc();
            LoadCboDonViTinh();
            LoadCboCachDung();

            LoadDSBenhNhanKham();
            LoadDataPhieuKhamBenh();

            this.dgvDSKham.CurrentCellChanged += new System.EventHandler(this.dgvDSKham_CurrentCellChanged);
            this.dgvPhieuKham.CurrentCellChanged += new System.EventHandler(this.dgvPhieuKham_CurrentCellChanged);
            this.dgvChiTiet.CurrentCellChanged += new System.EventHandler(this.dgvChiTiet_CurrentCellChanged);
        }

        private void LoadCboDoanBenh()
        {
            LoaiBenhBUS bus = new LoaiBenhBUS();
            DataTable dt = new DataTable();
            dt = bus.LoadData();

            cboLoaiBenh.DataSource = dt;
            cboLoaiBenh.DisplayMember = "LoaiBenh";
            cboLoaiBenh.ValueMember = "ID";
        }

        private void LoadCboThuoc()
        {
            ThuocBUS bnBUS = new ThuocBUS();
            DataTable dt = new DataTable();
            dt = bnBUS.LoadData();

            cboThuoc.DataSource = dt;
            cboThuoc.DisplayMember = "TenThuoc";
            cboThuoc.ValueMember = "ID";
        }

        private void LoadCboDonViTinh()
        {
            DonViTinhBUS bus = new DonViTinhBUS();
            DataTable dt = new DataTable();
            dt = bus.LoadData();

            cboDonViTinh.DataSource = dt;
            cboDonViTinh.DisplayMember = "TenDonViTinh";
            cboDonViTinh.ValueMember = "ID";
        }

        private void LoadCboCachDung()
        {
            CachDungBUS bus = new CachDungBUS();
            DataTable dt = new DataTable();
            dt = bus.LoadData();

            cboCachDung.DataSource = dt;
            cboCachDung.DisplayMember = "TenCachDung";
            cboCachDung.ValueMember = "ID";
        }

        private void LoadDSBenhNhanKham()
        {
            tb_DataDSKham = dsKhamBUS.LoadData(dtpNgayKham.Value.Date, chkAll.Checked);

            dgvDSKham.DataSource = tb_DataDSKham;
        }

        private void LoadDataPhieuKhamBenh()
        {
            tb_DataPhieuKham = bus.LoadData(dtpNgayKham.Value.Date, chkAll.Checked);

            dgvPhieuKham.DataSource = tb_DataPhieuKham;
        }

        private void dgvDSKham_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvDSKham.Rows.Count < 1 || dgvDSKham.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvDSKham.CurrentRow.Index;
                //int id = (int)dgvDSKham.Rows[i].Cells["ColIDDSKham"].Value;

                txtMa.Text = dgvDSKham.Rows[i].Cells["ColMaDS"].Value.ToString();
                txtHoTen.Text = dgvDSKham.Rows[i].Cells["ColHoTenDS"].Value.ToString();
            }
            catch (Exception ex)
            {
               // ClearText();
            }
        }

        private void dgvPhieuKham_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvPhieuKham.Rows.Count < 1 || dgvPhieuKham.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvPhieuKham.CurrentRow.Index;
                int id = (int)dgvPhieuKham.Rows[i].Cells["ColID"].Value;

                txtMa.Text = dgvPhieuKham.Rows[i].Cells["ColMaBenhNhan"].Value.ToString();
                txtHoTen.Text = dgvPhieuKham.Rows[i].Cells["ColHoTen"].Value.ToString();

                txtTieuChung.Text = dgvPhieuKham.Rows[i].Cells["ColTrieuChung"].Value.ToString();
                cboLoaiBenh.SelectedValue = dgvPhieuKham.Rows[i].Cells["ColIDLoaiBenh"].Value;

                LoadCTThuoc_PhieuThuoc(id);
            }
            catch (Exception ex)
            {
                // ClearText();
            }
        }

        private void dgvChiTiet_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvChiTiet.Rows.Count < 1 || dgvChiTiet.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvChiTiet.CurrentRow.Index;
               // int id = (int)dgvChiTiet.Rows[i].Cells["ColIDCT"].Value;

                cboThuoc.SelectedValue = dgvChiTiet.Rows[i].Cells["ColIDThuoc"].Value;
                txtSoLuong.Text = dgvChiTiet.Rows[i].Cells["ColSoLuong"].Value.ToString();

                cboDonViTinh.SelectedValue = dgvChiTiet.Rows[i].Cells["ColIDDVT"].Value;
                cboCachDung.SelectedValue = dgvChiTiet.Rows[i].Cells["ColIDCachDung"].Value;
            }
            catch (Exception ex)
            {
               
            }
        }

        private bool CheckData()
       {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
       }
        
        private void ClearText()
        {
            txtMa.Text = "";
            txtHoTen.Text = "";
            txtTieuChung.Text = "";
            txtSoLuong.Text = "0";

            dgvChiTiet.Rows.Clear();
        }

        private void SetData_Index(Int64 _id)
        {
            index.id = _id;
            index.idDSKhamBenh = (int)dgvDSKham.Rows[dgvDSKham.CurrentRow.Index].Cells["ColIDDSKham"].Value;
            index.ngayKham = dtpNgayKham.Value.Date;
            index.trieuChung = txtTieuChung.Text.Trim();
            index.idDoanBenh = (int)cboLoaiBenh.SelectedValue;
            index.idNhanVien = _idNhanVien;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ClearText();
            txtMa.Focus();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData() == false) return;

            //them phieu kham
            SetData_Index(-1);
            long re = bus.Insert(index);

            //them chi tiet thuoc--
            InsertUpdateDataChiTiet(re);
            //---------------------
            if (re > 0)
            {
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataPhieuKhamBenh();
            }
            else
            {
                if (re == -2)
                {
                    MessageBox.Show("Trùng mã, vui lòng nhập lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvPhieuKham.Rows.Count < 1 || dgvPhieuKham.CurrentCellAddress.Y < 0) return;
            if (CheckData() == false) return;

            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            int i = dgvPhieuKham.CurrentRow.Index;
            int ID = Convert.ToInt32(dgvPhieuKham.Rows[i].Cells["ColID"].Value.ToString());

            SetData_Index(ID);
            long re = bus.Update(index);

            //them chi tiet thuoc--
            InsertUpdateDataChiTiet(re);
            //---------------------

            if (re > 0)
            {
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataPhieuKhamBenh();
            }
            else
            {
                if (re == -2)
                {
                    MessageBox.Show("Thông tin đã được thanh toán! Không thể xóa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuKham.Rows.Count < 1 || dgvPhieuKham.CurrentCellAddress.Y < 0) return;
            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            try
            {
                int i = dgvPhieuKham.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvPhieuKham.Rows[i].Cells["ColID"].Value.ToString());

                Int64 re = bus.Delete(ID);

                if (re == 1)
                {
                    LoadDataPhieuKhamBenh();
                    MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (re == -2)
                    {
                        MessageBox.Show("Thông tin đã được thanh toán! Không thể xóa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

#region "Chi tiet thuoc"

        CTThuocKhamBUS ctThuoc_BUS = new CTThuocKhamBUS();

        private void LoadCTThuoc_PhieuThuoc(int _idPhieu)
        {
            DataTable dt = new DataTable();
            dt = ctThuoc_BUS.LoadData(_idPhieu);

            dgvChiTiet.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvChiTiet.Rows.Add();

                dgvChiTiet.Rows[i].Cells["ColIDCT"].Value = dt.Rows[i]["ID"];

                dgvChiTiet.Rows[i].Cells["ColTenThuoc"].Value = dt.Rows[i]["TenThuoc"];
                dgvChiTiet.Rows[i].Cells["ColSoLuong"].Value = dt.Rows[i]["SoLuong"].ToString();
                dgvChiTiet.Rows[i].Cells["ColDVT"].Value = dt.Rows[i]["TenDonViTinh"];
                dgvChiTiet.Rows[i].Cells["ColCachDung"].Value = dt.Rows[i]["TenCachDung"];

                dgvChiTiet.Rows[i].Cells["ColIDThuoc"].Value = dt.Rows[i]["IDThuoc"];
                dgvChiTiet.Rows[i].Cells["ColIDDVT"].Value = dt.Rows[i]["IDDonViThuoc"];
                dgvChiTiet.Rows[i].Cells["ColIDCachDung"].Value = dt.Rows[i]["IDCachDung"];
            }

        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            try
            {
                double sl = Convert.ToDouble(txtSoLuong.Text.Trim());

                if (sl <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Text = "1";
            }
        }

        private void butThem_Click(object sender, EventArgs e)
        { 
            int i = dgvChiTiet.Rows.Add();

            dgvChiTiet.Rows[i].Cells["ColIDCT"].Value = -1;

            dgvChiTiet.Rows[i].Cells["ColTenThuoc"].Value = cboThuoc.Text;
            dgvChiTiet.Rows[i].Cells["ColSoLuong"].Value = txtSoLuong.Text.Trim();
            dgvChiTiet.Rows[i].Cells["ColDVT"].Value = cboDonViTinh.Text;
            dgvChiTiet.Rows[i].Cells["ColCachDung"].Value = cboCachDung.Text;

            dgvChiTiet.Rows[i].Cells["ColIDThuoc"].Value = cboThuoc.SelectedValue;
            dgvChiTiet.Rows[i].Cells["ColIDDVT"].Value = cboDonViTinh.SelectedValue;
            dgvChiTiet.Rows[i].Cells["ColIDCachDung"].Value = cboCachDung.SelectedValue;

        }

        private void butCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.Rows.Count < 1 || dgvChiTiet.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvChiTiet.CurrentRow.Index;
                // int id = (int)dgvChiTiet.Rows[i].Cells["ColIDCT"].Value;

                dgvChiTiet.Rows[i].Cells["ColTenThuoc"].Value = cboThuoc.Text;
                dgvChiTiet.Rows[i].Cells["ColSoLuong"].Value = txtSoLuong.Text.Trim();
                dgvChiTiet.Rows[i].Cells["ColDVT"].Value = cboDonViTinh.Text;
                dgvChiTiet.Rows[i].Cells["ColCachDung"].Value = cboCachDung.Text;

                dgvChiTiet.Rows[i].Cells["ColIDThuoc"].Value = cboThuoc.SelectedValue;
                dgvChiTiet.Rows[i].Cells["ColIDDVT"].Value = cboDonViTinh.SelectedValue;
                dgvChiTiet.Rows[i].Cells["ColIDCachDung"].Value = cboCachDung.SelectedValue;
            }
            catch (Exception ex)
            {

            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.Rows.Count < 1 || dgvChiTiet.CurrentCellAddress.Y < 0) return;

            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            try
            {
                int i = dgvChiTiet.CurrentRow.Index;
                Int64 id = (int)dgvChiTiet.Rows[i].Cells["ColIDCT"].Value;

                ctThuoc_BUS.Delete(id);
                dgvChiTiet.Rows.RemoveAt(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công, có lỗi xãy ra! Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertUpdateDataChiTiet(Int64 _idPhieu)
        {
            try
            {
                for (int i = 0; i < dgvChiTiet.Rows.Count; i++)
                {
                    CTThuocKhamDTO ctThuoc = new CTThuocKhamDTO();

                    ctThuoc.idPhieu = _idPhieu;

                    ctThuoc.idThuoc = (int)dgvChiTiet.Rows[i].Cells["ColIDThuoc"].Value;
                    ctThuoc.idDVT = (int)dgvChiTiet.Rows[i].Cells["ColIDDVT"].Value;
                    ctThuoc.idCachDung = (int)dgvChiTiet.Rows[i].Cells["ColIDCachDung"].Value;

                    ctThuoc.soLuong = Convert.ToDouble(dgvChiTiet.Rows[i].Cells["ColSoLuong"].Value.ToString());

                    if (Convert.ToInt16(dgvChiTiet.Rows[i].Cells["ColIDCT"].Value.ToString()) < 1)
                    {
                        ctThuoc_BUS.Insert(ctThuoc);
                    }
                    else
                    {
                        ctThuoc.id = (int)dgvChiTiet.Rows[i].Cells["ColIDCT"].Value;
                        ctThuoc_BUS.Update(ctThuoc);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có sự cố! Vui lòng kiểm tra lại!", "Warning-CTThuoc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

        }


        #endregion

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDSBenhNhanKham();
            LoadDataPhieuKhamBenh();
        }
    }
}
