namespace _21_4_qlbandienthoai
{
    partial class frmSearchSP
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.dgvSearchSP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại sản phẩm";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(286, 32);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(257, 21);
            this.cboLoaiSP.TabIndex = 0;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // dgvSearchSP
            // 
            this.dgvSearchSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSP.Location = new System.Drawing.Point(38, 127);
            this.dgvSearchSP.Name = "dgvSearchSP";
            this.dgvSearchSP.Size = new System.Drawing.Size(1038, 488);
            this.dgvSearchSP.TabIndex = 2;
            this.dgvSearchSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchSP_CellContentClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm theo tên sản phẩm\r\n\r\n";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(286, 72);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(257, 20);
            this.txttensp.TabIndex = 1;
            this.txttensp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmSearchSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 693);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSearchSP);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchSP";
            this.Text = "TÌM KIẾM SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmSearchSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.DataGridView dgvSearchSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttensp;
    }
}