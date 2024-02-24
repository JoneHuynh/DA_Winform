namespace _21_4_qlbandienthoai.Forms
{
    partial class frmPhienBanRunTime
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
            this.flpphienban = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpphienban
            // 
            this.flpphienban.Location = new System.Drawing.Point(22, 24);
            this.flpphienban.Margin = new System.Windows.Forms.Padding(2);
            this.flpphienban.Name = "flpphienban";
            this.flpphienban.Size = new System.Drawing.Size(426, 228);
            this.flpphienban.TabIndex = 5;
            // 
            // btnChon
            // 
            this.btnChon.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChon.Location = new System.Drawing.Point(353, 258);
            this.btnChon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(94, 31);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(250, 258);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // frmPhienBanRunTime
            // 
            this.AcceptButton = this.btnChon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 310);
            this.Controls.Add(this.flpphienban);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnThem);
            this.Name = "frmPhienBanRunTime";
            this.Text = "Phiên bản";
            this.Load += new System.EventHandler(this.frmPhienBanRunTime_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpphienban;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThem;
    }
}