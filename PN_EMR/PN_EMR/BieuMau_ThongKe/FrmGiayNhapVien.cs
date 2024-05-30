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
using hdataLibrary;

namespace PN_EMR
{
    public partial class FrmGiayNhapVien : Form
    {
        private string _queryBuilder = "";
        // private static readonly hdataLib _hdataulti = FrmMain.xdataulti;
        private static readonly hdataLib _hdataulti = FrmMain.xdataulti;
        private static readonly hLibrary _hlib = new hLibrary();
        private static readonly string _loginID = FrmMain.xLoginID;

        


        public bool mOK = false;
        private hLibrary hlib = new hLibrary();
        private bool misSendTab = true;
        public FrmGiayNhapVien()
        {
            InitializeComponent();
            
            fload_NgheNghiep();
            fload_QuocTich();
            fload_DanToc();
            fload_NoiLamViec();
            fload_KhoaPhong();
            fload_ChanDoan();
            fload_GioiTinh();

            cmbGioiTinh.SelectedIndex = 0;
            cmbQuocTich.SelectedIndex = 0;
            cmbDanToc.SelectedIndex = 0;

            cmbChanDoan.SelectedIndex = 0;
            cmbKhoaNhap.SelectedIndex = 0;
        }

        private void fload_NgheNghiep()
        {
            string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\tbl_nghenghiep.json");
            DataTable dt = hlib.hGetDataTable(jsondata);
            cmbNgheNghiep.DataSource = dt;
            cmbNgheNghiep.DisplayMember = "tennghenghiep";
            cmbNgheNghiep.ValueMember = "manghenghiep";
            ctsNgheNghiep.xComBoBox = cmbNgheNghiep;
            ctsNgheNghiep.xTimTrenField = "tentat";
            ctsNgheNghiep.xSetValueMember = "000";
        }

        private void fload_QuocTich()
        {
            string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\tbl_quoctich.json");
            DataTable dt = hlib.hGetDataTable(jsondata);
            cmbQuocTich.DataSource = dt;
            cmbQuocTich.DisplayMember = "tenquoctich";
            cmbQuocTich.ValueMember = "maquoctich";
            ctsQuocTich.xComBoBox = cmbQuocTich;
            ctsQuocTich.xTimTrenField = "tentat";
            ctsQuocTich.xSetValueMember = "001";
        }
        private void fload_DanToc()
        {
            string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\tbl_dantoc.json");
            DataTable dt = hlib.hGetDataTable(jsondata);
            cmbDanToc.DataSource = dt;
            cmbDanToc.DisplayMember = "tendantoc";
            cmbDanToc.ValueMember = "madantoc";
            ctsDanToc.xComBoBox = cmbDanToc;
            ctsDanToc.xTimTrenField = "tentat";
            ctsDanToc.xSetValueMember = "01";
        }
        private void fload_NoiLamViec()
        {
            string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\tbl_noilamviec.json");
            DataTable dt = hlib.hGetDataTable(jsondata);
            cmbNoiLV.DataSource = dt;
            cmbNoiLV.DisplayMember = "tennoilamviec";
            cmbNoiLV.ValueMember = "noilamviec_id";
            ctsNoiLV.xComBoBox = cmbNoiLV;
            ctsNoiLV.xTimTrenField = "tentat";
            ctsNoiLV.xSetValueMember = "1";
        }

        private void fload_KhoaPhong()
        {
            string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\tbl_khoaphong.json");
            DataTable dt = hlib.hGetDataTable(jsondata);
            cmbKhoaNhap.DataSource = dt;
            cmbKhoaNhap.DisplayMember = "tenkhoaphong";
            cmbKhoaNhap.ValueMember = "khoaphong_id";
            ctsMaKhoa.xComBoBox = cmbKhoaNhap;
            ctsMaKhoa.xTimTrenField = "tentat";
            ctsMaKhoa.xSetValueMember = "1";
        }

        private void fload_GioiTinh()
        {
            string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\tbl_gioitinh.json");
            DataTable dt = hlib.hGetDataTable(jsondata);
            cmbGioiTinh.DataSource = dt;
            cmbGioiTinh.DisplayMember = "tengioitinh";
            cmbGioiTinh.ValueMember = "gioitinh_id";
        }

