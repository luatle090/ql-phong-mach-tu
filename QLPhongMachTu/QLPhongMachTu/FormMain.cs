using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongMachTu.DanhMuc;

namespace QLPhongMachTu
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuBenhNhan_Click(object sender, EventArgs e)
        {
            FrmBenhNhan frm = new FrmBenhNhan();
            frm.ShowDialog();
        }

        private void mnuLoaiBenh_Click(object sender, EventArgs e)
        {
            FrmLoaiBenh frm = new FrmLoaiBenh();
            frm.ShowDialog();
        }

        private void mnuThuoc_Click(object sender, EventArgs e)
        {
            FrmThuoc frm = new FrmThuoc();
            frm.ShowDialog();
        }

        private void mnuDonViTinh_Click(object sender, EventArgs e)
        {
            FrmDonViTinh frm = new FrmDonViTinh();
            frm.ShowDialog();
        }

        private void mnuCachDung_Click(object sender, EventArgs e)
        {
            FrmCachDung frm = new FrmCachDung();
            frm.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.ShowDialog();
        }

        private void mnuDSKhamBenh_Click(object sender, EventArgs e)
        {
            FrmDSKhamBenh frm = new FrmDSKhamBenh();
            frm.ShowDialog();
        }

        private void mnuPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            FrmPhieuKhamBenh frm = new FrmPhieuKhamBenh();
            frm.ShowDialog();
        }

        private void mnuHoaDonThanhToan_Click(object sender, EventArgs e)
        {
            FrmHoaDonThanhToan frm = new FrmHoaDonThanhToan();
            frm.ShowDialog();
        }

        private void mnuBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao frm = new FrmBaoCao();
            frm.ShowDialog();
        }
    }
}
