using _21_4_qlbandienthoai.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static _21_4_qlbandienthoai.Theme;
using System.Windows.Forms.VisualStyles;

namespace _21_4_qlbandienthoai
{
    public partial class frmSanPham : Form
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

        public frmSanPham()
        {
            InitializeComponent();
        }


        qlbandienthoai ql = new qlbandienthoai();
        int vitri = 0;
        int flag = 0; // các phím chức năng
        int tongsoluong = 0;
        Boolean load = false; // upload dữ liệu
        Boolean ThemCTSP = false;
        DataSet ds = new DataSet();
        DataSet dsSP = new DataSet();
        DataSet dsCTSP = new DataSet();
        DataSet dsLoaisp = new DataSet();
        DataSet dsNCC = new DataSet();
        DataSet dsMau = new DataSet();

        void danhSach_datagridView(DataGridView dgv, string sql)
        {
            ds = ql.SelectData(sql);
            dgv.DataSource = ds.Tables[0];
        }

        void xuLyChucNang(Boolean giaTri)
        {
            btnthem.Enabled = giaTri;
            btnsua.Enabled = giaTri;
            btnluu.Enabled = !giaTri;
            btnhuy.Enabled = giaTri;
            btnxoa.Enabled = giaTri;
            btnmau.Enabled = !giaTri;
            btnPhienban.Enabled = !giaTri;
            btnThemSP.Enabled = !giaTri;
            btnCTSP.Enabled = !giaTri;
        }
        void xulytextbox(Boolean t)
        {
            txtmasp.ReadOnly = !t;
            txttensp.ReadOnly = t;
            cboncc.Enabled = !t;
            cboLoaiSP.Enabled = !t;
            txtsoluongtonkho.ReadOnly = t;
            txtgiaban.ReadOnly = t;
            txtgianhap.ReadOnly = t;
            cbomau.Enabled = !t;
            txtsoluongct.ReadOnly = t;
            txtgialech.ReadOnly = t;

        }

        void DeleteData()
        {
            txtmasp.Clear();
            txttensp.Clear();
            rtxtMota.Clear();
            txtgiaban.Clear();
            txtgianhap.Clear();
            txtsoluongtonkho.Clear();
            picHinhSP.Image = null;
            cboncc.SelectedIndex = -1;
            cboLoaiSP.SelectedIndex = -1;
        }

        void load_CTSPtheoMa(string Masp)
        {
            string s = "select * from CT_SANPHAM where Masp ='" + Masp + "'";
            dsCTSP = ql.SelectData(s);
            dgvCTSP.DataSource = null;
            dgvCTSP.Columns.Clear();
            dgvCTSP.DataSource = dsCTSP.Tables[0];
        }

        void ShowTextbox(DataSet ds, int vitri)
        {
            //if (vitri >= 0 && vitri < dgv.Rows.Count)
            //{
            //    txtmasp.Text = dgv.Rows[vitri].Cells["Masp"].Value.ToString();
            //    txttensp.Text = dgv.Rows[vitri].Cells["Tensp"].Value.ToString();
            //    rtxtMota.Text = dgv.Rows[vitri].Cells["Mota"].Value.ToString();
            //    txtgiaban.Text = dgv.Rows[vitri].Cells["GiaBan"].Value.ToString();
            //    txtgianhap.Text = dgv.Rows[vitri].Cells["GiaNhap"].Value.ToString();
            //    txtsoluongtonkho.Text = dgv.Rows[vitri].Cells["Soluongtonkho"].Value.ToString();

            //    string mancc = dgv.Rows[vitri].Cells["Mancc"].Value.ToString();
            //    string maloai = dgv.Rows[vitri].Cells["Maloai"].Value.ToString();
            //    string trangthai = dgv.Rows[vitri].Cells["Trangthai"].Value.ToString();
            //    FilterData(dsLoaisp, cboLoaiSP, "Tenloai", "Maloai", maloai);
            //    FilterData(dsNCC, cboncc, "Tenncc", "Mancc", mancc);
            //    txtmasp.Text = dgv.Rows[vitri].Cells["Masp"].Value.ToString();
            //    string Image = dgv.Rows[vitri].Cells["Hinh"].Value.ToString();
            //    //string path = Path.GetFullPath("ImageProduct") + @"\" + Image;
            //    CreateFileImage(picHinhSP, Image);

            //    load_CTSPtheoMa(dgv.Rows[vitri].Cells["Masp"].Value.ToString());
            //}

            if (vitri >= 0 && vitri < ds.Tables[0].Rows.Count)
            {
                txtmasp.Text = ds.Tables[0].Rows[vitri]["Masp"].ToString();
                txttensp.Text = ds.Tables[0].Rows[vitri]["Tensp"].ToString();
                rtxtMota.Text = ds.Tables[0].Rows[vitri]["Mota"].ToString();
                txtgiaban.Text = ds.Tables[0].Rows[vitri]["GiaBan"].ToString();
                txtgianhap.Text = ds.Tables[0].Rows[vitri]["GiaNhap"].ToString();
                txtsoluongtonkho.Text = ds.Tables[0].Rows[vitri]["Soluongtonkho"].ToString();

                string mancc = ds.Tables[0].Rows[vitri]["Mancc"].ToString();
                string maloai = ds.Tables[0].Rows[vitri]["Maloai"].ToString();
                string trangthai = ds.Tables[0].Rows[vitri]["Trangthai"].ToString();
                
                txtmasp.Text = ds.Tables[0].Rows[vitri]["Masp"].ToString();
                string Image = ds.Tables[0].Rows[vitri]["Hinh"].ToString();
                //string path = Path.GetFullPath("ImageProduct") + @"\" + Image;
                CreateFileImage(picHinhSP, Image);
                cbotrangthai.SelectedValue = ds.Tables[0].Rows[vitri]["Trangthai"].ToString();
                if (cbotrangthai.Text == "1")
                {
                    cbotrangthai.Text = "Không hoạt động";
                }
                else
                {
                    cbotrangthai.Text = "Hoạt động";

                }
                load_CTSPtheoMa(ds.Tables[0].Rows[vitri]["Masp"].ToString());
                FilterData(dsLoaisp, cboLoaiSP, "Tenloai", "Maloai", maloai);
                FilterData(dsNCC, cboncc, "Tenncc", "Mancc", mancc);

            }

        }

