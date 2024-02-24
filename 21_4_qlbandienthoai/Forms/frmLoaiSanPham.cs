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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        //****
        int vitri = 0;
        DataSet ds = new DataSet();
        //****
        qlbandienthoai ql = new qlbandienthoai();
        void danhSach_datagridView(DataGridView dg, string sql)
        {
            ds = ql.SelectData(sql);
            dg.DataSource = ds.Tables[0];
        }



        void xulytextbox(Boolean t)
        {
            txtmaloaisp.ReadOnly = t;
            txttenloai.ReadOnly = t;
        }
  

        //**
        void ShowTextbox(DataSet ds, int vt)
        {
            if(vt >= 0 && vt < ds.Tables[0].Rows.Count)
            {
                txtmaloaisp.Text = ds.Tables[0].Rows[vt]["Maloai"].ToString();
                txttenloai.Text = ds.Tables[0].Rows[vt]["Tenloai"].ToString();
                string trangthai = ds.Tables[0].Rows[vt]["Trangthai"].ToString();
                if (trangthai == "0")
                    cbotrangthai.Text = "Hoạt động";
                else
                    cbotrangthai.Text = "Không hoạt động";
            }
        }

        void xuLyChucNang(Boolean giaTri)
        {
            btnthem.Enabled = giaTri;
            btnsua.Enabled = giaTri;
            btnluu.Enabled = !giaTri;
            btnhuy.Enabled = giaTri;
            btnxoa.Enabled = giaTri;
        }
        //**

        String phatsinhma()
        {
            string MaNCC = "";
            ds = ql.SelectData("select Maloai from LOAISANPHAM Where Trangthai = 0");
            MaNCC ="LSP-"+ ((ds.Tables[0].Rows.Count) + 1).ToString();
            return MaNCC;
        }
        Boolean load = false;

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            
            danhSach_datagridView(dgvdanhsach, "Select *from LOAISANPHAM Where Trangthai = 0");
            load = true;
        }

        
        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            xuLyChucNang(false);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            txtmaloaisp.Text = phatsinhma();
            xulytextbox(false);
            cbotrangthai.SelectedIndex= 0;
            flag = 1;
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(true);
            flag = 3;
        }

        int flag = 0;

        private void btnluu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xulytextbox(true);
            string sql = "";
            if(flag == 1)
            {
                sql = "insert into LOAISANPHAM values ('" + txtmaloaisp.Text + "','" + txttenloai.Text + "',1)";
            }
            if(flag == 2)
            {
                sql = "update LOAISANPHAM set Tenloai='" + txttenloai.Text + "',Trangthai =" + cbotrangthai.Text + " where Maloai='" + txtmaloaisp.Text + "'";
            }
            if(flag==3)
            {

                sql = "update LOAISANPHAM set Trangthai = 0 where Maloai='" + txtmaloaisp.Text + "'";
            }
            if(ql.UpdateData(sql) > 0)
            {
                MessageBox.Show("Update thành công");
                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(false);
            flag = 2;
        }

        private void frmLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtmaloaisp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ShowTextbox(ds,vitri);
        }

        private void txttenloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdanhsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if(e.ColumnIndex >= 1)
                {
                    int vt = dgvdanhsach.CurrentRow.Index;
                    string maloai = dgvdanhsach.CurrentRow.Cells[0].ToString();
                    string tenloai = dgvdanhsach.CurrentRow.Cells[1].ToString();
                    string sql = "update LOAISANPHAM set Tenloai='" + tenloai + "'where Maloai='" + maloai + "'";
                    if(ql.UpdateData(sql)>0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        frmLoaiSanPham_Load(sender, e);
                    }
                }
            }
        }

        private void txtmaloaisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
