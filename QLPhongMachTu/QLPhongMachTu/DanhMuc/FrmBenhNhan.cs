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

namespace QLPhongMachTu.DanhMuc
{
    public partial class FrmBenhNhan : Form
    {
        private BenhNhanBUS bnBUS = new BenhNhanBUS();
        private BenhNhanDTO bnIndex;

        public FrmBenhNhan()
        {
            InitializeComponent();
        }


        private void FrmBenhNhan_Load(object sender, EventArgs e)
        {
            LoadData();
           
            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvData_CurrentCellChanged);
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = bnBUS.LoadData();

            dgvData.DataSource = dt;
        }

        private void SetBenhNhanIndex(int _id)
        {
            int gioiTinh = 1;
            if (chkNu.Checked)
                gioiTinh = 0;

            bnIndex = new BenhNhanDTO(_id, txtMa.Text, txtHoTen.Text, gioiTinh, txtDiaChi.Text, dtpNgaySinh.Value.Date);
        }

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int id = (int)dgvData.Rows[i].Cells["ColID"].Value;

                txtMa.Text = dgvData.Rows[i].Cells["ColMa"].Value.ToString();
                txtHoTen.Text = dgvData.Rows[i].Cells["ColHoTen"].Value.ToString();
                txtDiaChi.Text = dgvData.Rows[i].Cells["ColDiaChi"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvData.Rows[i].Cells["ColNgaySinh"].Value;

                bool gioiTinh = true;
                if ((int)dgvData.Rows[i].Cells["ColGioiTinh"].Value == 0)
                    gioiTinh = false;

                chkNam.Checked = gioiTinh;

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
            txtMa.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
        }

        private bool ThieuDuLieu(bool isInsert)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Họ tên nhân viên!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThieuDuLieu(true)) return;

            SetBenhNhanIndex(-1);

            long re = bnBUS.Insert(bnIndex);
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

            SetBenhNhanIndex(ID);

            long re = bnBUS.Update(bnIndex);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;
            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

                bnBUS.Delete(ID);

                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
