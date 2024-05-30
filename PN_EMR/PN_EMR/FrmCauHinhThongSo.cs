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
using System.Drawing.Printing;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PN_EMR
{
    public partial class FrmCauHinhThongSo : Form
    {
        private string _queryBuilder = "";
        private static readonly hdataLib _hdataulti = FrmMain.xdataulti;
        private static readonly hLibrary _hlib = new hLibrary();
        private static readonly string _loginID = FrmMain.xLoginID;

        public FrmCauHinhThongSo()
        {
            InitializeComponent();
            PopulateInstalledPrintersCombo();
            fload_DanhMucKhu_DMC();
            
            string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs+ @"Config.json");
            JObject jobj = JObject.Parse(jsondata);
            string strPrint = jobj["cauhinhmayin"].ToString();
            JObject joPrint = JObject.Parse(strPrint);

            string strkhuvuc = jobj["cauhinhkhuvuc"].ToString();
            JObject joKhuvuc = JObject.Parse(strkhuvuc);

            string lPrintNhan = joPrint["mayinnhan"].ToString();
            string lPrintSoThuTu = joPrint["mayinsothutu"].ToString();
            string lMaKhuVuc = joKhuvuc["makhuvuc"].ToString();
            fLoad_PrintNhan(lPrintNhan);
            fLoad_PrintSoThuTu(lPrintSoThuTu);
            if (lMaKhuVuc != null)
            {
                cbokhuvuc.SelectedValue = lMaKhuVuc;
            }
            fload_DanhMucPhongKham_DMC(cbokhuvuc.SelectedValue.ToString());
        }

        private void PopulateInstalledPrintersCombo()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                hcboMayInTemNhan.Items.Add(pkInstalledPrinters);
                hcboInSoThuTu.Items.Add(pkInstalledPrinters);
            }
        }

        private DataTable fload_Danhmucchung(string tenbang)
        {
            _queryBuilder = "select danhmucchung from l_danhmucchung where tenbang = '" + tenbang + "'";
            object GiaTri = _hdataulti.hgetObject(_loginID, _queryBuilder);
            DataTable dt = hJsonLib.hConvertDataTable(GiaTri.ToString());
            return dt;
        }

        private void fload_DanhMucKhu_DMC()
        {
            DataTable dt = fload_Danhmucchung("l_khuvuc");
            cbokhuvuc.DataSource = dt;
            cbokhuvuc.DisplayMember = "tenkhuvuc";
            cbokhuvuc.ValueMember = "makhuvuc";
        }

        private void fload_DanhMucPhongKham_DMC(string makhuvuc)
        {
            DataTable dt = fload_Danhmucchung("l_phongkhammacdinh").Select("makhuvuc = '" + makhuvuc.ToString() + "'").CopyToDataTable();
            cboPhongKham.DataSource = dt;
            cboPhongKham.DisplayMember = "tenphongkham";
            cboPhongKham.ValueMember = "maphongkham";
        }

        private void fLoad_PrintNhan(string PrintName)
        {
            try
            {
                hcboMayInTemNhan.Text = PrintName;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void fLoad_PrintSoThuTu(string PrintName)
        {
            try
            {
                hcboInSoThuTu.Text = PrintName;
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hbt_LuuKetQua_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dic_ThongtinCauHinh = _hlib.hGetDicData(this, "Master");
            Dictionary<string, object> dic_ThongtinCauHinh_1 = _hlib.hGetDicData(this, "Master2");

            Dictionary<string, object> dicDuLieu = new Dictionary<string, object>();
            dicDuLieu.Add("cauhinhmayin", dic_ThongtinCauHinh);
            dicDuLieu.Add("cauhinhkhuvuc", dic_ThongtinCauHinh_1);

            string jsonData = JsonConvert.SerializeObject(dicDuLieu, Formatting.Indented);
            System.IO.File.WriteAllText(FrmMain.xPathConfigs + @"Config.json", jsonData);
            MessageBox.Show("Cấu hình thành công");
        }

        private void hbt_ThoatKetQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbokhuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbokhuvuc.SelectedValue == null) || (cbokhuvuc.SelectedValue.ToString().Equals("System.Data.DataRowView"))) return;
            fload_DanhMucPhongKham_DMC(cbokhuvuc.SelectedValue.ToString());
        }
    }
}
