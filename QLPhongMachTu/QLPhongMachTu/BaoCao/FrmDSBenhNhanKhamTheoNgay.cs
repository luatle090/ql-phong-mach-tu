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
    public partial class FrmDSBenhNhanKhamTheoNgay : Form
    {
        private PhieuKhamBenhBUS bus = new PhieuKhamBenhBUS();

        public FrmDSBenhNhanKhamTheoNgay()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            dtpNgayXem.Value = DateTime.Now.Date;

        }

        private void btnXem1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bus.LoadData(dtpNgayXem.Value.Date, false);
            if(dt.Rows.Count < 1)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvData.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvData.Rows.Add();

                dgvData.Rows[i].Cells["ColSTT"].Value = i+1;

                dgvData.Rows[i].Cells["ColHoTen"].Value = dt.Rows[i]["HoTen"];
                dgvData.Rows[i].Cells["ColNgayKham"].Value = dt.Rows[i]["NgayKham"];
                dgvData.Rows[i].Cells["ColLoaiBenh"].Value = dt.Rows[i]["LoaiBenh"];
                dgvData.Rows[i].Cells["ColTrieuChung"].Value = dt.Rows[i]["TrieuChung"];

            }

        }
    }
}
