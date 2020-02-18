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
    public partial class FrmNhanVien : Form
    {
        private NhanVienBUS nvBUS = new NhanVienBUS();
        NhanVienDTO nvIndex;

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadCboChucVu();
            LoadData();

            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvData_CurrentCellChanged);
        }

        private void LoadCboChucVu()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add(new DataColumn("ID", typeof(int)));
            tb.Columns.Add(new DataColumn("Name", typeof(string)));

            DataRow admin = tb.NewRow();
            admin[0] = "1";
            admin[1] = "Admin";
            tb.Rows.Add(admin);

            DataRow nhanvien = tb.NewRow();
            nhanvien[0] = "2";
            nhanvien[1] = "Nhân viên";
            tb.Rows.Add(nhanvien);

            DataRow bacsi = tb.NewRow();
            bacsi[0] = "3";
            bacsi[1] = "Bác sĩ";
            tb.Rows.Add(bacsi);

            DataRow letan = tb.NewRow();
            letan[0] = "4";
            letan[1] = "Lễ tân";
            tb.Rows.Add(letan);

            cboChucVu.DataSource = tb;
            cboChucVu.DisplayMember = "Name";
            cboChucVu.ValueMember = "ID";
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = nvBUS.LoadDataNhanVien();

            dgvData.DataSource = dt;
        }

        private void SetNhanVienIndex(int _id) {
            int gioiTinh = 1;
            if (chkNu.Checked)
                gioiTinh = 0;

            nvIndex = new NhanVienDTO(_id, txtMa.Text, txtHoTen.Text, gioiTinh, txtDiaChi.Text, (int)cboChucVu.SelectedValue, txtUsername.Text, txtPass.Text, cboChucVu.Text, dtpNamSinh.Value.Date);
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
                cboChucVu.SelectedValue = dgvData.Rows[i].Cells["ColIDChucVu"].Value;
                dtpNamSinh.Value = (DateTime)dgvData.Rows[i].Cells["ColNamSinh"].Value;
                txtUsername.Text = dgvData.Rows[i].Cells["ColUsername"].Value.ToString();

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

        private void ClearText()
        {
            txtMa.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            cboChucVu.SelectedValue = 4;
            dtpNamSinh.Value = DateTime.Now;
            txtUsername.Text = "";
            txtPass.Text = "";
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

            if (isInsert) {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                if (txtPass.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            return false;
        }


        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ClearText();
            txtMa.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThieuDuLieu(true)) return;

            SetNhanVienIndex(-1);

            long re = nvBUS.Insert(nvIndex);
            if (re > 0)
            {
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else {
                if (re == -2)
                {
                    MessageBox.Show("Trùng mã nhân viên, hoặc username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            SetNhanVienIndex(ID);

            long re = nvBUS.Update(nvIndex);
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

                nvBUS.Delete(ID);

                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin Username password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = dgvData.CurrentRow.Index;
            int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

            SetNhanVienIndex(ID);

            long re = nvBUS.UpdatePass(nvIndex);

            if (re > 0)
            {
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                if (re == -1 || re == -2)
                {
                    MessageBox.Show("Không tồn tại thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
