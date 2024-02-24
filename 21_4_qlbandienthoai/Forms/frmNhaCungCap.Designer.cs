namespace _21_4_qlbandienthoai
{
    partial class frmNhaCungCap
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
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.Mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDS = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.txtNameNCC = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblNameNCC = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.grpDS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNCC
            // 
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mancc,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvNCC.Location = new System.Drawing.Point(10, 26);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.Size = new System.Drawing.Size(796, 172);
            this.dgvNCC.TabIndex = 0;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            this.dgvNCC.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellValueChanged);
            // 
            // Mancc
            // 
            this.Mancc.DataPropertyName = "Mancc";
            this.Mancc.HeaderText = "Mã Nhà cung cấp";
            this.Mancc.Name = "Mancc";
            this.Mancc.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tenncc";
            this.Column1.HeaderText = "Tên Nhà cung cấp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Dchi";
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "Mail";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sdt";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Trangthai";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // grpDS
            // 
            this.grpDS.Controls.Add(this.dgvNCC);
            this.grpDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpDS.Location = new System.Drawing.Point(37, 323);
            this.grpDS.Name = "grpDS";
            this.grpDS.Size = new System.Drawing.Size(823, 215);
            this.grpDS.TabIndex = 12;
            this.grpDS.TabStop = false;
            this.grpDS.Text = "Danh sách nhà cung cấp";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(624, 62);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(182, 24);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaiSP);
            this.groupBox1.Controls.Add(this.cbotrangthai);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtNameNCC);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtNCC);
            this.groupBox1.Controls.Add(this.lblNCC);
            this.groupBox1.Controls.Add(this.lblNameNCC);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblDC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboLoaiSP.Location = new System.Drawing.Point(624, 108);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(182, 26);
            this.cboLoaiSP.TabIndex = 5;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cbotrangthai.Location = new System.Drawing.Point(624, 153);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(182, 26);
            this.cbotrangthai.TabIndex = 6;
            // 
            // txtNameNCC
            // 
            this.txtNameNCC.Location = new System.Drawing.Point(207, 103);
            this.txtNameNCC.Name = "txtNameNCC";
            this.txtNameNCC.Size = new System.Drawing.Size(182, 24);
            this.txtNameNCC.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(207, 185);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(182, 24);
            this.txtMail.TabIndex = 3;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(207, 144);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(182, 24);
            this.txtDiachi.TabIndex = 2;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(207, 62);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(182, 24);
            this.txtNCC.TabIndex = 0;
            this.txtNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNCC_KeyPress);
            // 
            // lblNCC
            // 
            this.lblNCC.Location = new System.Drawing.Point(17, 68);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(141, 18);
            this.lblNCC.TabIndex = 12;
            this.lblNCC.Text = "Mã Nhà cung cấp";
            // 
            // lblNameNCC
            // 
            this.lblNameNCC.Location = new System.Drawing.Point(17, 109);
            this.lblNameNCC.Name = "lblNameNCC";
            this.lblNameNCC.Size = new System.Drawing.Size(141, 18);
            this.lblNameNCC.TabIndex = 13;
            this.lblNameNCC.Text = "Tên Nhà cung cấp";
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(17, 191);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(141, 18);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "Mail";
            // 
            // lblDC
            // 
            this.lblDC.Location = new System.Drawing.Point(17, 150);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(141, 18);
            this.lblDC.TabIndex = 15;
            this.lblDC.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(434, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Loại sản phẩm";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(434, 153);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(141, 18);
            this.lblTrangThai.TabIndex = 16;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(434, 68);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(141, 18);
            this.lblSDT.TabIndex = 18;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(141, 116);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(78, 35);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(141, 75);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(78, 35);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(34, 75);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(78, 35);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(141, 34);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(78, 35);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(34, 34);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(78, 35);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(878, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(34, 116);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(78, 35);
            this.btnhuy.TabIndex = 2;
            this.btnhuy.Text = "Huỷ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // frmNhaCungCap
            // 
            this.AcceptButton = this.btnluu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(1161, 604);
            this.Controls.Add(this.grpDS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmNhaCungCap";
            this.Text = "NHÀ CUNG CẤP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhaCungCap_FormClosing);
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.grpDS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.GroupBox grpDS;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNameNCC;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Label lblNameNCC;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}