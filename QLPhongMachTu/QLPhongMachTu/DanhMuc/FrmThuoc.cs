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
    public partial class FrmThuoc : Form
    {
        private ThuocBUS bnBUS = new ThuocBUS();
        private ThuocDTO bnIndex;

        public FrmThuoc()
        {
            InitializeComponent();
        }

        private void FrmThuoc_Load_1(object sender, EventArgs e)
        {
            LoadData();
            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvThuoc_CurrentCellChanged);
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = bnBUS.LoadData();

            dgvData.DataSource = dt;
        }

        private void SetDataIndex(int _id)
        {
            bnIndex = new ThuocDTO(_id, txtTenThuoc.Text.Trim(), Convert.ToDecimal(txtGia.Text.Trim()));
        }

        private void dgvThuoc_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int id = (int)dgvData.Rows[i].Cells["ColID"].Value;

                txtTenThuoc.Text = dgvData.Rows[i].Cells["ColTenThuoc"].Value.ToString();
                txtGia.Text = dgvData.Rows[i].Cells["ColGia"].Value.ToString();
            }
            catch (Exception ex)
            {
                ClearText();
            }
        }

        private void ClearText()
        {
            txtTenThuoc.Text = "";
            txtGia.Text = "0";
           
        }

        private bool ThieuDuLieu(bool isInsert)
        {
            if (txtTenThuoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên thuốc!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try
            {
                decimal gia = Convert.ToDecimal(txtGia.Text.Trim());
            }
            catch (Exception ex) {
                MessageBox.Show("Vui lòng nhập đúng giá tiền", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGia.Text = "";
                return true;
            }
           
            return false;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ClearText();
            txtTenThuoc.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThieuDuLieu(true)) return;

            SetDataIndex(-1);

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

            SetDataIndex(ID);

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

                long re = bnBUS.Delete(ID);

                if(re > 0)
                {
                    LoadData();
                    MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thuốc đã được sử dụng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
