﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongMachTuBUS;

namespace QLPhongMachTu
{
    public partial class FrmBaoCao : Form
    {
        BaoCaoBUS bus = new BaoCaoBUS();

        public FrmBaoCao()
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
            dt = bus.BaoCao_DoanhThu_Month(dtpNgayXem.Value.Date);

            dgvData.DataSource = dt;
           
        }
    }
}
