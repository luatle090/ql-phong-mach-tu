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
    public partial class FrmConfig : Form
    {
        private ConfigBUS bus = new ConfigBUS();
        private ConfigDTO itemIndex;

        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
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

        private void SetDataIndex()
        {
            itemIndex = new ConfigDTO(txtQuyDinh.Text, txtDoiTuong.Text, Convert.ToInt32(txtGiaTri.Text.Trim()));
        }

        private bool CheckData()
        {
            if (txtQuyDinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn quy định", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuyDinh.Focus();
                return true;

            }

            try
            {
                Int32 giatri = Convert.ToInt32(txtGiaTri.Text.Trim());

                if (giatri < 0)
                {
                    MessageBox.Show("Vui lòng nhập đúng giá trị! Lớn hơn bằng 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaTri.Focus();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng giá trị!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaTri.Focus();
                return true;
            }
            

            return false;
        }

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

            try
            {
                int i = dgvData.CurrentRow.Index;

                txtQuyDinh.Text = dgvData.Rows[i].Cells["ColQuyDinh"].Value.ToString();
                txtDoiTuong.Text = dgvData.Rows[i].Cells["CoLNoiDung"].Value.ToString();
                txtGiaTri.Text = dgvData.Rows[i].Cells["ColGiaTri"].Value.ToString();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;
            if (CheckData()) return;

            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            int i = dgvData.CurrentRow.Index;
            
            SetDataIndex();
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
    }
}
