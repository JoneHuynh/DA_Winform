using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _21_4_qlbandienthoai
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        int vitri = 0;
        DataSet dsKH= new DataSet();
        //****
        qlbandienthoai ql= new qlbandienthoai();
        int flag = 0;
        bool load = false;
        void danhSach_datagridView(DataGridView dg,string sql)
        {
            dsKH = ql.SelectData(sql);
            dg.DataSource = dsKH.Tables[0];
        }

        void xulytextbox(Boolean t)
        {
            txtmakh.ReadOnly = t;

        }

        void DeleteData()
        {
            txtmakh.Clear();
            txttenkh.Clear();
            cbogioitinh.SelectedValue = 0;
            txtemail.Clear();
            txtsdtkh.Clear();
            txtdiachi.Clear();
        }

        void xuLyChucNang(Boolean giaTri)
        {
            btnthem.Enabled = giaTri;
            btnsua.Enabled = giaTri;
            btnluu.Enabled = !giaTri;
            btnhuy.Enabled = giaTri;

        }
        void ShowTextbox(DataSet ds, int vt)
        {
            if (vitri >= 0 && vitri < ds.Tables[0].Rows.Count)
            {
                txtmakh.Text = ds.Tables[0].Rows[vt]["Makh"].ToString();
                txttenkh.Text = ds.Tables[0].Rows[vt]["Hotenkh"].ToString();
                txtdiachi.Text = ds.Tables[0].Rows[vt]["Dchi"].ToString();
                txtemail.Text = ds.Tables[0].Rows[vt]["Email"].ToString();
                txtsdtkh.Text = ds.Tables[0].Rows[vt]["Sdt"].ToString();
                string gioitinh = ds.Tables[0].Rows[vt]["Gioitinh"].ToString();
                string trangthai = ds.Tables[0].Rows[vt]["Trangthai"].ToString();
                if (gioitinh == "0")
                    cbogioitinh.Text = "Nam";
                else
                    cbogioitinh.Text = "Nữ";
                if (trangthai == "0")
                    cbotrangthai.Text = "Hoạt động";
                else
                    cbotrangthai.Text = "Không hoạt động";
            }
         

        }

        //**

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            danhSach_datagridView(dgvdanhsach, "select * from KHACHHANG Where Trangthai = 0");
            load = true;
        }

        String phatsinhma()
        {
            string maKH = "";
            dsKH =  ql.SelectData("select Makh from KHACHHANG Where Trangthai = 0");
            maKH = "KH" + ((dsKH.Tables[0].Rows.Count) + 1).ToString();
            return maKH;
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            DeleteData();
            txtmakh.Text = phatsinhma();
            xulytextbox(true);
            cbotrangthai.SelectedIndex = 0;
            cbogioitinh.SelectedIndex = 0;
            flag = 1;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            string sql = "";
            if(flag == 1)
            {
                sql = "insert into KHACHHANG values('" + txtmakh.Text + "','" + txttenkh.Text + "','" + cbogioitinh.SelectedValue + "','" + txtdiachi.Text + "','" + txtemail.Text + "','" + txtsdtkh.Text + "',0)";
            }
            if (flag == 2)
            {
                sql = "update KHACHHANG set Hotenkh =N'"+txttenkh.Text+"',Gioitinh ='"+cbogioitinh.SelectedIndex + "',Dchi =N'"+txtdiachi.Text+"',Email ='"+txtemail.Text+"',Sdt ='"+txtsdtkh.Text + "',Trangthai='" + cbotrangthai.SelectedIndex + "' where Makh='" + txtmakh.Text + "'";
            }
            if(flag == 3)
            {
                sql = "update KHACHHANG set Trangthai= 1 where Makh='" + txtmakh.Text + "'";
            }
            if (ql.UpdateData(sql) > 0)
            {
                MessageBox.Show("Update thành công");
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            cbotrangthai.SelectedIndex = 0;
            flag = 2;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            flag = 3;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtmakh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtsdtkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ShowTextbox(dsKH, vitri);
        }

        private void txtsdtkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdanhsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvdanhsach.CurrentRow.Index;//lấy vị trí
                    string makh = dgvdanhsach.CurrentRow.Cells[0].Value.ToString();
                    string tenkh = dgvdanhsach.CurrentRow.Cells[1].Value.ToString();
                    string gioitinh = dgvdanhsach.CurrentRow.Cells[2].Value.ToString();
                    string dchi = dgvdanhsach.CurrentRow.Cells[3].Value.ToString();
                    string email = dgvdanhsach.CurrentRow.Cells[4].Value.ToString();
                    string sdt = dgvdanhsach.CurrentRow.Cells[5].Value.ToString();

                    string sql = "update KHACHHANG set Hotenkh=N'" + tenkh + "',Gioitinh=N'" + gioitinh + "',Dchi=N'" + dchi + "',Email='" + email + "',Sdt='" + sdt + "' where Makh ='" + makh + "' ";
                    if (ql.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitri = 0;
                        frmKhachHang_Load(sender, e);
                    }
                }
            }
        }
    }
}