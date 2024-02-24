using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_4_qlbandienthoai
{
    public partial class frmSearchSP : Form
    {
        public frmSearchSP()
        {
            InitializeComponent();
        }

        qlbandienthoai ql = new qlbandienthoai();
        DataSet dsLoaiSP = new DataSet();
        DataSet dsSP = new DataSet();
        Boolean load = false;

        void ShowCombobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }
        private void frmSearchSP_Load(object sender, EventArgs e)
        {
            dsLoaiSP = ql.SelectData("select * from LOAISANPHAM");
            ShowCombobox(cboLoaiSP, dsLoaiSP, "Tenloai", "Maloai");
            load= true;
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                if (cboLoaiSP.SelectedIndex != -1)
                {
                    string maloai = cboLoaiSP.SelectedValue.ToString();
                    string sql = "select * from SANPHAM where Maloai='" + maloai + "'";
                    dsSP = ql.SelectData(sql);
                    dgvSearchSP.DataSource = dsSP.Tables[0];
                }
            }
        }
        void danhSach_datagridView(DataGridView dg, string sql)
        {
            dsSP = ql.SelectData(sql);
            dg.DataSource = dsSP.Tables[0];
        }
        public void timkiemtensp()
        {
            danhSach_datagridView(dgvSearchSP, "select * from SanPham where tensp like '%" + txttensp.Text + "%'");
            /*hienthi_textbox(ds, index);*/
        }
      /*  public void timKiemdungluong()
        {
            danhsach_datagridview(dgv_danhsach, "select * from SanPham where Dungluong like '%" + txtdungluong.Text + "%'");
            *//*hienthi_textbox(ds, index);*//*
        }*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cboLoaiSP.Text = "Tất cả sản phẩm ";
            timkiemtensp();
        }

        private void dgvSearchSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
