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
    public partial class frmPhienBan : Form
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
        public frmPhienBan()
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
            txtTenPB.ReadOnly = t;
        }

        void XoaDuLieu()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
        }

        private void cbotrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            XuLyChucNang(false);
            XuLyTextbox(false);
            txtMaPB.Text = PhatSinhMa();
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
                sql = "insert into PHIENBAN values('" + txtMaPB.Text + "', '" + txtTenPB.Text + "', 0)";
            }
            if (flag == 2)
            {
                sql = "update PHIENBAN set TenPB = '" + txtTenPB.Text + "', Trangthai = " + cbotrangthai.SelectedIndex + " where MaPB = '" + txtMaPB.Text + "'";
            }
            if (flag == 3)
            {
                sql = "update PHIENBAN set TrangThai = 1 where MaPB = '" + txtMaPB.Text + "'";
            }
            if (ql.UpdateData(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                vitri = 0;
                frmPhienBan_Load(sender, e);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            dgvDanhsach.Columns.Clear();
            frmPhienBan_Load(sender, e);
            XoaDuLieu();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ShowTextbox(DataSet ds, int vitri)
        {
            if (vitri >= 0 && vitri < ds.Tables[0].Rows.Count)
            {
                txtMaPB.Text = ds.Tables[0].Rows[vitri]["MaPB"].ToString();
                txtTenPB.Text = ds.Tables[0].Rows[vitri]["TenPB"].ToString();
            }
        }

        private void frmPhienBan_Load(object sender, EventArgs e)
        {
            XuLyChucNang(true);
            danhsach_datagridview(dgvDanhsach, "Select * from PHIENBAN where Trangthai = 0");
            
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ShowTextbox(ds,vitri);
        }

        string PhatSinhMa()
        {
            string MaPB = "";
            DataSet ds = ql.SelectData("select MaPB from PHIENBAN");
            MaPB = "PB" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaPB;
        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1 && e.ColumnIndex < dgvDanhsach.ColumnCount - 1)
                {
                    int vt = dgvDanhsach.CurrentRow.Index;
                    string MaPB = dgvDanhsach.CurrentRow.Cells[0].Value.ToString();
                    string TenPB = dgvDanhsach.CurrentRow.Cells[1].Value.ToString();
                    string sql = "update PHIENBAN set TenPB = '" + TenPB+ "' where MaPB= '" + MaPB+ "'";
                    if (ql.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        vitri = 0;
                        frmPhienBan_Load(sender, e);
                    }
                }
            }
        }

        private void txtMaPB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtTenPB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvDanhsach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ShowTextbox(ds, vitri);
        }
    }
}
