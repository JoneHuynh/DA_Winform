namespace _21_4_qlbandienthoai.Forms
{
    partial class frmHoaDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvcthdnhap = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnTimSDT = new System.Windows.Forms.Button();
            this.btnThemhd = new System.Windows.Forms.Button();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaylapHD = new System.Windows.Forms.DateTimePicker();
            this.cbomancc = new System.Windows.Forms.ComboBox();
            this.cbotennv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnthemCT = new System.Windows.Forms.Button();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.cbotensp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmactsp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltienphaitra = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthdnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(32, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số lượng ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvcthdnhap);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(672, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(703, 259);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết hóa đơn nhập";
            // 
            // dgvcthdnhap
            // 
            this.dgvcthdnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcthdnhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcthdnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcthdnhap.Location = new System.Drawing.Point(22, 31);
            this.dgvcthdnhap.Name = "dgvcthdnhap";
            this.dgvcthdnhap.Size = new System.Drawing.Size(659, 198);
            this.dgvcthdnhap.TabIndex = 0;
            this.dgvcthdnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellClick);
            this.dgvcthdnhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcthdnhap_CellValueChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.ForeColor = System.Drawing.Color.Black;
            this.btnthoat.Location = new System.Drawing.Point(18, 253);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(65, 39);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthem
            // 
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Location = new System.Drawing.Point(18, 26);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(62, 39);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.ForeColor = System.Drawing.Color.Black;
            this.btnhuy.Location = new System.Drawing.Point(18, 163);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(65, 39);
            this.btnhuy.TabIndex = 3;
            this.btnhuy.Text = "Hủy ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên sản phẩm";
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(18, 118);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(65, 39);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Location = new System.Drawing.Point(18, 71);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(62, 41);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdanhsach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Location = new System.Drawing.Point(22, 31);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.Size = new System.Drawing.Size(598, 198);
            this.dgvdanhsach.TabIndex = 0;
            this.dgvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellClick);
            this.dgvdanhsach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemNCC);
            this.groupBox1.Controls.Add(this.btnTimSDT);
            this.groupBox1.Controls.Add(this.btnThemhd);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.cbotrangthai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgaylapHD);
            this.groupBox1.Controls.Add(this.cbomancc);
            this.groupBox1.Controls.Add(this.cbotennv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmahd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn nhập";
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.Black;
            this.btnThemNCC.Location = new System.Drawing.Point(377, 168);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(50, 21);
            this.btnThemNCC.TabIndex = 18;
            this.btnThemNCC.Text = "...";
            this.btnThemNCC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // btnTimSDT
            // 
            this.btnTimSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSDT.ForeColor = System.Drawing.Color.Black;
            this.btnTimSDT.Location = new System.Drawing.Point(377, 195);
            this.btnTimSDT.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimSDT.Name = "btnTimSDT";
            this.btnTimSDT.Size = new System.Drawing.Size(50, 20);
            this.btnTimSDT.TabIndex = 17;
            this.btnTimSDT.Text = "...";
            this.btnTimSDT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimSDT.UseVisualStyleBackColor = true;
            this.btnTimSDT.Click += new System.EventHandler(this.btnTimSDT_Click);
            // 
            // btnThemhd
            // 
            this.btnThemhd.ForeColor = System.Drawing.Color.Black;
            this.btnThemhd.Location = new System.Drawing.Point(440, 126);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(98, 44);
            this.btnThemhd.TabIndex = 6;
            this.btnThemhd.Text = "Thêm hoá đơn";
            this.btnThemhd.UseVisualStyleBackColor = true;
            this.btnThemhd.Click += new System.EventHandler(this.btnThemhd_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(137, 195);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(235, 20);
            this.txtsdt.TabIndex = 4;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(31, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Số điện thoại";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnthoat);
            this.groupBox6.Controls.Add(this.btnthem);
            this.groupBox6.Controls.Add(this.btnhuy);
            this.groupBox6.Controls.Add(this.btnxoa);
            this.groupBox6.Controls.Add(this.btnluu);
            this.groupBox6.Controls.Add(this.btnsua);
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Location = new System.Drawing.Point(544, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(100, 312);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức Năng";
            // 
            // btnluu
            // 
            this.btnluu.ForeColor = System.Drawing.Color.Black;
            this.btnluu.Location = new System.Drawing.Point(18, 208);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(65, 39);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbotrangthai.Location = new System.Drawing.Point(137, 226);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(235, 21);
            this.cbotrangthai.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Trạng thái";
            // 
            // dtpNgaylapHD
            // 
            this.dtpNgaylapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylapHD.Location = new System.Drawing.Point(137, 94);
            this.dtpNgaylapHD.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaylapHD.Name = "dtpNgaylapHD";
            this.dtpNgaylapHD.Size = new System.Drawing.Size(235, 20);
            this.dtpNgaylapHD.TabIndex = 1;
            // 
            // cbomancc
            // 
            this.cbomancc.FormattingEnabled = true;
            this.cbomancc.Location = new System.Drawing.Point(137, 168);
            this.cbomancc.Name = "cbomancc";
            this.cbomancc.Size = new System.Drawing.Size(235, 21);
            this.cbomancc.TabIndex = 3;
            // 
            // cbotennv
            // 
            this.cbotennv.FormattingEnabled = true;
            this.cbotennv.Location = new System.Drawing.Point(137, 131);
            this.cbotennv.Name = "cbotennv";
            this.cbotennv.Size = new System.Drawing.Size(235, 21);
            this.cbotennv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(137, 57);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(235, 20);
            this.txtmahd.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvdanhsach);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 259);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn nhập";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnThemSP);
            this.groupBox4.Controls.Add(this.lblTongtien);
            this.groupBox4.Controls.Add(this.txtMasp);
            this.groupBox4.Controls.Add(this.txtTongTien);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnthemCT);
            this.groupBox4.Controls.Add(this.txtdongia);
            this.groupBox4.Controls.Add(this.txtsoluong);
            this.groupBox4.Controls.Add(this.cbotensp);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtmactsp);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(672, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 312);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết sản phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.Black;
            this.btnThemSP.Location = new System.Drawing.Point(377, 32);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(38, 21);
            this.btnThemSP.TabIndex = 1;
            this.btnThemSP.Text = "...";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // lblTongtien
            // 
            this.lblTongtien.ForeColor = System.Drawing.Color.Black;
            this.lblTongtien.Location = new System.Drawing.Point(37, 223);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(80, 20);
            this.lblTongtien.TabIndex = 1;
            this.lblTongtien.Text = "Thành tiền";
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(137, 67);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(235, 20);
            this.txtMasp.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(137, 223);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(235, 20);
            this.txtTongTien.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(31, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Mã sản phẩm";
            // 
            // btnthemCT
            // 
            this.btnthemCT.ForeColor = System.Drawing.Color.Black;
            this.btnthemCT.Location = new System.Drawing.Point(205, 250);
            this.btnthemCT.Name = "btnthemCT";
            this.btnthemCT.Size = new System.Drawing.Size(98, 44);
            this.btnthemCT.TabIndex = 7;
            this.btnthemCT.Text = "Thêm CTHD";
            this.btnthemCT.UseVisualStyleBackColor = true;
            this.btnthemCT.Click += new System.EventHandler(this.btnthemCT_Click);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(137, 188);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(235, 20);
            this.txtdongia.TabIndex = 5;
            this.txtdongia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdongia_KeyDown);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(137, 150);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(235, 20);
            this.txtsoluong.TabIndex = 4;
            this.txtsoluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsoluong_KeyDown);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // cbotensp
            // 
            this.cbotensp.FormattingEnabled = true;
            this.cbotensp.Location = new System.Drawing.Point(137, 108);
            this.cbotensp.Name = "cbotensp";
            this.cbotensp.Size = new System.Drawing.Size(235, 21);
            this.cbotensp.TabIndex = 3;
            this.cbotensp.SelectedValueChanged += new System.EventHandler(this.cboMasp_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã CTSP";
            // 
            // txtmactsp
            // 
            this.txtmactsp.Location = new System.Drawing.Point(137, 32);
            this.txtmactsp.Name = "txtmactsp";
            this.txtmactsp.Size = new System.Drawing.Size(235, 20);
            this.txtmactsp.TabIndex = 0;
            this.txtmactsp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmacthd_KeyDown);
            this.txtmactsp.ImeModeChanged += new System.EventHandler(this.txtmactsp_ImeModeChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá";
            // 
            // lbltienphaitra
            // 
            this.lbltienphaitra.BackColor = System.Drawing.Color.Transparent;
            this.lbltienphaitra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltienphaitra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltienphaitra.ForeColor = System.Drawing.Color.Black;
            this.lbltienphaitra.Location = new System.Drawing.Point(482, 633);
            this.lbltienphaitra.Name = "lbltienphaitra";
            this.lbltienphaitra.Size = new System.Drawing.Size(256, 51);
            this.lbltienphaitra.TabIndex = 21;
            this.lbltienphaitra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(305, 646);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tổng tiền";
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 716);
            this.Controls.Add(this.lbltienphaitra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmHoaDonNhap";
            this.Text = "Hoá đơn nhập";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthdnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.DataGridView dgvcthdnhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        internal System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaylapHD;
        private System.Windows.Forms.ComboBox cbomancc;
        private System.Windows.Forms.ComboBox cbotennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnthemCT;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ComboBox cbotensp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmactsp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemhd;
        private System.Windows.Forms.Button btnTimSDT;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbltienphaitra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThemSP;
    }
}