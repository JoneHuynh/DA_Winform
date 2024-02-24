using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _21_4_qlbandienthoai
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        qlbandienthoai ql = new qlbandienthoai();
        int vitri = 0;
        int flag = 0;
        DataSet ds = new DataSet();
        DataSet dsNCC = new DataSet();
        DataSet dsLoaiCH = new DataSet();
        DataSet dsLoaisp = new DataSet();

        void DS_datagridview(DataGridView d, string sql)
        {
            ds = ql.SelectData(sql);
            d.DataSource = ds.Tables[0];
        }

        void ShowTextbox(DataSet ds, int vitri)
        {
            if (vitri >= 0 && vitri < ds.Tables[0].Rows.Count)
            {
                txtNCC.Text = ds.Tables[0].Rows[vitri]["Mancc"].ToString();
                txtNameNCC.Text = ds.Tables[0].Rows[vitri]["Tenncc"].ToString();
                txtDiachi.Text = ds.Tables[0].Rows[vitri]["Dchi"].ToString();
                txtMail.Text = ds.Tables[0].Rows[vitri]["Email"].ToString();
                txtSDT.Text = ds.Tables[0].Rows[vitri]["Sdt"].ToString();
               
                string trangthai  = ds.Tables[0].Rows[vitri]["Trangthai"].ToString();
                string maloai = ds.Tables[0].Rows[vitri]["Maloai"].ToString();
              //cboLoaiSP.Text = ds.Tables[0].Rows[vitri]["Maloai"].ToString();
                if (trangthai == "0")
                    cbotrangthai.Text = "Hoạt động";
                else
                    cbotrangthai.Text = "Không hoạt động";
                FilterData(dsLoaisp, cboLoaiSP, "Tenloai", "Maloai", maloai);

                //// Loai sp
                //DataView dvloaisp = new DataView();
                //dvloaisp.Table = dsLoaisp.Tables[0];
                //dvloaisp.RowFilter = "Masp = '" + masp + "'";
                //cboLoaiSP.DataSource = dvloaisp;
                //cboLoaiSP.DisplayMember = "Tensp";
                //cboLoaiSP.ValueMember = "Masp";
            }
        }


        void xulytextbox(Boolean t)
        {
            txtNCC.ReadOnly = t;
        }

        void xuLyChucNang(Boolean giaTri)
        {
            btnthem.Enabled = giaTri;
            btnsua.Enabled = giaTri;
            btnluu.Enabled = !giaTri;
            btnhuy.Enabled = giaTri;
            btnxoa.Enabled = giaTri;
        }

        String phatsinhma()
        {
            string MaNCC = "";
            ds = ql.SelectData("select Mancc from NHACUNGCAP");
            MaNCC ="NCC" + ((ds.Tables[0].Rows.Count) + 1).ToString();
            return MaNCC;
        }

        Boolean load = false;

        void ShowCombobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        void FilterData(DataSet ds, ComboBox cbo, string ten, string ma, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = $"{ma} = '{giatrima}'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            DS_datagridview(dgvNCC, "select * from NHACUNGCAP Where Trangthai = 0");
            dsLoaisp = ql.SelectData("select * from LOAISANPHAM Where Trangthai = 0");
            ShowCombobox(cboLoaiSP, dsLoaisp, "Tenloai", "Maloai");
            load = true;
        }



        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ShowTextbox(ds, vitri);
        }

        void DeleteData()
        {
            txtNCC.Clear();
            txtNameNCC.Clear();
            txtDiachi.Clear();
            txtMail.Clear();
            txtSDT.Clear();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(true);
            DeleteData();
            txtNCC.Text = phatsinhma();
            cbotrangthai.SelectedIndex = 0;
            flag = 1;
        }


        private void btnluu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xulytextbox(true);
            string sql = "";
            if (flag == 1)
            {
                sql = "insert into NHACUNGCAP values('" + txtNCC.Text + "','" + txtNameNCC.Text + "','" + txtDiachi.Text + "', '" + txtMail.Text + "','" + txtSDT.Text + "','" + cboLoaiSP.SelectedValue + "',1)";
            }
            if (flag == 2)
            {
                sql = "update NHACUNGCAP set Tenncc='" + txtNameNCC.Text + "',Dchi='" + txtDiachi.Text + "',Email= '" + txtMail.Text + "',Sdt='" + txtSDT.Text + "',Trangthai='" + cbotrangthai.Text + "' where Mancc='" + txtNCC.Text + "'";
            }
            if (flag == 3)
            {
                sql = "update NHACUNGCAP set Trangthai= 1 where Mancc='" + txtNCC.Text + "'";

            }
            if (ql.UpdateData(sql) > 0)
            {
                MessageBox.Show("Update thành công");
                frmNhaCungCap_Load(sender, e);
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            flag = 3;
            xuLyChucNang(false);
            xulytextbox(true);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(false);
            cbotrangthai.SelectedIndex = 0;
            flag = 2;
        }

        private void frmNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void dgvNCC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvNCC.CurrentRow.Index;//lấy vị trí
                    string mancc = dgvNCC.CurrentRow.Cells[0].Value.ToString();
                    string tenncc = dgvNCC.CurrentRow.Cells[1].Value.ToString();
                    string dchi = dgvNCC.CurrentRow.Cells[2].Value.ToString();
                    string email = dgvNCC.CurrentRow.Cells[3].Value.ToString();
                    string sdt = dgvNCC.CurrentRow.Cells[4].Value.ToString();

                    string sql = "update NHACUNGCAP set Tenncc=N'" + tenncc + "',Dchi=N'" + dchi + "',Email='" + email + "',Sdt='" + sdt + "' where Mancc ='" + mancc + "' ";
                    if (ql.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitri = 0;
                        frmNhaCungCap_Load(sender, e);
                    }
                }
            }
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                if (cboLoaiSP.SelectedIndex != -1)
                {
                    string maloai = cboLoaiSP.SelectedValue.ToString();
                    dsLoaisp = ql.SelectData("select * from LOAISANPHAM where Maloai='" + maloai + "'");
                    //ShowCombobox(cboLoaiSP, dsLoaisp, "Tenloai", "Maloai");
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