        String phatsinhma()
        {
           string SP = "";
          ds = ql.SelectData("select Masp from SANPHAM");
            SP = "SP" + ((ds.Tables[0].Rows.Count) + 1).ToString();
            return SP;
        }

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
            dv.RowFilter =  ma+"='"+ giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuLyChucNang(true);
            btnThemSP.Visible = true;

            danhSach_datagridView(dgvdanhsach, "Select * from SANPHAM where Trangthai = 0");
            dsNCC = ql.SelectData("Select * from NHACUNGCAP where Trangthai = 0");
            dsLoaisp = ql.SelectData("Select * from LOAISANPHAM where Trangthai = 0");
            dsMau = ql.SelectData("Select * from MAU where Trangthai = 0");
            ShowCombobox(cboncc, dsNCC, "Tenncc", "Mancc");
            ShowCombobox(cboLoaiSP, dsLoaisp, "Tenloai", "Maloai");
            load = true;
        }

        private void FrmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmasp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            xuLyChucNang(false);
           txtmasp.Text = phatsinhma();
            xulytextbox(false);
            DeleteData();
            txtsoluongtonkho.ReadOnly = false;
            txtgiaban.ReadOnly = true;

            ShowCombobox(cboLoaiSP, dsLoaisp, "Tenloai", "Maloai");
            ShowCombobox(cboncc, dsNCC, "Tenncc", "Mancc");
            ShowCombobox(cbomau, dsMau, "Tenmau", "Mamau");
            dgvdanhsach.DataSource = null;
            dgvCTSP.DataSource = null;
            CreateColumnProduct();
            CreateDetailsProduct();
            cbotrangthai.SelectedIndex = 0;
            flag = 1;
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xulytextbox(true);
            string sql = "";
            if (flag == 1) // add Product
            {
                string masp = txtmasp.Text;
                string tensp = txttensp.Text;
                string mahinh = "ImageProduct/" + masp + ".jpg";// lblMaImage.Text;
                string mota = rtxtMota.Text;
                string soluong = txtsoluongtonkho.Text;
                //string soluong =  string.IsNullOrWhiteSpace(txtsoluongtonkho.Text)?"NULL": txtsoluongtonkho.Text;
                string giaban = txtgiaban.Text;
                string gianhap = txtgianhap.Text;
                string mancc = cboncc.SelectedValue.ToString();
                string maloai = cboLoaiSP.SelectedValue.ToString();
                string trangthai = "0";

                string s = "insert into SANPHAM values('" + masp + "',N'" + tensp;
                s += "','" + mahinh + "',N'" + mota + "'," + soluong;
                s += "," + giaban + "," + gianhap + ",'" + mancc + "','" + maloai + "'," + trangthai + ")";
                if (picHinhSP.Image != null)
                {
                    picHinhSP.Image.Save(mahinh);
                }
                if (ql.UpdateData(s) > 0)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công");
                    for (int i = 0; i < dgvCTSP.Rows.Count - 1; i++)
                    {
                        string mactsp = dgvCTSP.Rows[i].Cells[0].Value.ToString();
                        string mamau = dgvCTSP.Rows[i].Cells[2].Value.ToString();
                        string mapb = dgvCTSP.Rows[i].Cells[3].Value.ToString();
                        string sluong = dgvCTSP.Rows[i].Cells[4].Value.ToString();
                        string gban = dgvCTSP.Rows[i].Cells[5].Value.ToString();
                        string hinh = dgvCTSP.Rows[i].Cells[6].Value.ToString();

                        string CTSP = " insert into CT_SANPHAM values('" + mactsp + "','" + masp + "','" + mamau;
                        CTSP += "','" + mapb + "','" + hinh + "'," + sluong + "," + gban + "," + trangthai + ")";
                        if (ql.UpdateData(CTSP) > 0)
                        {
                            MessageBox.Show("Cập nhật CT sản phẩm thành công");
                        }
                    }
                }
                btnhuy_Click_1(sender, e);
            }
            if (flag == 2)
            {
                sql = "update SANPHAM set Tensp = N'" + txttensp.Text + "', Hinh= '" + lblMaImage.Text +
                    "',Mota= N'" + rtxtMota.Text + "',Soluongtonkho= " + txtsoluongtonkho.Text +
                    ",GiaNhap= " + txtgianhap.Text + ",GiaBan=" + txtgiaban.Text + ",Mancc='" + cboncc.SelectedValue +
                    "', Maloai='" + cboLoaiSP.SelectedValue + "', Trangthai = " + cbotrangthai.SelectedIndex + " where Masp = '" + txtmasp.Text + "'";

            }
            if (flag == 3)
            {
                sql = "update SANPHAM set Trangthai= 1 where Masp='" + txtmasp.Text + "'";


            }
            flag = 0;

            FrmSanPham_Load(sender, e);
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(false);
            cbotrangthai.SelectedIndex = 0;
            flag = 2;
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(true);
            DeleteData();
            flag = 3;
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            dgvdanhsach.Columns.Clear();
            dgvCTSP.Columns.Clear();
            FrmSanPham_Load(sender, e);
            DeleteData();
        }


        private void cboncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                if (cboncc.SelectedIndex != -1)
                {
                    string mancc = cboncc.SelectedValue.ToString();
                    string sql = "select Masp from SANPHAM where Mancc ='" + mancc + "'";
                    DataSet ds = ql.SelectData(sql);
                    string masp = "";
                    if (ds.Tables[0].Rows.Count < 9)
                    {
                        masp = mancc + "-SP0" + (ds.Tables[0].Rows.Count + 1).ToString();
                    }
                    else
                    {
                        masp = mancc + "-SP" + (ds.Tables[0].Rows.Count + 1).ToString();
                    }
                    txtmasp.Text = masp;
                }
            }
        }

        void CreateDetailsProduct()
        {
            dgvCTSP.Columns.Clear();
            dgvCTSP.Columns.Add("MaCTSP", "Mã CTSP");
            dgvCTSP.Columns.Add("MasP", "Mã SP");
            dgvCTSP.Columns.Add("Mamau", "Mã màu");
            dgvCTSP.Columns.Add("MaPB", "Mã phiên bản");
            dgvCTSP.Columns.Add("Soluong", "Số lượng");
            dgvCTSP.Columns.Add("Gia", "Giá bán");
            dgvCTSP.Columns.Add("Trangthai", "Trạng thái");
        }

        void CreateFileImage(PictureBox pic, string filename)
        {
            Bitmap bm = new Bitmap(filename);
            picHinhSP.Image = bm;
            picHinhSP.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLoadanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFullPath("ImageProduct") + @"\";
            DialogResult dr = o.ShowDialog();

            if (dr != DialogResult.Cancel)
            {
                //string filename = o.FileName;
                //string[] NameImage = filename.Split('\\');
                //lblMaImage.Text = NameImage[10] + @"\" + NameImage[11];

                lblMaImage.Text = o.FileName;
                CreateFileImage(picHinhSP, o.FileName);
                btnthem.Visible = true;
            }

        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                    if (cboLoaiSP.SelectedIndex != -1)
                    {
                        string maloai = cboLoaiSP.SelectedValue.ToString();
                        dsNCC = ql.SelectData("select * from NHACUNGCAP where Maloai= '" + maloai + "'");
                        ShowCombobox(cboncc, dsNCC, "Tenncc", "Mancc");
                    }
            }
        }

        private void dgvdanhsach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picHinhSP_Click(object sender, EventArgs e)
        {
            btnLoadanh_Click(sender, e);
        }

        private void txtgianhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float gianhap = int.Parse(txtgianhap.Text);
                txtgiaban.Text = (gianhap * 2).ToString();
            }
        }

        private void btnPhienban_Click(object sender, EventArgs e)
        {
            frmPhienBanRunTime f = new frmPhienBanRunTime();
            if (f.ShowDialog() == DialogResult.OK)
            {
                flpPhienban.Controls.Clear();
                foreach (CheckBox chk in f.dschonpb)
                {
                    flpPhienban.Controls.Add(chk);
                }
            }
        }

        private void btnCTSP_Click(object sender, EventArgs e)
        {
            object[] d = new object[8];
            int tongsoluong = 0;
            foreach (CheckBox c in flpPhienban.Controls)
            {
                d[0] = txtmasp.Text + "." + c.Name + "." + cbomau.SelectedValue.ToString();
                d[1] = txtmasp.Text;
                d[2] = cbomau.SelectedValue.ToString();
                d[3] = c.Name;              
                d[4] = txtsoluongct.Text;
                if (txtgialech.Text == "")
                {
                    d[4] = txtgiaban.Text;
                }
                else
                {
                    float giaban = float.Parse(txtgiaban.Text) + float.Parse(txtgialech.Text);
                    d[5] = giaban.ToString();
                }
                d[6] = "0";
                tongsoluong += int.Parse(txtsoluongct.Text);
                txtsoluongtonkho.Text = tongsoluong.ToString();
                dgvCTSP.Rows.Add(d);
            }
        }

        void CreateColumnProduct()
        {
            dgvdanhsach.Columns.Clear();
            dgvdanhsach.DataSource = null;
            dgvdanhsach.Columns.Add("Maso", "Mã sản phẩm");
            dgvdanhsach.Columns.Add("Tensp", "Tên sản phẩm");
            dgvdanhsach.Columns.Add("Maloai", "Mã loại");
            dgvdanhsach.Columns.Add("Mancc", "Mã NCC");
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            object[] d = new object[4];
            d[0] = txtmasp.Text;
            d[1] = txttensp.Text;
            d[2] = cboLoaiSP.SelectedValue.ToString();
            d[3] = cboncc.SelectedValue.ToString();
            dgvdanhsach.Rows.Add(d);
        }



        private void btnmau_Click(object sender, EventArgs e)
        {
            frmMau f = new frmMau();
            f.Show();
        }

        private void dgvCTSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (flag == 1)//Thêm
                {
                    if (e.ColumnIndex == 4)
                    {
                        int Tong = 0;
                        for (int i = 0; i < dgvCTSP.Rows.Count; i++)
                        {
                            Tong += int.Parse(dgvCTSP.Rows[i].Cells[4].Value.ToString());

                        }
                        txtsoluongtonkho.Text = Tong.ToString();
                    }
                }
            }
        }

        private void cbomau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsoluongtonkho_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdanhsach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ShowTextbox(ds, vitri);
        }

        void ShowCTTextbox(DataSet ds, int vitri)
        {
            if (vitri >= 0 && vitri < ds.Tables[0].Rows.Count)
            {

                string mau = dsCTSP.Tables[0].Rows[vitri]["Mamau"].ToString();
                string phienban = dsCTSP.Tables[0].Rows[vitri]["MaPB"].ToString();
                txtsoluongct.Text = dsCTSP.Tables[0].Rows[vitri]["Soluong"].ToString();
                txtgialech.Text = dsCTSP.Tables[0].Rows[vitri]["Gia"].ToString();
                FilterData(dsMau, cbomau, "Tenmau", "Mamau", mau);
            }
        }

        private void dgvCTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( load)
            {
                vitri = e.RowIndex;
                ShowCTTextbox(ds, vitri);
            }
        }

        private void dgvdanhsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvdanhsach.CurrentRow.Index;//lấy vị trí
                    string masp = dgvdanhsach.CurrentRow.Cells[0].Value.ToString();
                    string tensp = dgvdanhsach.CurrentRow.Cells[1].Value.ToString();
                   // string hinh = dgvdanhsach.CurrentRow.Cells[2].Value.ToString();
                    string mota = dgvdanhsach.CurrentRow.Cells[3].Value.ToString();
                    //string soluong = dgvdanhsach.CurrentRow.Cells[4].Value.ToString();
                    string gianhap = dgvdanhsach.CurrentRow.Cells[5].Value.ToString();
                    string giaban = dgvdanhsach.CurrentRow.Cells[6].Value.ToString();
                    //string mancc = dgvdanhsach.CurrentRow.Cells[7].Value.ToString();
                    //string maloai = dgvdanhsach.CurrentRow.Cells[8].Value.ToString();
                    //string trangthai = dgvdanhsach.CurrentRow.Cells[9].Value.ToString();

                    string sql = "update SANPHAM set Tensp=N'" + tensp + "',Mota=N'" + mota + "',GiaNhap=" + gianhap + ",GiaBan=" + giaban + "where Masp ='" + masp + "' ";
                    if (ql.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitri = 0;
                        FrmSanPham_Load(sender, e);
                    }
                }
            }
        }
    }
}
