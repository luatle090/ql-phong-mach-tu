using QLPhongMachTuBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongMachTu
{
    public partial class FrmLogin : Form
    {
        private NhanVienBUS nv = new NhanVienBUS();
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void DangNhap(string _username, string _password)
        {
            try
            {
                DataTable tb;

                tb = nv.DangNhap(_username.ToLower(), _password);

                if (tb.Rows.Count < 1)
                {
                    MessageBox.Show("Username hoặc Password không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idUser = Convert.ToInt16(tb.Rows[0]["ID"].ToString());
                string hoTen = tb.Rows[0]["HoTen"].ToString();
                string ma = tb.Rows[0]["Ma"].ToString();
                int chucVu = Convert.ToInt16(tb.Rows[0]["ChucVu"].ToString());
                string chucVuText = tb.Rows[0]["ChucVuText"].ToString();

                this.Dispose();         
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            DangNhap(txtUsername.Text, txtPassword.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
