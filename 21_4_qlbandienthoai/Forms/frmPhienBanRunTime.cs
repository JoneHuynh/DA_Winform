using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace _21_4_qlbandienthoai.Forms
{
    public partial class frmPhienBanRunTime : Form
    {
        public frmPhienBanRunTime()
        {
            InitializeComponent();
        }

        qlbandienthoai ql = new qlbandienthoai();
        DataSet ds = new DataSet();

        private void frmPhienBanRunTime_Load(object sender, EventArgs e)
        {
            ds = ql.SelectData("select * from PHIENBAN where Trangthai = 0");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Name = ds.Tables[0].Rows[i]["MaPB"].ToString();
                chk.Text= ds.Tables[0].Rows[i]["TenPB"].ToString();
                flpphienban.Controls.Add(chk);
            }
        }
        public ArrayList dschonpb = new ArrayList();

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmPhienBan f = new frmPhienBan();
            f.Show();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chk in flpphienban.Controls)
            {
                if (chk.Checked)
                {
                    dschonpb.Add(chk);
                }
            }
        }
    }
}

    
