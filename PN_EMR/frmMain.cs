using hdataLibrary;
using hultiLibrary;
using System;
using System.Windows.Forms;
using System.Drawing;
using FastReport.Utils;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Runtime.InteropServices;
using System.Linq;
using System.Net.Sockets;

namespace PN_EMR
{
    public partial class frmMain : Form
    {
        public static readonly string xApplicationFolder = Config.ApplicationFolder;
        public static readonly string xPathConfigs = Config.ApplicationFolder + @"Configs\";
        //string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static string xKhoaPhong_Tat = "";
        public static hdataLib xdataulti = null;
        public static hsqlDataLib xdatasql = null;
        //public static hFinanceLib xfinLib = null;
        //public static readonly hTCBV_Service 
        public static readonly hLibrary xLib = new hLibrary();
        public static string xLoginID = "";
        public static string xLoginID_BenhNhan = "";
        public static string xLoginID_EMR = "";
        public static string xLoginID_KhamBenh = "";

        public static string xHashCode = "";
        public static string xApplicationName = "PN_EMR";
        public static string xTokenLogin = "";
        public static string xNgay;

        public static string xMaDangNhap = "";
        public static string xHoTenDangNhap = "";

        public static double xThoiGianChoTB = 0;
        public static double xThoiGianChoCB = 0;
        public static double xThoiGianChoCC = 0;


        private readonly string mDatabase = "pn_ris"; //mdatabasename =pn_fis_178
        private readonly string mDbSql_BenhNhan = "benhnhan";
        private string mUserName = "wsusername";
        private string mPassWord = "wspassword";
        public bool xCloseTiepNhanCoLuu = false;
        private string _queryBuilder = "";

        public static frmMain mMain;
        
        //public FrmTiepNhan fTiepNhan;
        //public frmDieuPhoi fDieuPhoi;
        //public frmKetQua fKetQua;
        //public FrmKyThuatVien fKyThuatVien;
        //public Frm_FilterDieuPhoi fFilterDieuPhoi;

        public static double xGetChiDinhTuHIS = 0;
        public static double xGetHienThiMayHocKetQua = 0;
        public static double xGetCauHinhTheoNhomLoaiPhieu = 0;

        public static bool xGetKyThuatvien = false;
        public static bool xGetDuyetKetQua = false;
        public static bool xGetDocKetQua = false;
        public static bool xGetTiepNhan = false;
        public static bool xGetXemBaoCao = false;
        public static bool xGetThayDoiKetQua = false;
        public static double xGetAdminsystem = 0;

        public static int xWorkList_port = 0;
        public static string xWorkList_hl7message = "";
        public static string xWorkList_server = "";
        

        int lx, ly;
        int sw, sh;


        public frmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            mMain = this;
            label3.Text = DateTime.Now.ToString();           
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void fLoadFrom<Miform>(int flagForm) where Miform : Form, new()
        {
            //Form Formchil;
            //Formchil = panelForm.Controls.OfType<Miform>().FirstOrDefault();
            //if (Formchil == null)
            //{
            //    if (flagForm == 0)
            //    {
            //        Formchil = new Miform();
            //        Formchil.TopLevel = false;
            //        Formchil.FormBorderStyle = FormBorderStyle.None;
            //        Formchil.Dock = DockStyle.Fill;
            //        panelForm.Controls.Add(Formchil);
            //        panelForm.Tag = Formchil;
            //        Formchil.Show();
            //        Formchil.BringToFront();
            //        //Formchil.FormClosed += new FormClosedEventHandler(CloseForms);
            //    }
            //    else
            //    {
            //        Formchil = new Miform();                    
            //        Formchil.ShowDialog();
            //    }    
            //}
            //else
            //{
            //    Formchil.BringToFront();
            //}
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms["FrmTiepNhan"] == null)
            //{
            //    btTiepNhan.BackColor = Color.FromArgb(4, 41, 68);
            //}
            //if (Application.OpenForms["FrmKeToa"] == null)
            //{
            //    btketoa.BackColor = Color.FromArgb(4, 41, 68);
            //}            
        }

        //public void fShowKyThuatVienGhiChu(double rowidchitiet, double tiepnhan_id)
        //{
        //    if (fKyThuatVien != null)
        //        fKyThuatVien.Dispose();
        //    fKyThuatVien = new FrmKyThuatVien(rowidchitiet, tiepnhan_id);            
        //    fKyThuatVien.ShowDialog();           
        //}

        //public void fShowTiepNhan()
        //{
        //    if (fTiepNhan != null)
        //        fTiepNhan.Dispose();
        //    fTiepNhan = new FrmTiepNhan();
        //    fTiepNhan.TopLevel = false;
        //    panelForm.Controls.Add(fTiepNhan);
        //    fTiepNhan.BringToFront();
        //    fTiepNhan.Dock = DockStyle.Fill;
        //    fTiepNhan.Show();
        //}

      

        //public void fShowKetQua(double rowidchitiet, double tiepnhan_id, double ketqua_id)
        //{
        //    if (fKetQua != null)
        //        fKetQua.Dispose();
        //    fKetQua = new frmKetQua(rowidchitiet, tiepnhan_id, ketqua_id);
        //    fKetQua.TopLevel = false;
        //    panelForm.Controls.Add(fKetQua);
        //    fKetQua.Dock = DockStyle.Fill;
        //    fKetQua.BringToFront();
        //    fKetQua.Show();
        //}

      
        private void hButton9_Click(object sender, EventArgs e)
        {
            frmMain_Load(null, null);
            //FrmHoSoNhapVien frm = new FrmHoSoNhapVien();
            //frm.TopLevel = false;
            //tabPage4.Controls.Add(frm);
            //frm.Dock = DockStyle.Fill;
            //frm.Show();
            //lblTieude.Text = "Lập hồ sơ nhập viện - Nội trú";
            //tabMain.SelectedTab = tabPage4;
        }

