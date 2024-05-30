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
using hdataLibrary;
using hultiLibrary;
using FastReport.Utils;
using Newtonsoft.Json.Linq;

namespace PN_EMR
{
    public partial class FrmMain : Form
    {
        int PanelWidth;
        bool isCollapsed;


        public static readonly string xApplicationFolder = Config.ApplicationFolder;
        public static readonly string xPathConfigs = Config.ApplicationFolder + @"Configs\";
        public static string xKhoaPhong_Tat = "";
        public static hdataLib xdataulti = null;
        public static hsqlDataLib xdatasql = null;
 
        public static readonly hLibrary xLib = new hLibrary();
        public static string xLoginID = "";
        public static string xLoginID_Master_index = "";

        public static string xHashCode = "";
        public static string xApplicationName = "PN_EMR";
        public static string xTokenLogin = "";
        public static string xNgay;

        public static string xMaDangNhap = "";
        public static string xHoTenDangNhap = "";

        private readonly string mDatabase = "pn_emr_minhanh"; //mdatabasename =pn_fis_178
        private readonly string mDatabase_master_index = "pn_master_index";

        private readonly string mDbSql_BenhNhan = "benhnhan";
        private string mUserName = "wsusername";
        private string mPassWord = "wspassword";
        public bool xCloseTiepNhanCoLuu = false;
        private string _queryBuilder = "";

        public static double xGetPayTuHIS = 0;
        public static double xGetAdminHandInput = 0;
        public static double xGetQROnline = 0;
        public static double xGetCauHinhTheoNhomLoaiPhieu = 0;
        public static double xGetCauHinhTienKhamBenh = 0;
        public static double xGetLoginQR = 0;
        public static double xGetTimeWaiting = 0;


        public static double xGetAdminsystem = 0;

        int lx, ly;
        int sw, sh;



        public static FrmMain _Main;

        public Frm_PhieuNhap fNhapThuoc;
        public Form_Alert fAlert;

        public FrmMain()
        {
            InitializeComponent();            
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
            FrmMain._Main.fShowAlert("Màn Hình Tổng Quan", Form_Alert.enmType.Info);
        }

        private void btnNhapThuoc_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhapThuoc);            
            fLoadFrom<Frm_DanhSachPhieuNhap>(0);
            FrmMain._Main.fShowAlert("Nhập Thuốc", Form_Alert.enmType.Success);
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
        
            
        }

        private void btnXuatThuoc_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnXuatThuoc);
            fLoadFrom<Frm_PhieuXuatBan>(0);
            FrmMain._Main.fShowAlert("Xuất Thuốc", Form_Alert.enmType.Success);
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
            FrmMain._Main.fShowAlert("Phiếu yêu cầu ", Form_Alert.enmType.Success);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                xHashCode = hSecureLib.hgetTokenCode();
                FrmLogin login = new FrmLogin(mDatabase, mUserName, mPassWord);
                if (login.ShowDialog() == DialogResult.OK)
                {
                    JObject jObLoginInFo = login.xjObjLoginInFo;
                    xTokenLogin = jObLoginInFo["Token"].ToString();
                    xKhoaPhong_Tat = jObLoginInFo["khoaphong_tat"].ToString();
                    xMaDangNhap = login.txtUserName.Text;
                    //xHoTenDangNhap = login.txtHoTenNguoiDung.Text;

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

        private void fLoadGiaTriPhanQuyen(string manguoidung)
        {
            _queryBuilder = "select * from l_sudungphanmem where manhanvien ='" + manguoidung + "'";
            DataTable ldt = xdataulti.hgetDataTable(xLoginID, _queryBuilder);
            if (ldt.Rows.Count > 0)
            {
                xGetAdminsystem = Convert.ToDouble(ldt.Rows[0]["adminsystem"].ToString());
                string jsondata = "";
                JObject jobj = null;
                jsondata = ldt.Rows[0]["quyensudung"].ToString();
                jobj = JObject.Parse(jsondata);
                string strPhanQuyen = jobj["phanquyen"].ToString();
                JObject joquyensudung = JObject.Parse(strPhanQuyen);
                //xGetDocKetQua = bool.Parse(joquyensudung["quyendocketqua"].ToString());
                //xGetTiepNhan = bool.Parse(joquyensudung["quyentiepnhan"].ToString());
                //xGetDuyetKetQua = bool.Parse(joquyensudung["quyenkyketqua"].ToString());
                //xGetKyThuatvien = bool.Parse(joquyensudung["quyenkythuatvien"].ToString());
                //xGetXemBaoCao = bool.Parse(joquyensudung["quyenxembaocao"].ToString());
                //xGetThayDoiKetQua = bool.Parse(joquyensudung["quyendieuchinhketqua"].ToString());
            }
        }



        private void ftooltip()
        {
            //toolTip1.SetToolTip(hbt_Main, "Màn hình Thanh toán QR");
            //toolTip1.SetToolTip(hbt_NhapThuoc, "Màn hình trả kết quả");
            //toolTip1.SetToolTip(hbtDanhSach, "Đăng ký và phân quyền người dùng");
        }

        private void fLoadGiaTriMacDinhCauHinh()
        {
            _queryBuilder = "select * from l_cauhinh";
            DataTable dt = xdataulti.hgetDataTable(xLoginID, _queryBuilder);
            if (dt.Rows.Count > 0)
            {
                //xGetPayTuHIS = Convert.ToDouble(dt.Select(" cauhinh_id = 5")[0]["giatri"]);
                //xGetAdminHandInput = Convert.ToDouble(dt.Select(" cauhinh_id = 6")[0]["giatri"]);
                //xGetQROnline = Convert.ToDouble(dt.Select(" cauhinh_id = 7")[0]["giatri"]);         
                //xGetCauHinhTienKhamBenh = Convert.ToDouble(dt.Select(" cauhinh_id = 8")[0]["giatri"]);
                //xGetLoginQR = Convert.ToDouble(dt.Select(" cauhinh_id = 9")[0]["giatri"]);
                //xGetTimeWaiting = Convert.ToDouble(dt.Select(" cauhinh_id = 10")[0]["giatri"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(button1);
            fLoadFrom<FrmGiayNhapVien>(0);
            FrmMain._Main.fShowAlert("Giấy nhập viện", Form_Alert.enmType.Success);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            UC_Dashboard_Xuat uch = new UC_Dashboard_Xuat();
            AddControlsToPanel(uch);
            FrmMain._Main.fShowAlert("Màn Hình Xuất thuốc", Form_Alert.enmType.Info);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {            
            FrmMain._Main.fShowAlert("Đăng nhập sử dụng chương trình ", Form_Alert.enmType.Success);
            FrmMain_Load(null, null);
        }
    }
}
