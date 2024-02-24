namespace _21_4_qlbandienthoai
{
    partial class frmSanPham
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongtonkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMaImage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtsoluongtonkho = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.btnLoadanh = new System.Windows.Forms.Button();
            this.rtxtMota = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picHinhSP = new System.Windows.Forms.PictureBox();
            this.cboncc = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCTSP = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCTSP = new System.Windows.Forms.Button();
            this.btnPhienban = new System.Windows.Forms.Button();
            this.btnmau = new System.Windows.Forms.Button();
            this.cbomau = new System.Windows.Forms.ComboBox();
            this.txtsoluongct = new System.Windows.Forms.TextBox();
            this.txtgialech = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flpPhienban = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhSP)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSP)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(771, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 343);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnsua
            // 
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Location = new System.Drawing.Point(24, 128);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(78, 35);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthoat
            // 
            this.btnthoat.ForeColor = System.Drawing.Color.Black;
            this.btnthoat.Location = new System.Drawing.Point(24, 275);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(78, 35);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnhuy
            // 
            this.btnhuy.ForeColor = System.Drawing.Color.Black;
            this.btnhuy.Location = new System.Drawing.Point(24, 226);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(78, 35);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "Hủy ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.ForeColor = System.Drawing.Color.Black;
            this.btnluu.Location = new System.Drawing.Point(24, 177);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(78, 35);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(24, 79);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(78, 35);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Location = new System.Drawing.Point(24, 30);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(78, 35);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masp,
            this.Tensp,
            this.Hinh,
            this.Mota,
            this.Soluongtonkho,
            this.GiaNhap,
            this.GiaBan,
            this.Mancc,
            this.Maloai,
            this.Trangthai});
            this.dgvdanhsach.Location = new System.Drawing.Point(22, 30);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.Size = new System.Drawing.Size(842, 255);
            this.dgvdanhsach.TabIndex = 0;
            this.dgvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellClick_1);
            this.dgvdanhsach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellValueChanged);
            // 
            // Masp
            // 
            this.Masp.DataPropertyName = "Masp";
            this.Masp.HeaderText = "Mã sản phẩm";
            this.Masp.Name = "Masp";
            // 
            // Tensp
            // 
            this.Tensp.DataPropertyName = "Tensp";
            this.Tensp.HeaderText = "Tên sản phẩm";
            this.Tensp.Name = "Tensp";
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Image";
            this.Hinh.Name = "Hinh";
            this.Hinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Mota
            // 
            this.Mota.DataPropertyName = "Mota";
            this.Mota.HeaderText = "Mô tả";
            this.Mota.Name = "Mota";
            // 
            // Soluongtonkho
            // 
            this.Soluongtonkho.DataPropertyName = "Soluongtonkho";
            this.Soluongtonkho.HeaderText = "Số lượng tồn kho";
            this.Soluongtonkho.Name = "Soluongtonkho";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // Mancc
            // 
            this.Mancc.DataPropertyName = "Mancc";
            this.Mancc.HeaderText = "Mã Nhà cung cấp";
            this.Mancc.Name = "Mancc";
            // 
            // Maloai
            // 
            this.Maloai.DataPropertyName = "Maloai";
            this.Maloai.HeaderText = "Mã loại";
            this.Maloai.Name = "Maloai";
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.Name = "Trangthai";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvdanhsach);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 308);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            // 
            // lblMaImage
            // 
            this.lblMaImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaImage.ForeColor = System.Drawing.Color.Black;
            this.lblMaImage.Location = new System.Drawing.Point(1100, 262);
            this.lblMaImage.Name = "lblMaImage";
            this.lblMaImage.Size = new System.Drawing.Size(218, 23);
            this.lblMaImage.TabIndex = 1;
            this.lblMaImage.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(423, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số lượng tồn kho";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(423, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng Thái";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mô tả";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(155, 26);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.ReadOnly = true;
            this.txtmasp.Size = new System.Drawing.Size(209, 26);
            this.txtmasp.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(21, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Loại sản phẩm";
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(524, 66);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(203, 26);
            this.txtgiaban.TabIndex = 7;
            // 
            // txtsoluongtonkho
            // 
            this.txtsoluongtonkho.Location = new System.Drawing.Point(524, 111);
            this.txtsoluongtonkho.Name = "txtsoluongtonkho";
            this.txtsoluongtonkho.Size = new System.Drawing.Size(203, 26);
            this.txtsoluongtonkho.TabIndex = 8;
            this.txtsoluongtonkho.TextChanged += new System.EventHandler(this.txtsoluongtonkho_TextChanged);
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(155, 66);
            this.txttensp.Name = "txttensp";
            this.txttensp.ReadOnly = true;
            this.txttensp.Size = new System.Drawing.Size(209, 26);
            this.txttensp.TabIndex = 1;
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbotrangthai.Location = new System.Drawing.Point(155, 107);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(209, 28);
            this.cbotrangthai.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nhà cung cấp";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboLoaiSP.Location = new System.Drawing.Point(155, 154);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(209, 28);
            this.cboLoaiSP.TabIndex = 3;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // btnLoadanh
            // 
            this.btnLoadanh.ForeColor = System.Drawing.Color.Black;
            this.btnLoadanh.Location = new System.Drawing.Point(416, 181);
            this.btnLoadanh.Name = "btnLoadanh";
            this.btnLoadanh.Size = new System.Drawing.Size(97, 60);
            this.btnLoadanh.TabIndex = 9;
            this.btnLoadanh.Text = "Load ảnh";
            this.btnLoadanh.UseVisualStyleBackColor = true;
            this.btnLoadanh.Click += new System.EventHandler(this.btnLoadanh_Click);
            // 
            // rtxtMota
            // 
            this.rtxtMota.Location = new System.Drawing.Point(155, 229);
            this.rtxtMota.Name = "rtxtMota";
            this.rtxtMota.Size = new System.Drawing.Size(209, 99);
            this.rtxtMota.TabIndex = 5;
            this.rtxtMota.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Controls.Add(this.txtgianhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtxtMota);
            this.groupBox1.Controls.Add(this.btnLoadanh);
            this.groupBox1.Controls.Add(this.picHinhSP);
            this.groupBox1.Controls.Add(this.cboncc);
            this.groupBox1.Controls.Add(this.cboLoaiSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbotrangthai);
            this.groupBox1.Controls.Add(this.txttensp);
            this.groupBox1.Controls.Add(this.txtsoluongtonkho);
            this.groupBox1.Controls.Add(this.txtgiaban);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtmasp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.Black;
            this.btnThemSP.Location = new System.Drawing.Point(383, 297);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(130, 28);
            this.btnThemSP.TabIndex = 10;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(524, 25);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(203, 26);
            this.txtgianhap.TabIndex = 6;
            this.txtgianhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgianhap_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(423, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giá nhập";
            // 
            // picHinhSP
            // 
            this.picHinhSP.Location = new System.Drawing.Point(529, 154);
            this.picHinhSP.Name = "picHinhSP";
            this.picHinhSP.Size = new System.Drawing.Size(198, 175);
            this.picHinhSP.TabIndex = 18;
            this.picHinhSP.TabStop = false;
            this.picHinhSP.Click += new System.EventHandler(this.picHinhSP_Click);
            // 
            // cboncc
            // 
            this.cboncc.FormattingEnabled = true;
            this.cboncc.Location = new System.Drawing.Point(155, 192);
            this.cboncc.Name = "cboncc";
            this.cboncc.Size = new System.Drawing.Size(209, 28);
            this.cboncc.TabIndex = 4;
            this.cboncc.SelectedIndexChanged += new System.EventHandler(this.cboncc_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCTSP);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(912, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(647, 308);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chi tiết sản phẩm";
            // 
            // dgvCTSP
            // 
            this.dgvCTSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTSP.Location = new System.Drawing.Point(22, 30);
            this.dgvCTSP.Name = "dgvCTSP";
            this.dgvCTSP.Size = new System.Drawing.Size(602, 255);
            this.dgvCTSP.TabIndex = 0;
            this.dgvCTSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTSP_CellClick);
            this.dgvCTSP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTSP_CellValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCTSP);
            this.groupBox5.Controls.Add(this.btnPhienban);
            this.groupBox5.Controls.Add(this.btnmau);
            this.groupBox5.Controls.Add(this.cbomau);
            this.groupBox5.Controls.Add(this.txtsoluongct);
            this.groupBox5.Controls.Add(this.txtgialech);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(912, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 343);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin chi tiết";
            // 
            // btnCTSP
            // 
            this.btnCTSP.ForeColor = System.Drawing.Color.Black;
            this.btnCTSP.Location = new System.Drawing.Point(77, 246);
            this.btnCTSP.Name = "btnCTSP";
            this.btnCTSP.Size = new System.Drawing.Size(154, 42);
            this.btnCTSP.TabIndex = 5;
            this.btnCTSP.Text = "Thêm chi tiết sản phẩm";
            this.btnCTSP.UseVisualStyleBackColor = true;
            this.btnCTSP.Click += new System.EventHandler(this.btnCTSP_Click);
            // 
            // btnPhienban
            // 
            this.btnPhienban.ForeColor = System.Drawing.Color.Black;
            this.btnPhienban.Location = new System.Drawing.Point(119, 24);
            this.btnPhienban.Name = "btnPhienban";
            this.btnPhienban.Size = new System.Drawing.Size(112, 23);
            this.btnPhienban.TabIndex = 0;
            this.btnPhienban.Text = "Chọn phiên bản";
            this.btnPhienban.UseVisualStyleBackColor = true;
            this.btnPhienban.Click += new System.EventHandler(this.btnPhienban_Click);
            // 
            // btnmau
            // 
            this.btnmau.ForeColor = System.Drawing.Color.Black;
            this.btnmau.Location = new System.Drawing.Point(238, 79);
            this.btnmau.Name = "btnmau";
            this.btnmau.Size = new System.Drawing.Size(36, 23);
            this.btnmau.TabIndex = 2;
            this.btnmau.Text = "...";
            this.btnmau.UseVisualStyleBackColor = true;
            this.btnmau.Click += new System.EventHandler(this.btnmau_Click);
            // 
            // cbomau
            // 
            this.cbomau.FormattingEnabled = true;
            this.cbomau.Location = new System.Drawing.Point(119, 79);
            this.cbomau.Name = "cbomau";
            this.cbomau.Size = new System.Drawing.Size(112, 21);
            this.cbomau.TabIndex = 1;
            this.cbomau.SelectedIndexChanged += new System.EventHandler(this.cbomau_SelectedIndexChanged);
            // 
            // txtsoluongct
            // 
            this.txtsoluongct.Location = new System.Drawing.Point(119, 128);
            this.txtsoluongct.Name = "txtsoluongct";
            this.txtsoluongct.Size = new System.Drawing.Size(155, 20);
            this.txtsoluongct.TabIndex = 3;
            // 
            // txtgialech
            // 
            this.txtgialech.Location = new System.Drawing.Point(119, 177);
            this.txtgialech.Name = "txtgialech";
            this.txtgialech.Size = new System.Drawing.Size(155, 20);
            this.txtgialech.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Giá chênh lệch";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phiên bản";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Màu";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Số lượng";
            // 
            // flpPhienban
            // 
            this.flpPhienban.Location = new System.Drawing.Point(1228, 29);
            this.flpPhienban.Name = "flpPhienban";
            this.flpPhienban.Size = new System.Drawing.Size(216, 330);
            this.flpPhienban.TabIndex = 11;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 700);
            this.Controls.Add(this.flpPhienban);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMaImage);
            this.Name = "frmSanPham";
            this.Text = "SẢN PHẨM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSanPham_FormClosing);
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhSP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSP)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        internal System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMaImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtsoluongtonkho;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.PictureBox picHinhSP;
        private System.Windows.Forms.Button btnLoadanh;
        private System.Windows.Forms.RichTextBox rtxtMota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.DataGridView dgvCTSP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCTSP;
        private System.Windows.Forms.Button btnPhienban;
        private System.Windows.Forms.Button btnmau;
        private System.Windows.Forms.ComboBox cbomau;
        private System.Windows.Forms.TextBox txtsoluongct;
        private System.Windows.Forms.TextBox txtgialech;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flpPhienban;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.ComboBox cboncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongtonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
    }
}