        private void fload_ChanDoan()
        {
            string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\tbl_chandoan.json");
            DataTable dt = hlib.hGetDataTable(jsondata);
            cmbChanDoan.DataSource = dt;
            cmbChanDoan.DisplayMember = "tenchandoan";
            cmbChanDoan.ValueMember = "maicd";
            ctsMaICD.xComBoBox = cmbChanDoan;
            ctsMaICD.xTimTrenField = "maicd";
        }


        private void hbt_ThoatKetQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void btLuuKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                #region //insert file json
                //Dictionary<string, object> dic_Thongtinbenhnhan = hlib.hGetDicData(this, "Master");
                //string jsonData = JsonConvert.SerializeObject(dic_Thongtinbenhnhan, Formatting.Indented);

                //if (!File.Exists(FrmMain.xPathConfigs + @"\GiayNhapVien.json"))
                //{
                //    File.WriteAllText(FrmMain.xPathConfigs + @"\GiayNhapVien.json", jsonData);
                //}
                //else
                //{
                //    string jsondata_RIS = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"\GiayNhapVien.json");
                //    var array = JArray.Parse(jsondata_RIS);
                //    var itemToAdd = new JObject();
                //    foreach (KeyValuePair<string, object> kp in dic_Thongtinbenhnhan)
                //    {
                //        itemToAdd[kp.Key] = kp.Value.ToString();
                //    }
                //    array.Add(itemToAdd);

                //    var jsonToOutput = JsonConvert.SerializeObject(array, Formatting.Indented);
                //    File.WriteAllText(FrmMain.xPathConfigs + @"\GiayNhapVien.json", jsonToOutput);
                //}
                //MessageBox.Show("Tiếp nhận thành công");
                //mOK = true;
                #endregion
                //Chuổi số không trùng
                double oid_code_id = double.Parse(_hdataulti.hgetCodeTime_14(_loginID));
                Dictionary<string, object> dic_Thongtinbenhnhan = hlib.hGetDicData(this, "Master");
                dic_Thongtinbenhnhan.Add("oid_code", oid_code_id);

                //string jsonData = JsonConvert.SerializeObject(dic_Thongtinbenhnhan, Formatting.Indented);

                Dictionary<string, object> dicDuLieu = new Dictionary<string, object>();
                dicDuLieu.Add("giaynhapvien", dic_Thongtinbenhnhan);

                //key manhapvien
                double benhan_code = double.Parse(txtkey.Text);
                
                //Sử dụng khi lưu vào database
                Dictionary<string, hTbInfo> dicd_d_a0_giay_nhapvien = new Dictionary<string, hTbInfo>(); // đưa các trường dữ liệu, kiểu và giá trị bảng cần lưu
                dicd_d_a0_giay_nhapvien.Add("oid_code", new hTbInfo(hKieuDL.Numeric, oid_code_id, true, false, true));
                dicd_d_a0_giay_nhapvien.Add("noidung", new hTbInfo(hKieuDL.Json, dicDuLieu));
                dicd_d_a0_giay_nhapvien.Add("benhan_code", new hTbInfo(hKieuDL.Numeric, benhan_code, false, false, false));
                string jsonData = JsonConvert.SerializeObject(dicd_d_a0_giay_nhapvien, Formatting.Indented);
               
                try
                {
                    object obj = _hdataulti.hsaveData(_loginID, "d_a0_giay_nhapvien", jsonData);                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
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

        private void txtkey_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetPhieu(string MaXacDinh)
        {
            double _oid_code = 0;

            _queryBuilder = "SELECT * FROM public.d_a0_giay_nhapvien WHERE benhan_code = " + MaXacDinh;
            DataTable dt = _hdataulti.hgetDataTable(_loginID, _queryBuilder);
            string jsondata = "";
            JObject jobj = null;         
            if (dt.Rows.Count > 0)
            {
                _oid_code = Double.Parse(dt.Rows[0]["oid_code"].ToString());
                jsondata = dt.Rows[0]["noidung"].ToString();
                jobj = JObject.Parse(jsondata);
                string strPatient = jobj["giaynhapvien"].ToString();
                _hlib.hFillMasterData(this, strPatient, "Master");               
               
            }
            else
            {                
                    //txtHoTen.Text = "";
                    //txtMaNhapVien.Text = "";
                    //txtDiaChi.Text = "";
                    return;
                }
            }

        private void txtkey_Leave(object sender, EventArgs e)
        {
            GetPhieu(txtkey.Text.Trim());
        }
    
    }
}
