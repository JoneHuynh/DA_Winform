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
    public partial class frmSearchKH : Form
    {
        public frmSearchKH()
        {
            InitializeComponent();
        }
        qlbandienthoai ql = new qlbandienthoai();
        DataSet TenKH = new DataSet();
        DataSet dsSDT = new DataSet();
        Boolean load = false;

        void ShowCombobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        private void frmSearchKH_Load(object sender, EventArgs e)
        {
            TenKH = ql.SelectData("select * from KHACHHANG Where Trangthai = 0");
            ShowCombobox(cboTenkh, TenKH, "Hotenkh", "Makh");
            load = true;
        }

        void danhSach_datagridView(DataGridView dg, string sql)
        {
            dsSDT = ql.SelectData(sql);
            dg.DataSource = dsSDT.Tables[0];
        }
        public void timkiemTenKH()
        {
            danhSach_datagridView(dgvSearchKH, "select * from KHACHHANG where Sdt like '%" + txtsdt.Text + "%'");
            /*hienthi_textbox(ds, index);*/
        }


        private void cboTenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                if (cboTenkh.SelectedIndex != -1)
                {
                    string makh = cboTenkh.SelectedValue.ToString();
                    string sql = "select * from KHACHHANG where Makh='" + makh + "'";
                    dsSDT = ql.SelectData(sql);
                    dgvSearchKH.DataSource = dsSDT.Tables[0];
                }
            }
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            cboTenkh.Text = "Tất cả nhân viên";
            timkiemTenKH();
        }


        /*  public void timKiemdungluong()
{
danhsach_datagridview(dgv_danhsach, "select * from SanPham where Dungluong like '%" + txtdungluong.Text + "%'");
*//*hienthi_textbox(ds, index);*//*
}*/
    }
}
