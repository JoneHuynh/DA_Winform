using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _21_4_qlbandienthoai.Theme;

namespace _21_4_qlbandienthoai.Forms
{
    public partial class frmMau : Form
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
        public frmMau()
        {
            InitializeComponent();
        }

        qlbandienthoai ql = new qlbandienthoai();
        int vitri = 0;
        int flag = 0;
        DataSet ds = new DataSet();

        Boolean load = false;
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = ql.SelectData(sql);
            d.DataSource = ds.Tables[0];
        }

        void XuLyChucNang(Boolean t)
        {
            btnthem.Enabled = t;
            btnxoa.Enabled = t;
            btnsua.Enabled = t;
            btnluu.Enabled = !t;
        }

        void XuLyTextbox(Boolean t)
        {
            txtTenmau.ReadOnly = t;
        }

        void XoaDuLieu()
        {
            txtMamau.Clear();
            txtTenmau.Clear();
        }

        string PhatSinhMa()
        {
            string Mamau = "";
            DataSet ds = ql.SelectData("select Mamau from MAU Where Trangthai = 0");
            Mamau = "MM" + (ds.Tables[0].Rows.Count + 1).ToString();
            return Mamau;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            XuLyChucNang(false);
            XuLyTextbox(false);
            txtMamau.Text = PhatSinhMa();
            cbotrangthai.SelectedIndex = 0;
            flag = 1;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            XuLyChucNang(false);
            DialogResult HoiThoat;
            HoiThoat = MessageBox.Show("Bạn có muốn xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (HoiThoat == DialogResult.Yes)
            {
                flag = 3;
            }
            else
            {
                XuLyChucNang(true);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            XuLyChucNang(false);
            XuLyTextbox(false);
            cbotrangthai.SelectedIndex = 0;
            flag = 2;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            XuLyChucNang(true);
            XuLyTextbox(true);
            string sql = "";
            if (flag == 1)
            {
                sql = "insert into MAU values('" + txtMamau.Text + "', '" + txtTenmau.Text + "', 0)";
            }
            if (flag == 2)
            {
                sql = "update MAU set Tenmau = '" + txtTenmau.Text + "', Trangthai = " + cbotrangthai.SelectedIndex + " where Mamau = '" + txtMamau.Text + "'";
            }
            if (flag == 3)
            {
                sql = "update MAU set TrangThai = 1 where Mamau = '" + txtMamau.Text + "'";
            }
            if (ql.UpdateData(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                vitri = 0;
                frmMau_Load(sender, e);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            dgvDanhsach.Columns.Clear();
            frmMau_Load(sender, e);
            XoaDuLieu();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMau_Load(object sender, EventArgs e)
        {
            XuLyChucNang(true);
            danhsach_datagridview(dgvDanhsach, "Select * from MAU ");
        }

        void ShowTextbox(DataSet ds, int vitri)
        {
            if (vitri > 0 && vitri < ds.Tables[0].Rows.Count)
            {
                txtMamau.Text = ds.Tables[0].Rows[vitri]["Mamau"].ToString();
                txtTenmau.Text = ds.Tables[0].Rows[vitri]["Tenmau"].ToString();

            }
            string trangthai = ds.Tables[0].Rows[vitri]["Trangthai"].ToString();
            if(trangthai =="0")
            {
                cbotrangthai.Text = "Hoạt động";
            }
            else
            {
                cbotrangthai.Text = "Không hoạt động";
            }
         
        }
        private void txtMamau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtTenmau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void dgvDanhsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1 && e.ColumnIndex < dgvDanhsach.ColumnCount - 1)
                {
                    int vt = dgvDanhsach.CurrentRow.Index;
                    string MaMau = dgvDanhsach.CurrentRow.Cells[0].Value.ToString();
                    string TenMau = dgvDanhsach.CurrentRow.Cells[1].Value.ToString();
                    string sql = "update Mau set TenMau = N'" + TenMau + "' where MaMau = '" + MaMau + "'";
                    if (ql.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        vitri = 0;
                        frmMau_Load(sender, e);
                    }
                }
            }
        }

        private void dgvDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ShowTextbox(ds, vitri);
        }
    }
}
