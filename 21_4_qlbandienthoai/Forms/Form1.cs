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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        qlbandienthoai ql = new qlbandienthoai();
        DataSet dsNV = new DataSet ();
        void danhSach_datagridView(DataGridView dg, string sql)
        {
            dsNV = ql.SelectData(sql);
            dg.DataSource = dsNV.Tables[0];
        }
        public void timkiemtennv()
        {
            danhSach_datagridView(dgvdanhsach, "select * from Nhanvien where Hotennv like '%" + txttennv.Text + "%'");
            /*hienthi_textbox(ds, index);*/
        }
        private void txttennv_TextChanged(object sender, EventArgs e)
        {
            timkiemtennv();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsNV = ql.SelectData("select * from Nhanvien");
        }
    }
}