        private void hButton8_Click(object sender, EventArgs e)
        {
            //frmMS_TaoHoSo.OnProcessing += new frmMS_TaoHoSo.OnProcessHandler(Show_frmMS_PhatHanhVanBan);
            //frmMS_TaoHoSo frm = new frmMS_TaoHoSo();
            //frm.TopLevel = false;
            //tabPage1.Text = "Mở hồ sơ";
            //tabPage1.Controls.Add(frm);
            //frm.Size = tabPage1.Size;
            ////frm.Dock = DockStyle.Fill;
            //frm.Show();
            //tabMain.SelectedTab = tabPage1;
            //tabMain.Refresh();

        }

        private void ftooltip()
        {
            toolTip1.SetToolTip(hbt_Main, "Màn hình điều phối");
            toolTip1.SetToolTip(hbt_baocao, "Thống kê");
            toolTip1.SetToolTip(hbtDanhSach, "Đăng ký và phân quyền người dùng");
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //try
            //{
            //    xHashCode = hSecureLib.hgetTokenCode();
            //    frmLogin login = new frmLogin(mDatabase, mUserName, mPassWord);
            //    if(login.ShowDialog() == DialogResult.OK)
            //    {
            //        JObject jObLoginInFo = login.xjObjLoginInFo;
            //        xTokenLogin = jObLoginInFo["Token"].ToString();
            //        xKhoaPhong_Tat = jObLoginInFo["khoaphong_tat"].ToString();
            //        xMaDangNhap = login.txtUserName.Text;
            //        xHoTenDangNhap = login.txtHoTenNguoiDung.Text;
            //    }    
            //    login.Dispose();
                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());                
            //}
            //this.Cursor = Cursors.Default;
        }

        private void CloseOpenForms()
        {
            // Close all open forms - except for the main form.  (This is usually OpenForms[0].
            // Closing a form decrmements the OpenForms count
            while (Application.OpenForms.Count > 1)
            {
                Application.OpenForms[Application.OpenForms.Count - 1].Close();
            }
        }

        //event show form
        private void Show_frmMS_PhatHanhVanBan(string frmName, JObject jObjectDataColection)
        {
            if (frmName == "frmMS_PhatHanhVanBan")
            {
                //frmMS_PhatHanhVanBan frm = new frmMS_PhatHanhVanBan(jObjectDataColection);
                //frm.TopLevel = false;
                //tabPage3.Text = "Tạo lập văn bản";
                //tabPage3.Controls.Add(frm);
                //frm.Dock = DockStyle.Fill;
                //frm.Show();
                //tabMain.SelectedTab = tabPage3;
            }

            if (frmName == "frmMS_BoSungThongTin")
            {

                //frmMS_BoSungThongTin frm = new frmMS_BoSungThongTin(jObjectDataColection);
                //frm.TopLevel = false;
                //tabPage2.Text = "Nhập thêm thông tin";
                //tabPage2.Controls.Add(frm);
                //frm.Dock = DockStyle.Fill;
                //frm.Show();
                //tabMain.SelectedTab = tabPage2;
            }
        }

        private void btChiPhi_Click(object sender, EventArgs e)
        {

        }
      
        private void hButton6_Click(object sender, EventArgs e)
        {

            
        }

        private void hbt_Main_Click(object sender, EventArgs e)
        {
            //fLoadFrom<FrmThongTinHienThi>(0);


            //hbt_Main.BackColor = Color.FromArgb(12, 61, 92);

            frmBenhAnMat2 Formchil = new frmBenhAnMat2();
            Formchil.TopLevel = false;
            Formchil.FormBorderStyle = FormBorderStyle.None;
            Formchil.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(Formchil);
            tabControl1.Tag = Formchil;
            Formchil.Show();
            Formchil.BringToFront();

        }

        private void hButton5_Click(object sender, EventArgs e)
        {

        }

        private void hbt_TraKetQua_Click(object sender, EventArgs e)
        {
            
        }

        private void hbt_NhapKetQua_Click(object sender, EventArgs e)
        {
           // frmMain.mMain.fShowTiepNhan();
            //frmMain.mMain.fTiepNhan.hbt_Thoat.Click += Hbt_Thoat_Click;
        }

        private void hBt_KyThuatVien_Click(object sender, EventArgs e)
        {
            
        }

        private void hbt_baocao_Click(object sender, EventArgs e)
        {
           // fLoadFrom<FrmThongKe>(0);           
        }

         
        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void btmax_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;
            btmax.Visible = false;
            btrestart.Visible = true;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void paneltop_MouseMove(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void hbt_nguoidung_Click(object sender, EventArgs e)
        {
            //fLoadFrom<FrmDangKyNguoiDung>(1);
        }

        private void hbt_dangnhap_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            frmMain_Load(null, null);
        }

        private void hbtDanhSach_Click(object sender, EventArgs e)
        {
            if (xGetAdminsystem == 1)
            {
                //fLoadFrom<FrmTaoNguoiDungVaPhanQuyen>(0);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hệ thống", "Thông báo");
                return;
            }
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btrestart_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);
            btmax.Visible = true;
            btrestart.Visible = false;
        }

    } //class
} //spacename
