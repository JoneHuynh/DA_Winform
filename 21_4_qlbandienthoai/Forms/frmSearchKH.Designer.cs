namespace _21_4_qlbandienthoai.Forms
{
    partial class frmSearchKH
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
            this.dgvSearchKH = new System.Windows.Forms.DataGridView();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTenkh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchKH
            // 
            this.dgvSearchKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchKH.Location = new System.Drawing.Point(34, 151);
            this.dgvSearchKH.Name = "dgvSearchKH";
            this.dgvSearchKH.Size = new System.Drawing.Size(1038, 488);
            this.dgvSearchKH.TabIndex = 7;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(278, 91);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(257, 20);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.TextChanged += new System.EventHandler(this.txtsdt_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm số điện thoại";
            // 
            // cboTenkh
            // 
            this.cboTenkh.FormattingEnabled = true;
            this.cboTenkh.Location = new System.Drawing.Point(278, 51);
            this.cboTenkh.Name = "cboTenkh";
            this.cboTenkh.Size = new System.Drawing.Size(257, 21);
            this.cboTenkh.TabIndex = 0;
            this.cboTenkh.SelectedIndexChanged += new System.EventHandler(this.cboTenkh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên khách hàng";
            // 
            // frmSearchKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 693);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTenkh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchKH);
            this.Name = "frmSearchKH";
            this.Text = "frmSearchNCC";
            this.Load += new System.EventHandler(this.frmSearchKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearchKH;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTenkh;
        private System.Windows.Forms.Label label1;
    }
}