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
    public partial class FrmDSKhamBenh : Form
    {
        private int _idNhanVien = 1;
        private int _soLuongKhamMax = 0;
        private string _QD = "QD1.1";
        DataTable tableData;

        private DSKhamBenhBUS dsBUS = new DSKhamBenhBUS();
        private DSKhamBenhDTO dsIndex = new DSKhamBenhDTO();

        public FrmDSKhamBenh()
        {
            InitializeComponent();
        }

        private void FrmPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            GetSoLuongKhamTrongNgay();
            LoadData();

            this.txtMa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMa_KeyUp);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvData_CurrentCellChanged);
        }

        private void LoadData()
        {
            tableData = new DataTable();
            tableData = dsBUS.LoadData(dtpNgayKham.Value.Date, chkAll.Checked);

            dgvData.DataSource = tableData;

            dsIndex = new DSKhamBenhDTO();
        }

        private void GetSoLuongKhamTrongNgay()
        {
            ConfigBUS config = new ConfigBUS();
            _soLuongKhamMax = config.GetGiaTriQuiDinh(_QD);
        }

        private bool IsQuaSoLuongKham()
        {
            if (dsBUS.SoLuongKhamTrongNgay(dtpNgayKham.Value.Date) > _soLuongKhamMax)
                return true;

            return false;

        }

#region "Ma enter tim benh nhan"

        private BenhNhanDAO bnSearchDAO = new BenhNhanDAO();

        private void txtMa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtMa.Text.Trim() != "")
            {
                LoadSearchAndLoadBenhNhan(txtMa.Text.Trim());
            }
        }

        private void LoadSearchAndLoadBenhNhan(string ma)
        {
            SearchDataBenhNhan(ma);

            if (dsIndex.benhNhan.id > 0)
            {
                LoadViewBox(dsIndex.benhNhan);
                btnThem.Focus();
            }
            else
            {
                txtHoTen.Focus();
            }
        }

        private void SearchDataBenhNhan(string ma)
        {
            BenhNhanDTO bnSearch = new BenhNhanDTO();
            bnSearch = bnSearchDAO.GetBenhNhan(ma);

            if (bnSearch.id > 0)
            {
                dsIndex.benhNhan = bnSearch;
            }
        }

        private void LoadViewBox(BenhNhanDTO benhNhan)
        {
            txtHoTen.Text = benhNhan.hoTen;
            txtDiaChi.Text = benhNhan.diaChi;
            dtpNgaySinh.Value = benhNhan.ngaySinh;

            bool gioiTinh = true;
            if (benhNhan.gioiTinh == 0)
                gioiTinh = false;

            chkNam.Checked = gioiTinh;    
        }

#endregion

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int id = (int)dgvData.Rows[i].Cells["ColID"].Value;

                dtpNgayKham.Value = Convert.ToDateTime(dgvData.Rows[i].Cells["ColNgayKham"].Value.ToString());

                txtMa.Text = dgvData.Rows[i].Cells["ColMa"].Value.ToString();
                txtHoTen.Text = dgvData.Rows[i].Cells["ColHoTen"].Value.ToString();
                txtDiaChi.Text = dgvData.Rows[i].Cells["ColDiaChi"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvData.Rows[i].Cells["ColNgaySinh"].Value;


                chkNam.Checked = Convert.ToBoolean(dgvData.Rows[i].Cells["ColGioiTinh"].Value.ToString());

            }
            catch (Exception ex)
            {
                ClearText();
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ClearText();
            txtMa.Focus();
        }

        private void ClearText()
        {
            dtpNgayKham.Value = DateTime.Now.Date;

            txtMa.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
        }

        private bool ThieuDuLieu(bool isInsert)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã bệnh nhân!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Họ tên bệnh nhân!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void Set_dsIndex(int _id)
        {
            int gioiTinh = 1;
            if (chkNu.Checked)
                gioiTinh = 0;

            dsIndex.id = _id;
            dsIndex.ngayKham = dtpNgayKham.Value.Date;
            dsIndex.idNhanVien = _idNhanVien;

            if (dsIndex.benhNhan.id < 1)
            {
                SearchDataBenhNhan(txtMa.Text.Trim());
            }

            dsIndex.benhNhan.ma = txtMa.Text.Trim();
            dsIndex.benhNhan.hoTen = txtHoTen.Text.Trim();
            dsIndex.benhNhan.diaChi = txtDiaChi.Text.Trim();
            dsIndex.benhNhan.ngaySinh = dtpNgaySinh.Value.Date;
            dsIndex.benhNhan.gioiTinh = gioiTinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (IsQuaSoLuongKham())
            {
                MessageBox.Show("Vượt quá " + _soLuongKhamMax.ToString() + " lượt khám trong ngày!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ThieuDuLieu(true)) return;

            Set_dsIndex(-1);
            long re = dsBUS.Insert(dsIndex);

            if (re > 0)
            {
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
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
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;
            if (ThieuDuLieu(false)) return;

            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            int i = dgvData.CurrentRow.Index;
            int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

            Set_dsIndex(ID);
            long re = dsBUS.Update(dsIndex);

            if (re > 0)
            {
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                if (re == -2)
                {
                    MessageBox.Show("Trùng mã", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;
            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

                dsBUS.Delete(ID);
               
                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void Search()
        {
            string filter = FilterDataGridView(tableData, txtSearch.Text.Trim());

            tableData.DefaultView.RowFilter = String.Format(filter);

            //dgvData.DataSource = tableData;
        }

        private string FilterDataGridView(DataTable tableData , string search)
        {
            string filter = "";
            string name = "";

            try
            {
                foreach (DataColumn colum in tableData.Columns)
                {
                    if (colum.DataType.Name == "string" || colum.DataType.Name == "String")
                    {
                        name = colum.ColumnName;
                        filter = filter + " " + name + " LIKE '%" + search + "%' OR ";
                    }
                }

                //loai bo ky tu 'OR' o cuoi
                filter = filter.Trim();
                filter =  filter.Substring(0, filter.Length - 2);

                return filter;
            }
            catch (Exception ex)
            {
                return "";
            }
   
        }
           
  
    }
}
