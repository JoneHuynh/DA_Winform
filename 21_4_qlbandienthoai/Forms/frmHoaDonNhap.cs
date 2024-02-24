using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _21_4_qlbandienthoai.Theme;

namespace _21_4_qlbandienthoai.Forms
{
    public partial class frmHoaDonNhap : Form
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
        
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        int flag = 0;
        int vitri = 0;
        DataSet ds = new DataSet();
        DataSet dsNV = new DataSet();
        DataSet dsNCC = new DataSet();
        DataSet dsSP = new DataSet();
        DataSet dsCTHD = new DataSet();
        DataSet dsCTSP = new DataSet();
        DataSet dsHDN = new DataSet();

        Boolean load = false;
        string sql = "";

        qlbandienthoai ql = new qlbandienthoai();

        Boolean timKhachHang()
        {
            DataSet ds = new DataSet();
            ds = ql.SelectData("select * from NhaCungCap where Sdt = '" + txtsdt.Text + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                cbomancc.Text = ds.Tables[0].Rows[0]["TenNCC"].ToString();
                return true;
            }
            return false;
        }


        void danhSach_datagridView(DataGridView dg, string sql)
        {
            ds = ql.SelectData(sql);
            dg.DataSource = ds.Tables[0];
        }

        String phatsinhma()
        {
            string hdnhap = "";
            DataSet dsHDN = ql.SelectData("Select Mahdnhap from HOADON_NHAP");
            hdnhap = "HDN" + ((dsHDN.Tables[0].Rows.Count) + 1).ToString();
            return hdnhap;
        }
        

        void xuLyChucNang(Boolean giaTri)
        {
            btnthem.Enabled = giaTri;
            btnsua.Enabled = giaTri;
            btnluu.Enabled = giaTri;
            btnhuy.Enabled = giaTri;
            btnxoa.Enabled = giaTri;
            
        }

        void xulytextbox(Boolean t)
        {
            txtmahd.ReadOnly = t;
            dtpNgaylapHD.Enabled = !t;
            txtsdt.ReadOnly = t;
            cbomancc.Enabled= !t;
            cbotennv.Enabled = !t;
            txtmactsp.ReadOnly = t;
            txtmahd.ReadOnly = t;
        }

        void DeleteData()
        {
            txtmahd.Clear();
            txtsdt.Clear();
            cbotennv.SelectedIndex = -1; ;
            cbomancc.SelectedIndex = -1; ;
            txtTongTien.Clear();
        }

