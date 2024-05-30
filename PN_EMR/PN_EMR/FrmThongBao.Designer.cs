
namespace PN_EMR
{
    partial class FrmThongBao
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
            this.p_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hbt_ThoatKetQua = new huserControl.hButton();
            this.txtNoiDung = new huserControl.hTextBox();
            this.p_top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(145)))));
            this.p_top.Controls.Add(this.label1);
            this.p_top.Controls.Add(this.panel1);
            this.p_top.Controls.Add(this.label15);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.ForeColor = System.Drawing.Color.White;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(716, 63);
            this.p_top.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 1);
            this.label1.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 1);
            this.panel1.TabIndex = 80;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "THÔNG BÁO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.hbt_ThoatKetQua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 48);
            this.panel2.TabIndex = 96;
            // 
            // hbt_ThoatKetQua
            // 
            this.hbt_ThoatKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hbt_ThoatKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbt_ThoatKetQua.Location = new System.Drawing.Point(500, 5);
            this.hbt_ThoatKetQua.Margin = new System.Windows.Forms.Padding(5);
            this.hbt_ThoatKetQua.Name = "hbt_ThoatKetQua";
            this.hbt_ThoatKetQua.Size = new System.Drawing.Size(209, 38);
            this.hbt_ThoatKetQua.TabIndex = 95;
            this.hbt_ThoatKetQua.Text = "Thoát";
            this.hbt_ThoatKetQua.UseVisualStyleBackColor = true;
            this.hbt_ThoatKetQua.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.hbt_ThoatKetQua.Click += new System.EventHandler(this.hbt_ThoatKetQua_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.Color.White;
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.ForeColor = System.Drawing.Color.Red;
            this.txtNoiDung.Location = new System.Drawing.Point(0, 63);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(716, 240);
            this.txtNoiDung.TabIndex = 97;
            this.txtNoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoiDung.xBorderStyle = huserControl.hBorderStyle.FixedSinge;
            this.txtNoiDung.xChoPhepRong = false;
            this.txtNoiDung.xDataType = huserControl.mDataType.xStandard;
            this.txtNoiDung.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtNoiDung.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtNoiDung.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.xGetYYYYmmdd = null;
            this.txtNoiDung.xGetYYYYmmddhhmmss = null;
            this.txtNoiDung.xLable = null;
            this.txtNoiDung.xLayDulieu = true;
            this.txtNoiDung.xOneSpaceInText = true;
            this.txtNoiDung.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtNoiDung.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtNoiDung.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtNoiDung.xTentruongDulieu = "";
            this.txtNoiDung.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtNoiDung.xYeucauNhapDulieu = true;
            // 
            // FrmThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 351);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.p_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongBao";
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        public huserControl.hButton hbt_ThoatKetQua;
        public huserControl.hTextBox txtNoiDung;
    }
}