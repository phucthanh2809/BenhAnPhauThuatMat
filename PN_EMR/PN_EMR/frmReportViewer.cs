using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;

namespace PN_EMR
{
    public partial class frmReportViewer : Form
    {
        Report report = new Report();

        public frmReportViewer(string reportName, string repotData, Report _report)
        {
            InitializeComponent();
            this.Text = reportName;
            report = _report;
            //report.Load(Application.StartupPath + @"\reports\" + reportName + ".frx");
            ////set thong tin cong ty
            //var logo = report.Report.FindObject("logo") as PictureObject;
            ////logo.ImageLocation = Application.StartupPath + $@"/logo.jpg";
            //var txtTenCongTy = report.Report.FindObject("txtTenCongTy") as TextObject;
            //txtTenCongTy.Text = mConst.CongTy;
            //var txtDiaChi = report.Report.FindObject("txtDiaChi") as TextObject;
            //txtDiaChi.Text = mConst.CongTyDiaChi;
            //var txtDienThoai = report.Report.FindObject("txtDienThoai") as TextObject;
            //txtDienThoai.Text = mConst.CongTyEmail;
            //set data report
            FastReport.Data.JsonConnectionStringBuilder con = new FastReport.Data.JsonConnectionStringBuilder();
            con.Json = repotData;
            report.Report.Dictionary.Connections[0].ConnectionString = con.ToString();
            report.Preview = previewControl2;
            report.Show();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            string fileName = @"D:\DangHung\PhuongNam\baocao.pdf";
            //axAcroPDF1.LoadFile(fileName);

        }

        private void label6_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\DangHung\PhuongNam\baocao.pdf";
           // axAcroPDF1.LoadFile(fileName);
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            string fileName = @"D:\DangHung\PhuongNam\baocao.pdf";
           // axAcroPDF1.LoadFile(fileName);

        }

        private void frmReportViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            report.Dispose();
            GC.Collect();
        }

        private void frmReportViewer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                report.Print();
                this.Close();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
