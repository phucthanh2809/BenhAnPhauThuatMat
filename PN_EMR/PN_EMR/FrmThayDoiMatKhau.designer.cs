
namespace PN_EMR
{
    partial class FrmThayDoiMatKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.chk_hienmatkhau = new huserControl.hCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txthoten_dk = new huserControl.hTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtxacnhanmatkhau_dk = new huserControl.hTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmatkhau_dk = new huserControl.hTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttaikhoan_dk = new huserControl.hTextBox();
            this.txtmatkhauhientai = new huserControl.hTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btthoattaonguoidung = new System.Windows.Forms.Button();
            this.hbt_boqua = new huserControl.hButton();
            this.hbt_dangky = new huserControl.hButton();
            this.p_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(145)))));
            this.p_top.Controls.Add(this.panel1);
            this.p_top.Controls.Add(this.label15);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.ForeColor = System.Drawing.Color.White;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(492, 63);
            this.p_top.TabIndex = 91;
            this.p_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 80;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // chk_hienmatkhau
            // 
            this.chk_hienmatkhau.AutoSize = true;
            this.chk_hienmatkhau.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_hienmatkhau.Location = new System.Drawing.Point(319, 270);
            this.chk_hienmatkhau.Name = "chk_hienmatkhau";
            this.chk_hienmatkhau.Size = new System.Drawing.Size(122, 22);
            this.chk_hienmatkhau.TabIndex = 107;
            this.chk_hienmatkhau.Text = "Hiện mật khẩu";
            this.chk_hienmatkhau.UseVisualStyleBackColor = true;
            this.chk_hienmatkhau.xLayDulieu = true;
            this.chk_hienmatkhau.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.chk_hienmatkhau.xTentruongDulieu = "";
            this.chk_hienmatkhau.xValue = false;
            this.chk_hienmatkhau.xYeucauNhapDulieu = true;
            this.chk_hienmatkhau.CheckedChanged += new System.EventHandler(this.chk_hienmatkhau_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 108;
            this.label5.Text = "Tài khoản:";
            // 
            // txthoten_dk
            // 
            this.txthoten_dk.BackColor = System.Drawing.Color.White;
            this.txthoten_dk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthoten_dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txthoten_dk.ForeColor = System.Drawing.Color.Black;
            this.txthoten_dk.Location = new System.Drawing.Point(146, 121);
            this.txthoten_dk.Margin = new System.Windows.Forms.Padding(2);
            this.txthoten_dk.Name = "txthoten_dk";
            this.txthoten_dk.ReadOnly = true;
            this.txthoten_dk.Size = new System.Drawing.Size(295, 20);
            this.txthoten_dk.TabIndex = 104;
            this.txthoten_dk.TabStop = false;
            this.txthoten_dk.xBorderStyle = huserControl.hBorderStyle.Dotted;
            this.txthoten_dk.xChoPhepRong = false;
            this.txthoten_dk.xDataType = huserControl.mDataType.xStandard;
            this.txthoten_dk.xDefaultBackGroundColor = System.Drawing.SystemColors.Control;
            this.txthoten_dk.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten_dk.xDefaultForeColor = System.Drawing.Color.Black;
            this.txthoten_dk.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten_dk.xGetYYYYmmdd = null;
            this.txthoten_dk.xGetYYYYmmddhhmmss = null;
            this.txthoten_dk.xLable = this.label12;
            this.txthoten_dk.xLayDulieu = true;
            this.txthoten_dk.xOneSpaceInText = true;
            this.txthoten_dk.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master2;
            this.txthoten_dk.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txthoten_dk.xSelectForeColor = System.Drawing.Color.Blue;
            this.txthoten_dk.xTentruongDulieu = "hotennguoidung";
            this.txthoten_dk.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txthoten_dk.xYeucauNhapDulieu = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(62, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 18);
            this.label12.TabIndex = 109;
            this.label12.Text = "Họ và tên:";
            // 
            // txtxacnhanmatkhau_dk
            // 
            this.txtxacnhanmatkhau_dk.BackColor = System.Drawing.Color.White;
            this.txtxacnhanmatkhau_dk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtxacnhanmatkhau_dk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtxacnhanmatkhau_dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhanmatkhau_dk.ForeColor = System.Drawing.Color.Black;
            this.txtxacnhanmatkhau_dk.Location = new System.Drawing.Point(146, 234);
            this.txtxacnhanmatkhau_dk.Margin = new System.Windows.Forms.Padding(2);
            this.txtxacnhanmatkhau_dk.Name = "txtxacnhanmatkhau_dk";
            this.txtxacnhanmatkhau_dk.Size = new System.Drawing.Size(295, 20);
            this.txtxacnhanmatkhau_dk.TabIndex = 106;
            this.txtxacnhanmatkhau_dk.UseSystemPasswordChar = true;
            this.txtxacnhanmatkhau_dk.xBorderStyle = huserControl.hBorderStyle.Dotted;
            this.txtxacnhanmatkhau_dk.xChoPhepRong = false;
            this.txtxacnhanmatkhau_dk.xDataType = huserControl.mDataType.xStandard;
            this.txtxacnhanmatkhau_dk.xDefaultBackGroundColor = System.Drawing.SystemColors.Control;
            this.txtxacnhanmatkhau_dk.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhanmatkhau_dk.xDefaultForeColor = System.Drawing.Color.Black;
            this.txtxacnhanmatkhau_dk.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhanmatkhau_dk.xGetYYYYmmdd = null;
            this.txtxacnhanmatkhau_dk.xGetYYYYmmddhhmmss = null;
            this.txtxacnhanmatkhau_dk.xLable = this.label13;
            this.txtxacnhanmatkhau_dk.xLayDulieu = true;
            this.txtxacnhanmatkhau_dk.xOneSpaceInText = true;
            this.txtxacnhanmatkhau_dk.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtxacnhanmatkhau_dk.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtxacnhanmatkhau_dk.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtxacnhanmatkhau_dk.xTentruongDulieu = "xacnhanmatkhau";
            this.txtxacnhanmatkhau_dk.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtxacnhanmatkhau_dk.xYeucauNhapDulieu = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(42, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 18);
            this.label13.TabIndex = 110;
            this.label13.Text = "Xác nhận lại:";
            // 
            // txtmatkhau_dk
            // 
            this.txtmatkhau_dk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatkhau_dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau_dk.Location = new System.Drawing.Point(146, 196);
            this.txtmatkhau_dk.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatkhau_dk.Name = "txtmatkhau_dk";
            this.txtmatkhau_dk.Size = new System.Drawing.Size(295, 20);
            this.txtmatkhau_dk.TabIndex = 105;
            this.txtmatkhau_dk.UseSystemPasswordChar = true;
            this.txtmatkhau_dk.xBorderStyle = huserControl.hBorderStyle.Dotted;
            this.txtmatkhau_dk.xChoPhepRong = false;
            this.txtmatkhau_dk.xDataType = huserControl.mDataType.xStandard;
            this.txtmatkhau_dk.xDefaultBackGroundColor = System.Drawing.SystemColors.Control;
            this.txtmatkhau_dk.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau_dk.xDefaultForeColor = System.Drawing.Color.Black;
            this.txtmatkhau_dk.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau_dk.xGetYYYYmmdd = null;
            this.txtmatkhau_dk.xGetYYYYmmddhhmmss = null;
            this.txtmatkhau_dk.xLable = this.label11;
            this.txtmatkhau_dk.xLayDulieu = true;
            this.txtmatkhau_dk.xOneSpaceInText = true;
            this.txtmatkhau_dk.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master2;
            this.txtmatkhau_dk.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtmatkhau_dk.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtmatkhau_dk.xTentruongDulieu = "matkhau";
            this.txtmatkhau_dk.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtmatkhau_dk.xYeucauNhapDulieu = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(64, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 111;
            this.label11.Text = "Mật khẩu:";
            // 
            // txttaikhoan_dk
            // 
            this.txttaikhoan_dk.BackColor = System.Drawing.Color.White;
            this.txttaikhoan_dk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttaikhoan_dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaikhoan_dk.Location = new System.Drawing.Point(146, 83);
            this.txttaikhoan_dk.Margin = new System.Windows.Forms.Padding(2);
            this.txttaikhoan_dk.Name = "txttaikhoan_dk";
            this.txttaikhoan_dk.ReadOnly = true;
            this.txttaikhoan_dk.Size = new System.Drawing.Size(295, 20);
            this.txttaikhoan_dk.TabIndex = 103;
            this.txttaikhoan_dk.xBorderStyle = huserControl.hBorderStyle.Dotted;
            this.txttaikhoan_dk.xChoPhepRong = false;
            this.txttaikhoan_dk.xDataType = huserControl.mDataType.xUpperCase;
            this.txttaikhoan_dk.xDefaultBackGroundColor = System.Drawing.SystemColors.Control;
            this.txttaikhoan_dk.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaikhoan_dk.xDefaultForeColor = System.Drawing.Color.Black;
            this.txttaikhoan_dk.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaikhoan_dk.xGetYYYYmmdd = null;
            this.txttaikhoan_dk.xGetYYYYmmddhhmmss = null;
            this.txttaikhoan_dk.xLable = this.label5;
            this.txttaikhoan_dk.xLayDulieu = true;
            this.txttaikhoan_dk.xOneSpaceInText = true;
            this.txttaikhoan_dk.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master2;
            this.txttaikhoan_dk.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txttaikhoan_dk.xSelectForeColor = System.Drawing.Color.Blue;
            this.txttaikhoan_dk.xTentruongDulieu = "manguoidung";
            this.txttaikhoan_dk.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txttaikhoan_dk.xYeucauNhapDulieu = true;
            this.txttaikhoan_dk.Leave += new System.EventHandler(this.txttaikhoan_dk_Leave);
            // 
            // txtmatkhauhientai
            // 
            this.txtmatkhauhientai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatkhauhientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhauhientai.Location = new System.Drawing.Point(146, 159);
            this.txtmatkhauhientai.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatkhauhientai.Name = "txtmatkhauhientai";
            this.txtmatkhauhientai.Size = new System.Drawing.Size(295, 20);
            this.txtmatkhauhientai.TabIndex = 112;
            this.txtmatkhauhientai.UseSystemPasswordChar = true;
            this.txtmatkhauhientai.xBorderStyle = huserControl.hBorderStyle.Dotted;
            this.txtmatkhauhientai.xChoPhepRong = false;
            this.txtmatkhauhientai.xDataType = huserControl.mDataType.xStandard;
            this.txtmatkhauhientai.xDefaultBackGroundColor = System.Drawing.SystemColors.Control;
            this.txtmatkhauhientai.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhauhientai.xDefaultForeColor = System.Drawing.Color.Black;
            this.txtmatkhauhientai.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhauhientai.xGetYYYYmmdd = null;
            this.txtmatkhauhientai.xGetYYYYmmddhhmmss = null;
            this.txtmatkhauhientai.xLable = this.label1;
            this.txtmatkhauhientai.xLayDulieu = false;
            this.txtmatkhauhientai.xOneSpaceInText = true;
            this.txtmatkhauhientai.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master2;
            this.txtmatkhauhientai.xSelectBackGroundColor = System.Drawing.SystemColors.Info;
            this.txtmatkhauhientai.xSelectForeColor = System.Drawing.Color.Blue;
            this.txtmatkhauhientai.xTentruongDulieu = "";
            this.txtmatkhauhientai.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtmatkhauhientai.xYeucauNhapDulieu = true;
            this.txtmatkhauhientai.Leave += new System.EventHandler(this.txtmatkhauhientai_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 113;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // btthoattaonguoidung
            // 
            this.btthoattaonguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthoattaonguoidung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btthoattaonguoidung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btthoattaonguoidung.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btthoattaonguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoattaonguoidung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(79)))));
            this.btthoattaonguoidung.Location = new System.Drawing.Point(311, 307);
            this.btthoattaonguoidung.Name = "btthoattaonguoidung";
            this.btthoattaonguoidung.Size = new System.Drawing.Size(130, 35);
            this.btthoattaonguoidung.TabIndex = 116;
            this.btthoattaonguoidung.Text = "Thoát";
            this.btthoattaonguoidung.UseVisualStyleBackColor = false;
            this.btthoattaonguoidung.Click += new System.EventHandler(this.btthoattaonguoidung_Click);
            // 
            // hbt_boqua
            // 
            this.hbt_boqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.hbt_boqua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hbt_boqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbt_boqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(79)))));
            this.hbt_boqua.Location = new System.Drawing.Point(45, 307);
            this.hbt_boqua.Margin = new System.Windows.Forms.Padding(2);
            this.hbt_boqua.Name = "hbt_boqua";
            this.hbt_boqua.Size = new System.Drawing.Size(130, 35);
            this.hbt_boqua.TabIndex = 115;
            this.hbt_boqua.Text = "Nhập mới";
            this.hbt_boqua.UseVisualStyleBackColor = false;
            this.hbt_boqua.xEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.hbt_boqua.Click += new System.EventHandler(this.hbt_boqua_Click);
            // 
            // hbt_dangky
            // 
            this.hbt_dangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.hbt_dangky.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hbt_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbt_dangky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(79)))));
            this.hbt_dangky.Location = new System.Drawing.Point(178, 307);
            this.hbt_dangky.Margin = new System.Windows.Forms.Padding(2);
            this.hbt_dangky.Name = "hbt_dangky";
            this.hbt_dangky.Size = new System.Drawing.Size(130, 35);
            this.hbt_dangky.TabIndex = 114;
            this.hbt_dangky.Text = "Lưu dữ liệu";
            this.hbt_dangky.UseVisualStyleBackColor = false;
            this.hbt_dangky.xEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.hbt_dangky.Click += new System.EventHandler(this.hbt_dangky_Click);
            // 
            // FrmThayDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 358);
            this.Controls.Add(this.btthoattaonguoidung);
            this.Controls.Add(this.hbt_boqua);
            this.Controls.Add(this.hbt_dangky);
            this.Controls.Add(this.txtmatkhauhientai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_hienmatkhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txthoten_dk);
            this.Controls.Add(this.txtxacnhanmatkhau_dk);
            this.Controls.Add(this.txtmatkhau_dk);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttaikhoan_dk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.p_top);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmThayDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThayDoiMatKhau";
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private huserControl.hCheckBox chk_hienmatkhau;
        private System.Windows.Forms.Label label5;
        public huserControl.hTextBox txthoten_dk;
        private System.Windows.Forms.Label label12;
        private huserControl.hTextBox txtxacnhanmatkhau_dk;
        private System.Windows.Forms.Label label13;
        private huserControl.hTextBox txtmatkhau_dk;
        private System.Windows.Forms.Label label11;
        public huserControl.hTextBox txttaikhoan_dk;
        private huserControl.hTextBox txtmatkhauhientai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthoattaonguoidung;
        private huserControl.hButton hbt_boqua;
        private huserControl.hButton hbt_dangky;
    }
}