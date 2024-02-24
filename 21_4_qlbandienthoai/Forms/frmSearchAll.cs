using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_4_qlbandienthoai.Forms
{
    public partial class frmSearchAll : Form
    {
        public frmSearchAll()
        {
            InitializeComponent();
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            frmSearchSP f= new frmSearchSP();
            f.ShowDialog();
        }

        private void btnnv_Click(object sender, EventArgs e)
        {
            frmSearchNV f = new frmSearchNV();
            f.ShowDialog();
        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            frmSearchKH f = new frmSearchKH();
            f.ShowDialog();
        }

        private void btnhdn_Click(object sender, EventArgs e)
        {
            frmSearchHDNHAP f = new frmSearchHDNHAP();
            f.ShowDialog();
        }

        private void btnhdb_Click(object sender, EventArgs e)
        {
            frmSearchHDBAN f = new frmSearchHDBAN();
            f.ShowDialog();
        }
    }
}
