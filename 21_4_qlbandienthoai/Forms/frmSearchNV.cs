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
    public partial class frmSearchNV : Form
    {
        public frmSearchNV()
        {
            InitializeComponent();
        }
        qlbandienthoai ql = new qlbandienthoai();
        DataSet TenNV = new DataSet();
        DataSet dsSDT = new DataSet();
        Boolean load = false;

        void ShowCombobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        private void frmSearchNV_Load(object sender, EventArgs e)
        {
            TenNV = ql.SelectData("select * from NHANVIEN Where Trangthai = 0");
            ShowCombobox(cboTennv, TenNV, "Hotennv", "Manv");
            load = true;
        }

        private void cboTennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                if (cboTennv.SelectedIndex != -1)
                {
                    string manv = cboTennv.SelectedValue.ToString();
                    string sql = "select * from NHANVIEN where Manv='" + manv + "'";
                    dsSDT = ql.SelectData(sql);
                    dgvSearchNV.DataSource = dsSDT.Tables[0];
                }
            }
        }
        void danhSach_datagridView(DataGridView dg, string sql)
        {
            dsSDT = ql.SelectData(sql);
            dg.DataSource = dsSDT.Tables[0];
        }
        public void timkiemtennv()
        {
            danhSach_datagridView(dgvSearchNV, "select * from NHANVIEN where Sdt like '%" + txtsdt.Text + "%'");
            /*hienthi_textbox(ds, index);*/
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            cboTennv.Text = "Tất cả nhân viên";
            timkiemtennv();
        }
        /*  public void timKiemdungluong()
 {
     danhsach_datagridview(dgv_danhsach, "select * from SanPham where Dungluong like '%" + txtdungluong.Text + "%'");
     *//*hienthi_textbox(ds, index);*//*
 }*/
    }
}