        void FilterData(DataSet ds1, ComboBox cbo, string ten, string ma, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds1.Tables[0];
            dv.RowFilter = $"{ma} = '{giatrima}'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        void ShowCombobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        void Showtextbox(DataSet ds, int vitri)
        {
            if (vitri >= 0 && vitri < ds.Tables[0].Rows.Count)
            {
                txtmahd. Text = ds.Tables[0].Rows[vitri]["Mahdnhap"].ToString();
                dtpNgaylapHD.Text = ds.Tables[0].Rows[vitri]["Ngaylaphd"].ToString();

                string mancc = ds.Tables[0].Rows[vitri]["Mancc"].ToString();
                string manv = ds.Tables[0].Rows[vitri]["Manv"].ToString();
                cbotrangthai.Text = ds.Tables[0].Rows[vitri]["Trangthai"].ToString();
                lbltienphaitra.Text=ds.Tables[0].Rows[vitri]["Tongtien"].ToString()+".000 VND";

                FilterData(dsNCC, cbomancc, "Tenncc", "Mancc", mancc);
                FilterData(dsNV, cbotennv, "Hotennv", "Manv", manv);
                if (cbotrangthai.Text == "0")
                    cbotrangthai.Text = "Hoạt động";
                else
                    cbotrangthai.Text = "Không hoạt động";

                load_cthdtheoMaHD(txtmahd.Text);
            }
        }



        void load_cthdtheoMaHD(string MaHD)
        {
            string s = "select * from CTHD_NHAP where Mahdnhap = '" + MaHD + "'";
            dsCTHD = ql.SelectData(s);
            dgvcthdnhap.DataSource = null;
            dgvcthdnhap.Columns.Clear();
            dgvcthdnhap.DataSource = dsCTHD.Tables[0];
        }

       


        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                vitri = e.RowIndex;
                Showtextbox(ds, vitri);
            }
        }

        private void dgvcthdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            danhSach_datagridView(dgvdanhsach, "Select * From HOADON_NHAP Where Trangthai = 0");
            load = true;
            xuLyChucNang(true);
            xulytextbox(true);

            dsNV = ql.SelectData("Select * From NHANVIEN  Where Trangthai = 0 ");
            dsNCC = ql.SelectData("Select * From NHACUNGCAP  Where Trangthai = 0");
            txtsdt.MaxLength = 10;

            ShowCombobox(cbomancc, dsNCC, "Tenncc", "Mancc");
            ShowCombobox(cbotennv, dsNV, "Hotennv", "Manv");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = 1;
            btnthemCT.Visible = false;
            DeleteData();
            xuLyChucNang(false);
            xulytextbox(false);
            txtmahd.Text = phatsinhma();
            cbotrangthai.SelectedIndex = 0;
            CreateCTSH();
            CreateColumnHD();
        }

        private void btnThemhd_Click(object sender, EventArgs e)
        {
            btnthemCT.Visible = true;
            object[] d = new object[4];
            d[0] = txtmahd.Text;
            d[1] = dtpNgaylapHD.Text;
            d[2] = cbotennv.SelectedValue.ToString();
            d[3] = cbomancc.SelectedValue.ToString();
            dgvdanhsach.Rows.Add(d);
        }

        void CreateCTSH()
        {
            dgvcthdnhap.Columns.Clear();
            dgvcthdnhap.DataSource = null; 
            dgvcthdnhap.Columns.Add("Mahdnhap","Mã hoá đơn nhập");
            dgvcthdnhap.Columns.Add("MaCTSP", "Mã CTSP");
            dgvcthdnhap.Columns.Add("SoLuong", "Số lượng");
            dgvcthdnhap.Columns.Add("Dongia", "Đơn giá");
            dgvcthdnhap.Columns.Add("Thanhtien", "Thành tiền");
            dgvcthdnhap.Columns.Add("TrangThai", "Trang thái");
        }
        
        void CreateColumnHD()
        {
            dgvdanhsach.Columns.Clear();
            dgvdanhsach.DataSource = null;
            dgvdanhsach.Columns.Add("Mahdnhap","Mã hoá đơn nhập");
            dgvdanhsach.Columns.Add("Ngaylaphd", "Ngày lập");
            dgvdanhsach.Columns.Add("Manv", "Mã nhân viên");
            dgvdanhsach.Columns.Add("Mancc", "Mã nhà cung cấp");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(false);
            ShowCombobox(cbomancc, dsNCC, "Tenncc", "Mancc");
            ShowCombobox(cbotennv, dsNV, "Hotennv", "Manv");
            cbotrangthai.SelectedIndex = 0;

            flag = 2;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            DialogResult HoiThoat;
            HoiThoat = MessageBox.Show("Bạn có muốn xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (HoiThoat == DialogResult.Yes)
            {
                flag = 3;
            }
            else
            {
                xuLyChucNang(true);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            dgvdanhsach.Columns.Clear();
            dgvcthdnhap.Columns.Clear();
            frmHoaDonNhap_Load(sender, e);
            DeleteData();
}

        private void btnluu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xulytextbox(true);
            string sql = "";
            if (flag == 1)
            {
                string mahdn = txtmahd.Text;
                string NgaylapHD = dtpNgaylapHD.Text;
                string tongtien = txtTongTien.Text;
                string tennv = cbotennv.SelectedValue.ToString();
                string mancc = cbomancc.SelectedValue.ToString();
                string trangthai = "0";

                string sqlHD = "insert into HOADON_NHAP values('" + mahdn + "','" + NgaylapHD + "','" + tennv + "','" + mancc + "'," + tongtien + "," + trangthai + ")";
                if (ql.UpdateData(sqlHD) > 0)
                {
                    MessageBox.Show("Cập nhật HD thành công!");
                    for (int i = 0; i < dgvcthdnhap.Rows.Count - 1; i++)
                    {
                        string mactsp = dgvcthdnhap.Rows[i].Cells[1].Value.ToString();
                        string soluong = dgvcthdnhap.Rows[i].Cells[2].Value.ToString();
                        string dongia = dgvcthdnhap.Rows[i].Cells[3].Value.ToString();
                        string thanhtien = dgvcthdnhap.Rows[i].Cells[4].Value.ToString();

                        //ct hoa don
                        string sqlCTHD = "insert into CTHD_NHAP values('" + mahdn + "', '" + mactsp + "', " + soluong + ", " + dongia;
                        sqlCTHD += ", " + thanhtien + ", " + trangthai + ")";

                        dsCTSP = ql.SelectData("select * from CT_SANPHAM where MaCTSP = '" + mactsp + "'");
                        double soluong_ctsp = double.Parse(dsCTSP.Tables[0].Rows[0]["SoLuong"].ToString());
                        double soluong_capnhat = soluong_ctsp + double.Parse(soluong);
                        string sqlCapNhatSoLuongCTSP = "update CT_SANPHAM set SoLuong = " + soluong_capnhat + " where MaCTSP = '" + mactsp + "'";

                        string masp = dsCTSP.Tables[0].Rows[0]["MaSP"].ToString();
                        dsSP = ql.SelectData("select * from SanPham where Masp = '" + masp + "'");
                        double sltonkho = double.Parse(dsSP.Tables[0].Rows[0]["Soluongtonkho"].ToString()) + double.Parse(soluong);
                        string sqlCapNhatSLTonKho = "update SanPham set Soluongtonkho = " + sltonkho + " where Masp = '" + masp + "'";

                        if (ql.UpdateData(sqlCTHD) > 0)
                        {
                            MessageBox.Show("Cập nhật CTHD thành công!");
                            ql.UpdateData(sqlCapNhatSoLuongCTSP);
                            ql.UpdateData(sqlCapNhatSLTonKho);
                        }
                    }
                }

            }
            if (flag == 2)
            {
                sql = "update HOADON_NHAP set Ngaylaphd='" + dtpNgaylapHD.Text + "',Manv= '" + cbotennv.SelectedValue;
                sql += "',Mancc= '" + cbomancc.SelectedValue + "',Mota= '" + txtsdt.Text + "'," + cbotrangthai.SelectedValue + " Where Mahdban='" + txtmahd.Text + "')";
            }
            if (flag == 3)
            {
                sql = "update HOADON_NHAP set Trangthai= 1 where Mahdban='" + txtmahd.Text + "'";

            }
           
                frmHoaDonNhap_Load(sender, e);

            
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void cboMasp_SelectedValueChanged(object sender, EventArgs e)
        {
            txtmactsp.Text = txtmahd + "." + cbotensp.SelectedValue;
        }

        private void txtdongia_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtmacthd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string MaCTSP = txtmactsp.Text;
                dsCTSP = ql.SelectData("select * from CT_SanPham where MaCTSP = '" + MaCTSP + "'");
                cbotrangthai.SelectedValue = 0;
                txtMasp.Text = dsCTSP.Tables[0].Rows[0]["Masp"].ToString();
                string MaSP = txtMasp.Text;
                dsSP = ql.SelectData("select * from SanPham where Masp = '" + MaSP + "'");
                cbotensp.Text = dsSP.Tables[0].Rows[0]["Tensp"].ToString();
                txtdongia.Text = dsSP.Tables[0].Rows[0]["Giaban"].ToString();

            }
        }

        double tongtien = 0;
        private void btnthemCT_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            object[] d = new object[6];
            d[0] = txtmahd.Text;
            d[1] = txtmactsp.Text;
            d[2] = txtsoluong.Text;
            d[3] = txtdongia.Text;
            double thanhTien = double.Parse(txtsoluong.Text) * double.Parse(txtdongia.Text);
            d[4] = thanhTien.ToString();
            d[5] = "0";
            dgvcthdnhap.Rows.Add(d);

            tongtien += thanhTien;
            txtTongTien.Text = tongtien.ToString();
        }


        private void txtmactsp_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void btnTimSDT_Click(object sender, EventArgs e)
        {
            if (!timKhachHang())
            {
                MessageBox.Show("Không tìm thấy SDT");
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.Show();
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void dgvcthdnhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double tongTien = 0;
            if (load)
            {
                if (flag == 1)//Thêm
                {
                    if (e.ColumnIndex == 2)
                    {
                        int soLuong = 0;
                        for (int i = 0; i < dgvcthdnhap.Rows.Count - 1; i++)
                        {
                            soLuong = int.Parse(dgvcthdnhap.Rows[i].Cells[2].Value.ToString());
                            double thanhTien = double.Parse(dgvcthdnhap.Rows[i].Cells[2].Value.ToString()) * double.Parse(dgvcthdnhap.Rows[i].Cells[3].Value.ToString());
                            dgvcthdnhap.Rows[i].Cells[4].Value = thanhTien;
                            tongTien += thanhTien;
                        }
                        txtsoluong.Text = soLuong.ToString();
                        txtTongTien.Text = tongTien.ToString();
                    }
                }
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.ShowDialog();
        }

        private void dgvdanhsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1)
                {

                    int vt = dgvdanhsach.CurrentRow.Index;//lấy vị trí
                    string Mahd = dgvdanhsach.CurrentRow.Cells[0].Value.ToString();
                    string Ngaylap = dgvdanhsach.CurrentRow.Cells[1].Value.ToString();

                    string Tongtien = dgvdanhsach.CurrentRow.Cells[4].Value.ToString();


                    string sql = "update HOADON_BAN set Ngaylaphd = '" + Ngaylap + "',Tongtien= '" + Tongtien + "' where Mahdban='" + Mahd + "'";

                    if (ql.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitri = 0;
                        frmHoaDonNhap_Load(sender, e);
                    }
                }
            }
        }

        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int soluong = int.Parse(txtsoluong.Text);
                int dongia = int.Parse(txtdongia.Text);
                txtTongTien.Text = (soluong * dongia).ToString();
            }
        }
    }
}
