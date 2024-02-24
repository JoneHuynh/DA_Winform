namespace _21_4_qlbandienthoai.Forms
{
    partial class frmSearchNV
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
            this.dgvSearchNV = new System.Windows.Forms.DataGridView();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTennv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchNV
            // 
            this.dgvSearchNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchNV.Location = new System.Drawing.Point(34, 151);
            this.dgvSearchNV.Name = "dgvSearchNV";
            this.dgvSearchNV.Size = new System.Drawing.Size(1038, 488);
            this.dgvSearchNV.TabIndex = 7;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(291, 88);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(257, 20);
            this.txtsdt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tìm số điện thoại";
            // 
            // cboTennv
            // 
            this.cboTennv.FormattingEnabled = true;
            this.cboTennv.Location = new System.Drawing.Point(291, 48);
            this.cboTennv.Name = "cboTennv";
            this.cboTennv.Size = new System.Drawing.Size(257, 21);
            this.cboTennv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên nhân viên";
            // 
            // frmSearchNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 693);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTennv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchNV);
            this.Name = "frmSearchNV";
            this.Text = "TÌM KIẾM HOÁ ĐƠN BÁN";
            this.Load += new System.EventHandler(this.frmSearchNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearchNV;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTennv;
        private System.Windows.Forms.Label label1;
    }
}