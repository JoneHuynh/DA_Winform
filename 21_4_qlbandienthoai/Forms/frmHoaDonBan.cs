using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static _21_4_qlbandienthoai.Theme;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _21_4_qlbandienthoai.Forms
{
    public partial class frmHoaDonBan : Form
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

        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        int flag = 0;
        int flagct = 0;
        int vitri = 0;
        DataSet ds = new DataSet();
        DataSet dsNV = new DataSet();
        DataSet dsKH = new DataSet();
        DataSet dsSP = new DataSet();
        DataSet dsCTHD = new DataSet();
        DataSet dsCTSP = new DataSet();
        DataSet dsHDB = new DataSet();
        Boolean load = false;
        string sql = "";

        qlbandienthoai ql = new qlbandienthoai();




        void danhSach_datagridView(DataGridView dg, string sql)
        {
            ds = ql.SelectData(sql);
            dg.DataSource = ds.Tables[0];
        }

        String phatsinhma()
        {
            string hdban = "";
            hdban = "HDB" + ((ds.Tables[0].Rows.Count) + 1).ToString();
            return hdban;
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
                txtmahd.Text = ds.Tables[0].Rows[vitri]["Mahdban"].ToString();    
                cbotennv.Text = dsHDB.Tables[0].Rows[vitri]["Manv"].ToString();
                cbomakh.Text = dsHDB.Tables[0].Rows[vitri]["Makh"].ToString();
                dtpNgaylapHD.Text = dsHDB.Tables[0].Rows[vitri]["Ngaylaphd"].ToString();
                String trangthai  = dsHDB.Tables[0].Rows[vitri]["Trangthai"].ToString();
                string makh = dsHDB.Tables[0].Rows[vitri]["Makh"].ToString();
                string manv = dsHDB.Tables[0].Rows[vitri]["Manv"].ToString();
                lbltienphaitra.Text=dsHDB.Tables[0].Rows[vitri]["Tongtien"].ToString()+".000 VND";
                FilterData(dsKH, cbomakh, "Hotenkh", "Makh", makh);
                FilterData(dsNV, cbotennv, "Hotennv", "Manv", manv);
                if (trangthai == "0")
                {
                    cbotrangthai.Text = "Hoạt động";

                }
                else
                {
                    cbotrangthai.Text = "Không hoạt động";


                }
                load_cthdtheoMaHD(txtmahd.Text);
            }
        }

        void ShowtextboxCT(DataSet ds, int vitri)
        {
            if (vitri >= 0 && vitri < ds.Tables[0].Rows.Count)
            {
                txtmactsp.Text = dsCTHD.Tables[0].Rows[vitri]["MaCTSP"].ToString();

                txtMasp.Text = dsSP.Tables[0].Rows[vitri]["Masp"].ToString();
                cbotensp.Text = dsSP.Tables[0].Rows[vitri]["Tensp"].ToString();
                txtsoluong.Text = dsCTHD.Tables[0].Rows[vitri]["Soluong"].ToString();
                txtdongia.Text = dsCTHD.Tables[0].Rows[vitri]["Dongia"].ToString();
                txtthanhtien.Text = dsCTHD.Tables[0].Rows[vitri]["Thanhtien"].ToString();
                string trangthai = dsCTHD.Tables[0].Rows[vitri]["Trangthai"].ToString();
                if (trangthai == "0")
                {
                    cboTrangthaiCT.Text = "Hoạt động";

                }
                else
                {
                    cboTrangthaiCT.Text = "Không hoạt động";


                }
            }
        }

        void DeleteData()
        {
            txtmahd.Clear();
            dtpNgaylapHD.Text = "";
            cbotennv.SelectedIndex =-1;
            cbomakh.SelectedIndex =-1;
            txtmactsp.Clear();
            cbotensp.SelectedIndex = -1;
            txtsoluong.Clear();
            txtdongia.Clear();
            txtthanhtien.Clear();
        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = 1;
            btnthemCT.Visible = false;
           // btnthemCT.Enabled = true;
            xuLyChucNang(false);
            DeleteData();
            txtmahd.Text = phatsinhma();
            cbotrangthai.SelectedIndex = 0;
            cboTrangthaiCT.SelectedIndex = 0;
            TaoCotHoaDon();
            TaoCotCTHD();

        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(load)
            {
                vitri = e.RowIndex;
                Showtextbox(ds, vitri);
     
            }
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            danhSach_datagridView(dgvdanhsach, "Select * From HOADON_BAN Where Trangthai = 0");
            load = true;

            dsNV = ql.SelectData("Select * From NHANVIEN Where Trangthai = 0");
            dsKH = ql.SelectData("Select * From KHACHHANG Where Trangthai = 0");
            dsSP = ql.SelectData("Select * From SANPHAM Where Trangthai = 0");
            dsHDB = ql.SelectData("Select * From HOADON_BAN Where Trangthai = 0");

            ShowCombobox(cbomakh, dsKH, "Hotenkh", "Makh");
            ShowCombobox(cbotennv, dsNV, "Hotennv", "Manv");
            ShowCombobox(cbotensp, dsSP, "Tensp", "Masp");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            flag = 2;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xulytextbox(true);
            DeleteData();
            flag = 3;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xulytextbox(true);
            string sql = "";
            if (flag == 1)
            {
                string mahd = txtmahd.Text;
                string tennv = cbotennv.SelectedValue.ToString();
                string makh = cbomakh.SelectedValue.ToString();
                string NgaylapHD = dtpNgaylapHD.Text;
                string tongtien = txtthanhtien.Text;
                string trangthai = "0";
                sql = "insert into HOADON_BAN values('" + mahd + "','" + NgaylapHD + "','" + tennv + "','" + makh + "'," + tongtien + "," + trangthai + ")";
                if (ql.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Cập nhật HD thành công!");
                    for (int i = 0; i < dgvcthdb.Rows.Count - 1; i++)
                    {
                        string mactsp = dgvcthdb.Rows[i].Cells[1].Value.ToString();
                        string soluong = dgvcthdb.Rows[i].Cells[2].Value.ToString();
                        string dongia = dgvcthdb.Rows[i].Cells[3].Value.ToString();
                        string thanhtien = dgvcthdb.Rows[i].Cells[4].Value.ToString();
                        //ct hoa don
                        string sqlCTHD = "insert into CTHD_BAN values('" + txtmahd.Text + "', '" + mactsp + "', " + soluong + ", " + dongia;
                        sqlCTHD += ", " + thanhtien + ", " + trangthai + ")";

                        dsCTSP = ql.SelectData("select * from CT_SanPham where MaCTSP = '" + mactsp + "'");
                        double soluong_ctsp = double.Parse(dsCTSP.Tables[0].Rows[0]["SoLuong"].ToString());
                        double soluong_capnhat = soluong_ctsp - double.Parse(soluong);
                        string sqlCapNhatSoLuongCTSP = "update CT_SanPham set Soluong = " + soluong_capnhat + " where MaCTSP = '" + mactsp + "'";

                        string masp = dsCTSP.Tables[0].Rows[0]["Masp"].ToString();
                        dsSP = ql.SelectData("select * from SanPham where MaSP = '" + masp + "'");
                        double sltonkho = double.Parse(dsSP.Tables[0].Rows[0]["Soluongtonkho"].ToString()) - double.Parse(soluong);
                        string sqlCapNhatSLTonKho = "update SanPham set Soluongtonkho = " + sltonkho + " where MaSP = '" + masp + "'";

                        if (ql.UpdateData(sqlCTHD) > 0)
                        {
                            MessageBox.Show("Cập nhật CTHD thành công!");
                            ql.UpdateData(sqlCapNhatSoLuongCTSP);
                            ql.UpdateData(sqlCapNhatSLTonKho);
                        }
                    }
                }
              
                                    
                }            
            if(flag == 2)
            {
                sql = "update HOADON_BAN set Mahdban='" + txtmahd.Text + "',Ngaylaphd='" + dtpNgaylapHD.Text + "',Manv= '" + cbotennv.SelectedValue;
                sql += "',Makh= '" + cbomakh.SelectedValue + "'," + cbotrangthai.SelectedValue + ")";
            }
            if (flag == 3)
            {
                sql = "update HOADON_BAN set Trangthai= 1 where Mahdban='" + txtmahd.Text + "'";

            }
           

                frmHoaDonBan_Load(sender, e);

            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        double tongTien = 0;
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

            string MaCTSP = txtmactsp.Text;
            dsCTSP = ql.SelectData("select * from CT_SanPham where MaCTSP = '" + MaCTSP + "'");
            int soluong_ctsp = int.Parse(dsCTSP.Tables[0].Rows[0]["SoLuong"].ToString());
            int soluong_ban = int.Parse(txtsoluong.Text);
            if (soluong_ctsp >= soluong_ban)
            {
                dgvcthdb.Rows.Add(d);
                tongTien += thanhTien;
                txtthanhtien.Text = tongTien.ToString();
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ. Sản phẩm chỉ còn " + soluong_ctsp + " cái.", "Thông báo");
            }
        }

        private void btnluuCT_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xulytextbox(true);
            string sql = "";
            if (flagct == 1)
            {
                string mahd = txtmactsp.Text;
                string masp = cbotensp.SelectedValue.ToString();
                string chitiethoadon = txtmactsp.Text;
                string soluong = txtsoluong.Text;
                string dongia = txtdongia.Text;
                string thanhtien = lblthanhtien.Text;
                string trangthai = "0";
                sql = "insert into HOADON_BAN values('" + mahd + "','" + masp + "','" + soluong + "','" + dongia + "','" + thanhtien + "'," + trangthai + ")";

            }
            if (ql.UpdateData(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmHoaDonBan_Load(sender, e);
            }
        }

        private void cboMasp_SelectedValueChanged(object sender, EventArgs e)
        {
            txtmactsp.Text = txtmahd + "." + cbotensp.SelectedValue;
        }

        private void txtdongia_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        void TaoCotHoaDon()
        {
            dgvdanhsach.Columns.Clear();
            dgvdanhsach.DataSource = null;
            dgvdanhsach.Columns.Add("Mahdban", "Mã HDB");
            dgvdanhsach.Columns.Add("Ngaylaphd", "Ngày lập");
            dgvdanhsach.Columns.Add("Manv", "Mã NV");
            dgvdanhsach.Columns.Add("Makh", "Mã NV");
        }

        private void btnthemhd_Click(object sender, EventArgs e)
        {
            btnthemCT.Visible = true;
            object[] d = new object[4];
            d[0] = txtmahd.Text;
            d[1] = dtpNgaylapHD.Text;
            d[2] = cbotennv.SelectedValue.ToString();
            d[3] = cbomakh.SelectedValue.ToString();
            dgvdanhsach.Rows.Add(d);

        }
        void TaoCotCTHD()
        {
            dgvcthdb.Columns.Clear();
            dgvcthdb.Columns.Add("Mahdban", "Mã HDB");
            dgvcthdb.Columns.Add("MaCTSP", "Mã CTSP");
            dgvcthdb.Columns.Add("Soluong", "Số lượng");
            dgvcthdb.Columns.Add("DonGia", "Đơn giá");
            dgvcthdb.Columns.Add("Thanhtien", "Thành tiền");
            dgvcthdb.Columns.Add("Trangthai", "Trạng thái");
        }

        void load_cthdtheoMaHD(string MaHD)
        {
            string s = "select * from CTHD_Ban  where Mahdban  = '" + MaHD + "'";
            dsCTHD =ql.SelectData(s);
            dgvcthdb.DataSource = null;
            dgvcthdb.Columns.Clear();
            dgvcthdb.DataSource = dsCTHD.Tables[0];
        }

        private void txtmactsp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string MaCTSP = txtmactsp.Text;
                dsCTSP = ql.SelectData("select * from CT_SanPham where MaCTSP = '" + MaCTSP + "'");
                txtMasp.Text = dsSP.Tables[0].Rows[0]["Masp"].ToString();
                txtdongia.Text = dsSP.Tables[0].Rows[0]["Giaban"].ToString();   
                string MaSP = txtMasp.Text;
                cbotrangthai.SelectedValue = 0;
                dsSP = ql.SelectData("select * from SanPham where Masp = '" + MaSP + "'");
                cbotensp.Text = dsSP.Tables[0].Rows[0]["Tensp"].ToString();
               
            }
        }

        private void dgvcthdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(load)
            {
                vitri = e.RowIndex;
                ShowtextboxCT(ds, vitri);
            }
               

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.ShowDialog();
        }

        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int soluong = int.Parse(txtsoluong.Text);
                int dongia = int.Parse(txtdongia.Text);
                txtthanhtien.Text = (soluong * dongia).ToString();
            }
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
                            frmHoaDonBan_Load(sender, e);
                        }               
                }
            }
        }

        private void lbltienphaitra_Click(object sender, EventArgs e)
        {

        }
    }
}
