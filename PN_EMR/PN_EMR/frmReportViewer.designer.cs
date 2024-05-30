
namespace PN_EMR
{
    partial class frmReportViewer
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
            this.previewControl2 = new FastReport.Preview.PreviewControl();
            this.SuspendLayout();
            // 
            // previewControl2
            // 
            this.previewControl2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.previewControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewControl2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.previewControl2.Location = new System.Drawing.Point(0, 0);
            this.previewControl2.Name = "previewControl2";
            this.previewControl2.PageOffset = new System.Drawing.Point(10, 10);
            this.previewControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.previewControl2.SaveInitialDirectory = null;
            this.previewControl2.Size = new System.Drawing.Size(1060, 579);
            this.previewControl2.TabIndex = 1;
            // 
            // frmReportViewer
            // 
            this.ClientSize = new System.Drawing.Size(1060, 579);
            this.Controls.Add(this.previewControl2);
            this.Name = "frmReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReportViewer_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmReportViewer_KeyUp);
            this.ResumeLayout(false);

        }

        private FastReport.Preview.PreviewControl previewControl2;

        #endregion
        // private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}