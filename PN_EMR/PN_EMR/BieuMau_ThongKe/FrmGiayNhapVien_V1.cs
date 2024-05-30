using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hultiLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PN_EMR
{
    public partial class FrmGiayNhapVien_V1 : Form
    {
        private string _queryBuilder = "";
       // private static readonly hdataLib _hdataulti = FrmMain.xdataulti;
        private static readonly hLibrary _hlib = new hLibrary();
        private static readonly string _loginID = FrmMain.xLoginID;
        public bool mOK = false;
        private hLibrary hlib = new hLibrary();
        private bool misSendTab = true;
        public FrmGiayNhapVien_V1()
        {
            InitializeComponent();
            cmbGioiTinh.SelectedIndex = 0;
            //cmbQuocTich.SelectedIndex = 0;
            //cmbDanToc.SelectedIndex = 0;
            //cmbNgheNghiep.SelectedIndex = 0;
            //cmbChanDoan.SelectedIndex = 0;
            //cmbKhoaNhap.SelectedIndex = 0;
        }

        private void hbt_ThoatKetQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuuKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> dic_Thongtinbenhnhan = hlib.hGetDicData(this, "Master");
                string jsonData = JsonConvert.SerializeObject(dic_Thongtinbenhnhan, Formatting.Indented);
                if (!File.Exists(FrmMain.xPathConfigs + @"\Benhnhan_RIS.json"))
                {
                    File.WriteAllText(FrmMain.xPathConfigs + @"\Benhnhan_RIS.json", jsonData);
                }
                else
                {
                    string jsondata_RIS = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\Benhnhan_RIS.json");
                    var array = JArray.Parse(jsondata_RIS);
                    var itemToAdd = new JObject();
                    foreach (KeyValuePair<string, object> kp in dic_Thongtinbenhnhan)
                    {
                        itemToAdd[kp.Key] = kp.Value.ToString();
                    }
                    array.Add(itemToAdd);

                    var jsonToOutput = JsonConvert.SerializeObject(array, Formatting.Indented);
                    File.WriteAllText(FrmMain.xPathConfigs + @"\Benhnhan_RIS.json", jsonToOutput);
                }
                MessageBox.Show("Tiếp nhận thành công");
                mOK = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tiếp nhận lỗi : " + ex.ToString());
            }
        }

        private void FrmGiayNhapVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
            if (misSendTab)
                misSendTab = false;
        }
    }
}
