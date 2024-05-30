
namespace PN_EMR
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label4 = new System.Windows.Forms.Label();
            this.lbltendangky = new System.Windows.Forms.Label();
            this.btLogin = new huserControl.hButton();
            this.txtUserName = new huserControl.hTextBox();
            this.txtPassword = new huserControl.hTextBox();
            this.btSuDung = new huserControl.hButton();
            this.txtHoTenNguoiDung = new huserControl.hTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hTextBox3 = new huserControl.hTextBox();
            this.txtNgayLamViec = new huserControl.hTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.P_dangnhap = new System.Windows.Forms.Panel();
            this.linkDoimatkhau = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btclose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.P_dangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 516);
            this.label4.TabIndex = 52;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltendangky
            // 
            this.lbltendangky.AutoSize = true;
            this.lbltendangky.BackColor = System.Drawing.Color.White;
            this.lbltendangky.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltendangky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.lbltendangky.Location = new System.Drawing.Point(248, 162);
            this.lbltendangky.Name = "lbltendangky";
            this.lbltendangky.Size = new System.Drawing.Size(80, 18);
            this.lbltendangky.TabIndex = 43;
            this.lbltendangky.Text = "Tài khoản";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.White;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btLogin.Location = new System.Drawing.Point(23, 364);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(152, 33);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.xEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtUserName.Location = new System.Drawing.Point(93, 185);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(235, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "HUD005";
            this.txtUserName.xBorderStyle = huserControl.hBorderStyle.UnderLine;
            this.txtUserName.xChoPhepRong = false;
            this.txtUserName.xDataType = huserControl.mDataType.xUpperCase;
            this.txtUserName.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtUserName.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtUserName.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.xGetYYYYmmdd = null;
            this.txtUserName.xGetYYYYmmddhhmmss = null;
            this.txtUserName.xLable = null;
            this.txtUserName.xLayDulieu = true;
            this.txtUserName.xOneSpaceInText = true;
            this.txtUserName.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtUserName.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtUserName.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtUserName.xTentruongDulieu = "";
            this.txtUserName.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtUserName.xYeucauNhapDulieu = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtPassword.Location = new System.Drawing.Point(93, 230);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(235, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "123";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.xBorderStyle = huserControl.hBorderStyle.UnderLine;
            this.txtPassword.xChoPhepRong = false;
            this.txtPassword.xDataType = huserControl.mDataType.xStandard;
            this.txtPassword.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtPassword.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtPassword.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.xGetYYYYmmdd = null;
            this.txtPassword.xGetYYYYmmddhhmmss = null;
            this.txtPassword.xLable = null;
            this.txtPassword.xLayDulieu = true;
            this.txtPassword.xOneSpaceInText = true;
            this.txtPassword.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtPassword.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtPassword.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtPassword.xTentruongDulieu = "";
            this.txtPassword.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtPassword.xYeucauNhapDulieu = true;
            // 
            // btSuDung
            // 
            this.btSuDung.BackColor = System.Drawing.Color.White;
            this.btSuDung.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSuDung.Enabled = false;
            this.btSuDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btSuDung.Location = new System.Drawing.Point(183, 364);
            this.btSuDung.Margin = new System.Windows.Forms.Padding(2);
            this.btSuDung.Name = "btSuDung";
            this.btSuDung.Size = new System.Drawing.Size(152, 33);
            this.btSuDung.TabIndex = 3;
            this.btSuDung.Text = "Sử dụng";
            this.btSuDung.UseVisualStyleBackColor = false;
            this.btSuDung.xEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.btSuDung.Click += new System.EventHandler(this.btSuDung_Click);
            // 
            // txtHoTenNguoiDung
            // 
            this.txtHoTenNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtHoTenNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtHoTenNguoiDung.ForeColor = System.Drawing.Color.White;
            this.txtHoTenNguoiDung.Location = new System.Drawing.Point(26, 93);
            this.txtHoTenNguoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTenNguoiDung.Name = "txtHoTenNguoiDung";
            this.txtHoTenNguoiDung.Size = new System.Drawing.Size(307, 19);
            this.txtHoTenNguoiDung.TabIndex = 8;
            this.txtHoTenNguoiDung.TabStop = false;
            this.txtHoTenNguoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoTenNguoiDung.xBorderStyle = huserControl.hBorderStyle.None;
            this.txtHoTenNguoiDung.xChoPhepRong = false;
            this.txtHoTenNguoiDung.xDataType = huserControl.mDataType.xStandard;
            this.txtHoTenNguoiDung.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtHoTenNguoiDung.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNguoiDung.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtHoTenNguoiDung.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNguoiDung.xGetYYYYmmdd = null;
            this.txtHoTenNguoiDung.xGetYYYYmmddhhmmss = null;
            this.txtHoTenNguoiDung.xLable = null;
            this.txtHoTenNguoiDung.xLayDulieu = true;
            this.txtHoTenNguoiDung.xOneSpaceInText = true;
            this.txtHoTenNguoiDung.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtHoTenNguoiDung.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtHoTenNguoiDung.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtHoTenNguoiDung.xTentruongDulieu = "";
            this.txtHoTenNguoiDung.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtHoTenNguoiDung.xYeucauNhapDulieu = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.label8.Location = new System.Drawing.Point(263, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Mã OTP";
            // 
            // hTextBox3
            // 
            this.hTextBox3.BackColor = System.Drawing.Color.White;
            this.hTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.hTextBox3.Location = new System.Drawing.Point(93, 275);
            this.hTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.hTextBox3.Name = "hTextBox3";
            this.hTextBox3.Size = new System.Drawing.Size(235, 20);
            this.hTextBox3.TabIndex = 5;
            this.hTextBox3.xBorderStyle = huserControl.hBorderStyle.UnderLine;
            this.hTextBox3.xChoPhepRong = false;
            this.hTextBox3.xDataType = huserControl.mDataType.xStandard;
            this.hTextBox3.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.hTextBox3.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hTextBox3.xDefaultForeColor = System.Drawing.Color.Empty;
            this.hTextBox3.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hTextBox3.xGetYYYYmmdd = null;
            this.hTextBox3.xGetYYYYmmddhhmmss = null;
            this.hTextBox3.xLable = null;
            this.hTextBox3.xLayDulieu = true;
            this.hTextBox3.xOneSpaceInText = true;
            this.hTextBox3.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.hTextBox3.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.hTextBox3.xSelectForeColor = System.Drawing.Color.Blue;
            this.hTextBox3.xTentruongDulieu = "";
            this.hTextBox3.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.hTextBox3.xYeucauNhapDulieu = true;
            // 
            // txtNgayLamViec
            // 
            this.txtNgayLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgayLamViec.BackColor = System.Drawing.Color.White;
            this.txtNgayLamViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtNgayLamViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtNgayLamViec.Location = new System.Drawing.Point(93, 320);
            this.txtNgayLamViec.Name = "txtNgayLamViec";
            this.txtNgayLamViec.Size = new System.Drawing.Size(235, 20);
            this.txtNgayLamViec.TabIndex = 6;
            this.txtNgayLamViec.Text = "01/01/2010";
            this.txtNgayLamViec.xBorderStyle = huserControl.hBorderStyle.UnderLine;
            this.txtNgayLamViec.xChoPhepRong = false;
            this.txtNgayLamViec.xDataType = huserControl.mDataType.xDate;
            this.txtNgayLamViec.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtNgayLamViec.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLamViec.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtNgayLamViec.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLamViec.xGetYYYYmmdd = 20100101D;
            this.txtNgayLamViec.xGetYYYYmmddhhmmss = null;
            this.txtNgayLamViec.xLable = null;
            this.txtNgayLamViec.xLayDulieu = true;
            this.txtNgayLamViec.xOneSpaceInText = true;
            this.txtNgayLamViec.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtNgayLamViec.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtNgayLamViec.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtNgayLamViec.xTentruongDulieu = "ngaysinh";
            this.txtNgayLamViec.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.txtNgayLamViec.xYeucauNhapDulieu = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.label9.Location = new System.Drawing.Point(215, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ngày làm việc";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(359, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 516);
            this.label2.TabIndex = 71;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 1);
            this.label3.TabIndex = 72;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 1);
            this.label1.TabIndex = 73;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.label10.Location = new System.Drawing.Point(252, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Mật khẩu";
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(26, 69);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(307, 20);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "Xin chào";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_dangnhap
            // 
            this.P_dangnhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("P_dangnhap.BackgroundImage")));
            this.P_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_dangnhap.Controls.Add(this.linkDoimatkhau);
            this.P_dangnhap.Controls.Add(this.pictureBox2);
            this.P_dangnhap.Controls.Add(this.btclose);
            this.P_dangnhap.Controls.Add(this.btSuDung);
            this.P_dangnhap.Controls.Add(this.btLogin);
            this.P_dangnhap.Controls.Add(this.pictureBox3);
            this.P_dangnhap.Controls.Add(this.pictureBox1);
            this.P_dangnhap.Controls.Add(this.lblCaption);
            this.P_dangnhap.Controls.Add(this.txtHoTenNguoiDung);
            this.P_dangnhap.Controls.Add(this.txtNgayLamViec);
            this.P_dangnhap.Controls.Add(this.label9);
            this.P_dangnhap.Controls.Add(this.hTextBox3);
            this.P_dangnhap.Controls.Add(this.label8);
            this.P_dangnhap.Controls.Add(this.txtPassword);
            this.P_dangnhap.Controls.Add(this.lbltendangky);
            this.P_dangnhap.Controls.Add(this.txtUserName);
            this.P_dangnhap.Controls.Add(this.label10);
            this.P_dangnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.P_dangnhap.Location = new System.Drawing.Point(1, 1);
            this.P_dangnhap.Name = "P_dangnhap";
            this.P_dangnhap.Size = new System.Drawing.Size(358, 514);
            this.P_dangnhap.TabIndex = 0;
            this.P_dangnhap.Paint += new System.Windows.Forms.PaintEventHandler(this.P_dangnhap_Paint);
            this.P_dangnhap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_dangnhap_MouseMove);
            // 
            // linkDoimatkhau
            // 
            this.linkDoimatkhau.AutoSize = true;
            this.linkDoimatkhau.BackColor = System.Drawing.Color.Transparent;
            this.linkDoimatkhau.Enabled = false;
            this.linkDoimatkhau.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.linkDoimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.linkDoimatkhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.linkDoimatkhau.Location = new System.Drawing.Point(26, 480);
            this.linkDoimatkhau.Name = "linkDoimatkhau";
            this.linkDoimatkhau.Size = new System.Drawing.Size(106, 18);
            this.linkDoimatkhau.TabIndex = 4;
            this.linkDoimatkhau.TabStop = true;
            this.linkDoimatkhau.Text = "Đổi mật khẩu";
            this.linkDoimatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkDoimatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // btclose
            // 
            this.btclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btclose.Image = ((System.Drawing.Image)(resources.GetObject("btclose.Image")));
            this.btclose.Location = new System.Drawing.Point(339, 0);
            this.btclose.Margin = new System.Windows.Forms.Padding(8);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(17, 17);
            this.btclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btclose.TabIndex = 85;
            this.btclose.TabStop = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(149, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 516);
            this.ControlBox = false;
            this.Controls.Add(this.P_dangnhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.P_dangnhap.ResumeLayout(false);
            this.P_dangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltendangky;
        private huserControl.hButton btLogin;
        private huserControl.hTextBox txtPassword;
        private huserControl.hButton btSuDung;
        private System.Windows.Forms.Label label8;
        private huserControl.hTextBox hTextBox3;
        private huserControl.hTextBox txtNgayLamViec;
        private System.Windows.Forms.Label label9;
        public huserControl.hTextBox txtUserName;
        public huserControl.hTextBox txtHoTenNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel P_dangnhap;
        private System.Windows.Forms.LinkLabel linkDoimatkhau;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btclose;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}