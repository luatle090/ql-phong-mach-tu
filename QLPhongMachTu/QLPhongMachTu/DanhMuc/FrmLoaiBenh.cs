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
    public partial class FrmLoaiBenh : Form
    {
        private LoaiBenhBUS bus = new LoaiBenhBUS();
        private LoaiBenhDTO itemIndex;

        public FrmLoaiBenh()
        {
            InitializeComponent();
        }

        private void FrmLoaiBenh_Load(object sender, EventArgs e)
        {
            LoadData();
            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvData_CurrentCellChanged);
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = bus.LoadData();

            dgvData.DataSource = dt;
        }

        private void SetDataIndex(int _id)
        {
            itemIndex = new LoaiBenhDTO(_id, txtTen.Text.Trim());
        }

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int id = (int)dgvData.Rows[i].Cells["ColID"].Value;

                txtTen.Text = dgvData.Rows[i].Cells["ColTenLoaiBenh"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                ClearText();
            }
        }

        private void ClearText()
        {
            txtTen.Text = "";
            
        }

        private bool ThieuDuLieu(bool isInsert)
        {
            if (txtTen.Text.Trim() == "")
            { 
                MessageBox.Show("Vui lòng nhập tên loại bệnh!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return true;
            }

            return false;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ClearText();
            txtTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThieuDuLieu(true)) return;

            SetDataIndex(-1);

            long re = bus.Insert(itemIndex);
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

            long re = bus.Update(itemIndex);
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

                bus.Delete(ID);

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
