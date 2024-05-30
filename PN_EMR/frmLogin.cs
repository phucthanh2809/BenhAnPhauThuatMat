using hdataLibrary;
using hultiLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PN_EMR
{
   

    public partial class frmLogin : Form
    {
        private string _queryBuilder = "";
        //private static readonly hdataLib _hdataulti = frmMain.xdataulti;
        private static readonly hLibrary _hlib = new hLibrary();
        //private static readonly string _loginID = frmMain.xLoginID;

        Dictionary<string, object> dic = new Dictionary<string, object>();
        private string _Database, _UserNameAPI, _PassWordAPI;
        public JObject xjObjLoginInFo = new JObject();
        
        private void btSuDung_Click(object sender, EventArgs e)
        {
            Close();
        }

        public frmLogin(string Database, string UserNameAPI, string PassWordAPI)
        {
            InitializeComponent();
            _Database = Database;
            _UserNameAPI = UserNameAPI;
            _PassWordAPI = PassWordAPI;
            txtNgayLamViec.Text = DateTime.Now.ToShortDateString();            
            lblCaption.Text = "Xin chào";
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void P_dangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            //frmMain.ReleaseCapture();
            //frmMain.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmThayDoiMatKhau fDoiMatKhau = new FrmThayDoiMatKhau(txtUserName.Text,txtHoTenNguoiDung.Text);
            fDoiMatKhau.ShowDialog();
        }

        private void P_dangnhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            
        }       

        private void btLogin_Click(object sender, EventArgs e)
        {
            //bool loginMachine = true;
            //Cursor = Cursors.WaitCursor;
            //try
            //{
            //    frmMain.xdataulti = new hdataLib(hConstants.PN_CORE_SERVICE_KEYNAME);
            //    frmMain.xdatasql = new hsqlDataLib(hConstants.PN_SQL_SERVICE_KEYNAME);
            //    //frmMain.xfinLib = new hFinanceLib(hFinanceConstants.PN_FINANCE_SERVICE_KEYNAME);
            //    string mhashCode = frmMain.xHashCode;
            //    frmMain.xLoginID = frmMain.xdataulti.hloginService(mhashCode, _Database, _UserNameAPI, _PassWordAPI);
            //    //frmMain.xLoginID_BenhNhan = frmMain.xdatasql.hloginService(mhashCode, "benhnhan", _UserNameAPI, _PassWordAPI);
            //    //frmMain.xLoginID_EMR = frmMain.xdataulti.hloginService(mhashCode, "nd1_emr2", _UserNameAPI, _PassWordAPI);
            //    //frmMain.xLoginID_KhamBenh = frmMain.xdatasql.hloginService(mhashCode, "kvs_khambenh", _UserNameAPI, _PassWordAPI);
                
            //    frmMain.xNgay = txtNgayLamViec.Text;
            //    Application.DoEvents();
            //}
            //catch (Exception ex)
            //{
            //    loginMachine = false;
            //    MessageBox.Show(ex.ToString());
            //}
            //if (loginMachine) //login bằng hashcode của máy
            //{
            //    //login lớp username và password người dung
            //    var result = frmMain.xdataulti.hloginApplication(frmMain.xLoginID, txtUserName.Text, txtPassword.Text, frmMain.xApplicationName);
            //    if (result != "")
            //    {
            //        JObject jObj = JObject.Parse(result);
            //        int re = int.Parse(jObj["ResultCode"].ToString());
            //        string mess = jObj["Message"].ToString();
            //        JObject jNhanVien = JObject.Parse(jObj["NhanVien"].ToString());
            //        if (re >= 1)
            //        {
            //            string tokenLogin = jObj["Token"].ToString();
            //            //txtToken.Text = tokenLogin;
            //            dic.Add("hoten", jNhanVien["hoten"]);
            //            dic.Add("chucvu", jNhanVien["chucvu"]);
            //            dic.Add("khoaphong", jNhanVien["khoaphong"]);
            //            dic.Add("khoaphong_tat", jNhanVien["khoaphong_tat"]);
            //            dic.Add("Token", tokenLogin);
            //            string json = JsonConvert.SerializeObject(dic, Formatting.Indented);
            //            xjObjLoginInFo = JObject.Parse(json);
            //            btSuDung.Enabled = true;
            //            btLogin.Enabled = false;
            //            linkDoimatkhau.Enabled = true;
            //            txtHoTenNguoiDung.Text = jNhanVien["hoten"].ToString();
            //        }
            //        else
            //        {
            //            //txtToken.Text = mess;
            //            btSuDung.Enabled = false;
            //        }
            //    }
            //}
            //Cursor = Cursors.Default;
        }
    }
}
