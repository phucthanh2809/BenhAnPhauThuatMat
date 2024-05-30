using PN_EMR.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PN_EMR
{
    public partial class FrmMain_V2 : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public static FrmMain_V2 _Main;

        public Frm_PhieuNhap fNhapThuoc;
        public Form_Alert fAlert;

        public FrmMain_V2()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            _Main = this;

        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 20;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 20;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        public void fLoadFrom<Miform>(int flagForm) where Miform : Form, new()
        {
            Form Formchil;
            Formchil = panelControls.Controls.OfType<Miform>().FirstOrDefault();
            if (Formchil == null)
            {
                if (flagForm == 0)
                {
                    Formchil = new Miform();
                    Formchil.TopLevel = false;
                    Formchil.FormBorderStyle = FormBorderStyle.None;
                    Formchil.Dock = DockStyle.Fill;
                    panelControls.Controls.Add(Formchil);
                    panelControls.Tag = Formchil;
                    Formchil.Show();
                    Formchil.BringToFront();
                    //Formchil.FormClosed += new FormClosedEventHandler(CloseForms);
                }
                else
                {
                    Formchil = new Miform();
                    Formchil.ShowDialog();
                }
            }
            else
            {
                Formchil.BringToFront();
            }
        }

        public void fShowNhapThuoc()
        {
            if (fNhapThuoc != null)
                fNhapThuoc.Dispose();
            fNhapThuoc = new Frm_PhieuNhap();
            fNhapThuoc.TopLevel = false;
            panelControls.Controls.Add(fNhapThuoc);
            fNhapThuoc.BringToFront();
            fNhapThuoc.Dock = DockStyle.Fill;
            fNhapThuoc.Show();
        }      

        public void fShowAlert(string msg, Form_Alert.enmType type)
        {
            //if (fAlert != null)
            //    fAlert.Dispose();
            fAlert = new Form_Alert();
            fAlert.showAlert(msg, type);
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
            FrmMain_V2._Main.fShowAlert("Màn Hình Tổng Quan", Form_Alert.enmType.Info);
        }

        private void btnNhapThuoc_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhapThuoc);            
            fLoadFrom<Frm_DanhSachPhieuNhap>(0);
            FrmMain_V2._Main.fShowAlert("Nhập Thuốc", Form_Alert.enmType.Success);
        }


        

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_V2_Load(object sender, EventArgs e)
        {
            //using (Frm_Login_V2 fd = new Frm_Login_V2())
            //{
            //    fd.ShowDialog();
            //}
        
            try
            {
               Frm_Login_V2 login = new Frm_Login_V2();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    timerTime.Start();
                    PanelWidth = panelLeft.Width;
                    isCollapsed = false;
                    UC_Home uch = new UC_Home();
                    AddControlsToPanel(uch);
                }
                login.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnXuatThuoc_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnXuatThuoc);
            fLoadFrom<Frm_PhieuXuatBan>(0);
            FrmMain_V2._Main.fShowAlert("Xuất Thuốc", Form_Alert.enmType.Success);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpense);
            fLoadFrom<Frm_PhieuDatHang>(0);
            FrmMain_V2._Main.fShowAlert("Phiếu yêu cầu ", Form_Alert.enmType.Success);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            UC_Dashboard_Xuat uch = new UC_Dashboard_Xuat();
            AddControlsToPanel(uch);
            FrmMain_V2._Main.fShowAlert("Màn Hình Xuất thuốc", Form_Alert.enmType.Info);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {            
            //FrmMain_V2._Main.fShowAlert("Đăng nhập sử dụng chương trình ", Form_Alert.enmType.Success);
            FrmMain_V2_Load(null, null);
        }

        private void btGiayNhapVien_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGiayNhapVien f = new FrmGiayNhapVien();
                if (f.ShowDialog() == DialogResult.OK)                
                f.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }
    }
}
