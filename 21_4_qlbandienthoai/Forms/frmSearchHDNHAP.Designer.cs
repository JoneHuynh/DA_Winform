namespace _21_4_qlbandienthoai.Forms
{
    partial class frmSearchHDNHAP
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSearchSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(258, 54);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(258, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // dgvSearchSP
            // 
            this.dgvSearchSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSP.Location = new System.Drawing.Point(34, 151);
            this.dgvSearchSP.Name = "dgvSearchSP";
            this.dgvSearchSP.Size = new System.Drawing.Size(1038, 488);
            this.dgvSearchSP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày lập hoá đơn";
            // 
            // frmSearchHDNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 693);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvSearchSP);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchHDNHAP";
            this.Text = "TÌM KIẾM HOÁ ĐƠN NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvSearchSP;
        private System.Windows.Forms.Label label1;
    }
}