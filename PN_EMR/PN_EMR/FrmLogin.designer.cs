
namespace PN_EMR
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayLamViec = new huserControl.hTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaOTP = new huserControl.hTextBox();
            this.txtPassword = new huserControl.hTextBox();
            this.txtUserName = new huserControl.hTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 57);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ thống quản lý Bệnh án điện tử (EMR)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1284, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 57);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-46, -65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(401, 587);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(547, 39);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Đăng Nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(524, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(579, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng Nhập Làm Việc";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(397, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu (Password):";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(792, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quên mật khẩu?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(397, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên đăng nhập (User Name):";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(8, 735);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Copyrights © 2022. All rights Reserved By Funa.";
            // 
            // txtNgayLamViec
            // 
            this.txtNgayLamViec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgayLamViec.BackColor = System.Drawing.Color.White;
            this.txtNgayLamViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayLamViec.Font = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLamViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtNgayLamViec.Location = new System.Drawing.Point(401, 491);
            this.txtNgayLamViec.Name = "txtNgayLamViec";
            this.txtNgayLamViec.Size = new System.Drawing.Size(123, 32);
            this.txtNgayLamViec.TabIndex = 2;
            this.txtNgayLamViec.TabStop = false;
            this.txtNgayLamViec.Text = "01/01/2010";
            this.txtNgayLamViec.xBorderStyle = huserControl.hBorderStyle.UnderLine;
            this.txtNgayLamViec.xChoPhepRong = false;
            this.txtNgayLamViec.xDataType = huserControl.mDataType.xDate;
            this.txtNgayLamViec.xDefaultBackGroundColor = System.Drawing.Color.White;
            this.txtNgayLamViec.xDefaultFont = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLamViec.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtNgayLamViec.xFontFocus = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNgayLamViec.xGetYYYYmmdd = 20100101D;
            this.txtNgayLamViec.xGetYYYYmmddhhmmss = null;
            this.txtNgayLamViec.xLable = null;
            this.txtNgayLamViec.xLayDulieu = true;
            this.txtNgayLamViec.xOneSpaceInText = true;
            this.txtNgayLamViec.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtNgayLamViec.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtNgayLamViec.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtNgayLamViec.xTentruongDulieu = "ngaysinh";
            this.txtNgayLamViec.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.txtNgayLamViec.xYeucauNhapDulieu = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.label7.Location = new System.Drawing.Point(397, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày làm việc:";
            // 
            // txtMaOTP
            // 
            this.txtMaOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaOTP.BackColor = System.Drawing.Color.White;
            this.txtMaOTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaOTP.Font = new System.Drawing.Font("UTM Avo", 14.25F);
            this.txtMaOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtMaOTP.Location = new System.Drawing.Point(713, 491);
            this.txtMaOTP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaOTP.Name = "txtMaOTP";
            this.txtMaOTP.Size = new System.Drawing.Size(235, 33);
            this.txtMaOTP.TabIndex = 3;
            this.txtMaOTP.TabStop = false;
            this.txtMaOTP.xBorderStyle = huserControl.hBorderStyle.UnderLine;
            this.txtMaOTP.xChoPhepRong = false;
            this.txtMaOTP.xDataType = huserControl.mDataType.xStandard;
            this.txtMaOTP.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtMaOTP.xDefaultFont = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMaOTP.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtMaOTP.xFontFocus = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMaOTP.xGetYYYYmmdd = null;
            this.txtMaOTP.xGetYYYYmmddhhmmss = null;
            this.txtMaOTP.xLable = null;
            this.txtMaOTP.xLayDulieu = true;
            this.txtMaOTP.xOneSpaceInText = true;
            this.txtMaOTP.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtMaOTP.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtMaOTP.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtMaOTP.xTentruongDulieu = "";
            this.txtMaOTP.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.txtMaOTP.xYeucauNhapDulieu = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtPassword.Location = new System.Drawing.Point(401, 416);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(547, 33);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "123";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.xBorderStyle = huserControl.hBorderStyle.UnderLine;
            this.txtPassword.xChoPhepRong = false;
            this.txtPassword.xDataType = huserControl.mDataType.xStandard;
            this.txtPassword.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtPassword.xDefaultFont = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtPassword.xFontFocus = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.xGetYYYYmmdd = null;
            this.txtPassword.xGetYYYYmmddhhmmss = null;
            this.txtPassword.xLable = null;
            this.txtPassword.xLayDulieu = true;
            this.txtPassword.xOneSpaceInText = true;
            this.txtPassword.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtPassword.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtPassword.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtPassword.xTentruongDulieu = "";
            this.txtPassword.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.txtPassword.xYeucauNhapDulieu = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("UTM Avo", 14.25F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(401, 343);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(547, 33);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "DUH001";
            this.txtUserName.xBorderStyle = huserControl.hBorderStyle.UnderLine;
            this.txtUserName.xChoPhepRong = false;
            this.txtUserName.xDataType = huserControl.mDataType.xUpperCase;
            this.txtUserName.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtUserName.xDefaultFont = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtUserName.xFontFocus = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtUserName.xGetYYYYmmdd = null;
            this.txtUserName.xGetYYYYmmddhhmmss = null;
            this.txtUserName.xLable = null;
            this.txtUserName.xLayDulieu = true;
            this.txtUserName.xOneSpaceInText = true;
            this.txtUserName.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtUserName.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtUserName.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtUserName.xTentruongDulieu = "";
            this.txtUserName.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.txtUserName.xYeucauNhapDulieu = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(868, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã OTP:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 761);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaOTP);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgayLamViec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private huserControl.hTextBox txtNgayLamViec;
        private System.Windows.Forms.Label label7;
        private huserControl.hTextBox txtMaOTP;
        private huserControl.hTextBox txtPassword;
        public huserControl.hTextBox txtUserName;
        private System.Windows.Forms.Label label8;
    }
}