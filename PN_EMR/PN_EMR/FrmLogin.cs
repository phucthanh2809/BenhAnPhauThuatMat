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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PN_EMR
{
    public partial class FrmLogin : Form
    {
        private string _queryBuilder = "";
        private static readonly hLibrary _hlib = new hLibrary();

        Dictionary<string, object> dic_login = new Dictionary<string, object>();
        private string _Database, _UserNameAPI, _PassWordAPI;
        public JObject xjObjLoginInFo = new JObject();

        public FrmLogin(string Database, string UserNameAPI, string PassWordAPI)
        {
            InitializeComponent();
            _Database = Database;
            _UserNameAPI = UserNameAPI;
            _PassWordAPI = PassWordAPI;
            txtNgayLamViec.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            bool loginMachine = true;
            Cursor = Cursors.WaitCursor;
            try
            {
                FrmMain.xdataulti = new hdataLib(hConstants.PN_CORE_SERVICE_KEYNAME);
                FrmMain.xdatasql = new hsqlDataLib(hConstants.PN_SQL_SERVICE_KEYNAME);

                string mhashCode = FrmMain.xHashCode;
                FrmMain.xLoginID = FrmMain.xdataulti.hloginService(mhashCode, _Database, _UserNameAPI, _PassWordAPI);
                FrmMain.xLoginID_Master_index = FrmMain.xdataulti.hloginService(mhashCode, "pn_master_index", _UserNameAPI, _PassWordAPI);
                //FrmMain.xLoginID_BenhNhan = FrmMain.xdatasql.hloginService(mhashCode, "benhnhan", _UserNameAPI, _PassWordAPI);
                //FrmMain.xLoginID_EMR = FrmMain.xdataulti.hloginService(mhashCode, "nd1_emr2", _UserNameAPI, _PassWordAPI);
                //FrmMain.xLoginID_KhamBenh = FrmMain.xdatasql.hloginService(mhashCode, "kvs_khambenh", _UserNameAPI, _PassWordAPI);

                FrmMain.xNgay = txtNgayLamViec.Text;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                loginMachine = false;
                MessageBox.Show(ex.ToString());
            }
            if (loginMachine) //login bằng hashcode của máy
            {
                if (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
                {
                    //login lớp username và password người dung
                    try
                    {
                        var result = FrmMain.xdataulti.hloginApplication(FrmMain.xLoginID, txtUserName.Text, txtPassword.Text, FrmMain.xApplicationName);
                        if (result != "")
                        {
                            JObject jObj = JObject.Parse(result);
                            int lResultCode = int.Parse(jObj["ResultCode"].ToString());
                            string mess = jObj["Message"].ToString();
                            JObject jNhanVien = JObject.Parse(jObj["NhanVien"].ToString());
                            if (lResultCode >= 1)
                            {
                                string tokenLogin = jObj["Token"].ToString();
                                //txtToken.Text = tokenLogin;
                                dic_login.Add("hoten", jNhanVien["hoten"]);
                                dic_login.Add("chucvu", jNhanVien["chucvu"]);
                                dic_login.Add("khoaphong", jNhanVien["khoaphong"]);
                                dic_login.Add("khoaphong_tat", jNhanVien["khoaphong_tat"]);
                                dic_login.Add("Token", tokenLogin);
                                string json = JsonConvert.SerializeObject(dic_login, Formatting.Indented);
                                xjObjLoginInFo = JObject.Parse(json);
                                txtNgayLamViec.ReadOnly = true;
                                //linkDoimatkhau.Enabled = true;
                                FrmMain.xHoTenDangNhap = jNhanVien["hoten"].ToString();
                            }
                            else
                            {
                                //txtToken.Text = mess;
                                txtNgayLamViec.ReadOnly = false;
                                //btSuDung.Enabled = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        loginMachine = false;
                        //MessageBox.Show(ex.ToString());
                        FrmMain._Main.fShowAlert("Đăng nhập không thành công \n"+ex.Message, Form_Alert.enmType.Warning);
                        txtPassword.Text = "";
                        txtUserName.Focus();
                        txtUserName.SelectAll();
                    }
                }
                else
                {
                    FrmMain._Main.fShowAlert("Đăng nhập không thành công \nkiểm tra lại tên đăng nhập và mật khẩu ", Form_Alert.enmType.Warning);
                    return;
                }    
            }
            Cursor = Cursors.Default;

            //if (txtUserName.Text.Length == 0)
            //{
            //    FrmMain._Main.fShowAlert("Đăng nhập không thành công", Form_Alert.enmType.Warning);
            //    return;
            //}
            //else
            //{
                this.Close();
                FrmMain._Main.fShowAlert("Đăng nhập thành công", Form_Alert.enmType.Success);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
