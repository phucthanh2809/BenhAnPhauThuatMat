namespace PN_EMR
{
    partial class Form_Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alert));
            this.lblMsg = new System.Windows.Forms.Label();
            this.pic_Success = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_Info = new System.Windows.Forms.PictureBox();
            this.pic_Warning = new System.Windows.Forms.PictureBox();
            this.pic_Error = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Success)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(65, 22);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(122, 23);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message Text";
            // 
            // pic_Success
            // 
            this.pic_Success.Image = ((System.Drawing.Image)(resources.GetObject("pic_Success.Image")));
            this.pic_Success.Location = new System.Drawing.Point(12, 13);
            this.pic_Success.Name = "pic_Success";
            this.pic_Success.Size = new System.Drawing.Size(41, 39);
            this.pic_Success.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Success.TabIndex = 2;
            this.pic_Success.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(425, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_Info
            // 
            this.pic_Info.Image = ((System.Drawing.Image)(resources.GetObject("pic_Info.Image")));
            this.pic_Info.Location = new System.Drawing.Point(233, 6);
            this.pic_Info.Name = "pic_Info";
            this.pic_Info.Size = new System.Drawing.Size(41, 39);
            this.pic_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Info.TabIndex = 4;
            this.pic_Info.TabStop = false;
            this.pic_Info.Visible = false;
            // 
            // pic_Warning
            // 
            this.pic_Warning.Image = ((System.Drawing.Image)(resources.GetObject("pic_Warning.Image")));
            this.pic_Warning.Location = new System.Drawing.Point(280, 6);
            this.pic_Warning.Name = "pic_Warning";
            this.pic_Warning.Size = new System.Drawing.Size(41, 39);
            this.pic_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Warning.TabIndex = 5;
            this.pic_Warning.TabStop = false;
            this.pic_Warning.Visible = false;
            // 
            // pic_Error
            // 
            this.pic_Error.Image = ((System.Drawing.Image)(resources.GetObject("pic_Error.Image")));
            this.pic_Error.Location = new System.Drawing.Point(327, 6);
            this.pic_Error.Name = "pic_Error";
            this.pic_Error.Size = new System.Drawing.Size(41, 39);
            this.pic_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Error.TabIndex = 6;
            this.pic_Error.TabStop = false;
            this.pic_Error.Visible = false;
            // 
            // Form_Alert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(463, 61);
            this.Controls.Add(this.pic_Error);
            this.Controls.Add(this.pic_Warning);
            this.Controls.Add(this.pic_Info);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_Success);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Alert";
            this.Text = "Form_Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Success)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pic_Success;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_Info;
        private System.Windows.Forms.PictureBox pic_Warning;
        private System.Windows.Forms.PictureBox pic_Error;
    }
}