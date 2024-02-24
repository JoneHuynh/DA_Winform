using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _21_4_qlbandienthoai.Theme;

namespace _21_4_qlbandienthoai
{
    public partial class frmNhanVien : Form
    {
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        public frmNhanVien()
        {
            InitializeComponent();

        }

        void xuLyChucNang(Boolean giaTri)
        {
            btnthem.Enabled = giaTri;
            btnsua.Enabled = giaTri;
            btnluu.Enabled = !giaTri;
            btnhuy.Enabled = giaTri;
            btnxoa.Enabled = giaTri;

        }

        qlbandienthoai ql = new qlbandienthoai();
        int vitri = 0;
        int flag = 0;
        Boolean load = false;
        DataSet ds = new DataSet();
        DataSet dsNV = new DataSet();


        void ShowTextbox(DataSet ds, int vitri)
        {
            if (vitri >= 0 && vitri < ds.Tables[0].Rows.Count)
            {
                txtmanv.Text = ds.Tables[0].Rows[vitri]["Manv"].ToString();
                txtName.Text = ds.Tables[0].Rows[vitri]["Hotennv"].ToString();
                dtpNgaySinh.Text = ds.Tables[0].Rows[vitri]["Ngaysinh"].ToString();
                txtDC.Text = ds.Tables[0].Rows[vitri]["Dchi"].ToString();
                txtMail.Text = ds.Tables[0].Rows[vitri]["Email"].ToString();
                txtSDT.Text = ds.Tables[0].Rows[vitri]["Sdt"].ToString();
                string gioitinh= ds.Tables[0].Rows[vitri]["Gioitinh"].ToString();
                string Trangthai= ds.Tables[0].Rows[vitri]["Trangthai"].ToString();
                if (gioitinh == "0")
                    cboGT.Text = "Nam";
                else
                    cboGT.Text = "Nữ";
                if (Trangthai == "0")
                    cbotrangthai.Text = "Hoạt động";
                else
                    cbotrangthai.Text = "Không hoạt động";
            }
        }
        void danhSach_datagridView(DataGridView dg, string  sql)
        {
            ds = ql.SelectData(sql);
            dg.DataSource = ds.Tables[0];
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ShowTextbox(ds, vitri);
        }

        void xulytextbox(Boolean t)
        {
            txtmanv.ReadOnly = t;
            dtpNgaySinh.Enabled = !t;
        }

        void DeleteData()
        {
            txtmanv.Clear();
            txtName.Clear();
            dtpNgaySinh.Text = "";
            txtDC.Clear();
            txtMail.Clear();
            txtSDT.Clear();
            cboGT.SelectedValue = 0;
        }

        String phatsinhma()
        {
            string nv = "";
            DataSet dsnv = ql.SelectData("select Manv from NHANVIEN");
            nv = "NV" + ((dsnv.Tables[0].Rows.Count) + 1).ToString();
            return nv;
        }



        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Enabled = false;
            xuLyChucNang(true);
            danhSach_datagridView(dgvNV, "Select * from NHANVIEN Where Trangthai = 0");
            ShowTextbox(ds, vitri);
            load = true;
            //  ShowCombobox(cboLoaiSP, dsLoaisp, "Tenloai", "Maloai");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
           
            xulytextbox(false);
            DeleteData();
            txtmanv.Text = phatsinhma();
            //ShowCombobox(cboLoaiSP, dsLoaisp, "Tenloai", "Maloai");
            cbotrangthai.SelectedIndex = 0;
            cboGT.SelectedIndex = 0;
            flag = 1;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xulytextbox(true);
            string sql = "";
            if (flag == 1)
            {
                string manv = txtmanv.Text;
                string tennv = txtName.Text;
                
                string ngaysinh = dtpNgaySinh.Text;
                string diachi = txtDC.Text;
                string email = txtMail.Text;
                string sdt = txtSDT.Text;
                string trangthai = "0";

                sql = "insert into NHANVIEN values('" + manv + "','" + tennv + "','" + cboGT.SelectedIndex;
                sql += "','" + ngaysinh + "','" + diachi + "','" + email + "','" + sdt + "'," + trangthai + ")";
            }
            if (flag == 2)
            {
                sql = "update NHANVIEN set Hotennv=N'" + txtName.Text + "',Gioitinh=N'" + cboGT.SelectedValue + "',Ngaysinh= '" + dtpNgaySinh.Text;
                sql += "',Dchi= N'" + txtDC.Text + "',Email= '" + txtMail.Text + "',Sdt= '" + txtSDT.Text +"',Trangthai=" + cbotrangthai.SelectedIndex + " Where Manv ='"+txtmanv.Text+"'";
            }
            if (flag == 3)
            {
                sql = "update NHANVIEN set Trangthai= 1 where Manv='" + txtmanv.Text + "'";

            }
            if (ql.UpdateData(sql) > 0)
            {
                MessageBox.Show("Update thành công");
                frmNhanVien_Load(sender, e);

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(true);
            flag = 3;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(false);
            cboGT.SelectedIndex = 0;
            cbotrangthai.SelectedIndex = 0;
            flag = 2;
        }



        private void btnhuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvNV.CurrentRow.Index;//lấy vị trí
                    string manv = dgvNV.CurrentRow.Cells[0].Value.ToString();
                    string tennv = dgvNV.CurrentRow.Cells[1].Value.ToString();
                    string gioitinh = dgvNV.CurrentRow.Cells[2].Value.ToString();
                    string Ngaysinh = dgvNV.CurrentRow.Cells[3].Value.ToString();
                    string dchi = dgvNV.CurrentRow.Cells[4].Value.ToString();
                    string email = dgvNV.CurrentRow.Cells[5].Value.ToString();
                    string sdt = dgvNV.CurrentRow.Cells[6].Value.ToString();

                    string sql = "update NHANVIEN set Hotennv=N'" + tennv + "',Gioitinh=N'" + gioitinh + "',Ngaysinh=N'" + Ngaysinh + "',Dchi=N'" + dchi + "',Email='" + email + "',Sdt='" + sdt + "' where Manv ='" +  manv + "' ";
                    if (ql.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitri = 0;
                        frmNhanVien_Load(sender, e);
                    }
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
