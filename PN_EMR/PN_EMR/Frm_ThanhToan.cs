//using CreateQr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using hdataLibrary;
using hultiLibrary;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using QRCoder;
using System.Net;
using System.IO;
using System.Globalization;

namespace PN_EMR
{
    public partial class Frm_ThanhToan : Form
    {
        public static HttpClient client = new HttpClient();
        private string _queryBuilder = "";
        private static readonly hdataLib _hdataulti = FrmMain.xdataulti;
        private static readonly hLibrary _hlib = new hLibrary();
        private static readonly string _loginID = FrmMain.xLoginID;

        private DateTime _Ngay = DateTime.Parse(FrmMain.xNgay);

        int counter = 0;
        int hienthanhcong = 0;
        private double _NgayServer = 0;
        private DataTable _dt_ThanhToan;
        private DataTable _dt_Confirm;
        private double _transactionId =0;
        private string _MaThanhToanQR = "";
        private string _VND = "VND";
        private string _EMPTY = "";
        Dichso dichso = new Dichso();
        // QrCodeEncodingOptions options;

        #region Thông số môi trường test
        /*
            Thông số môi trường test MINH ANH
            1 Master Merchant Code: 970489
            2. Merchant ID: 0305019661
            3. terminal ID: 	105870080445
            3. Tài khoản hạch toán môi trường test: 
            105870080445
            4. Branch ID: 12440
            5.x-ibm-client-secret : uS7pQ2cV4yQ4iK7mT2mF6jH0wU3kA7pQ0lX8mF7kX3jO7kC2wV
            6.x-ibm-client-id  : 9049dbd1-2f74-4df9-a0c6-4acb50bd3f01 
            -------------------------------
            Thông số môi trường test BV.Mat
            1 Master Merchant Code: 970489
            2. Merchant ID: 0301483745
            3. terminal ID: 104000769666
            3. Tài khoản hạch toán môi trường test: 104000769666
            4. Branch ID: 12898
            5
            X-IBM-client-secret
            X-IBM-client- ID
            ( các thông tin gửi trong ngày 26/07)
            Kèm code phần ký số
            6. Provider ID: 600
         */
        #endregion
        private string _masterMerCode = "970489";
        private string _merchantCode = "0301483745";//0301483745
        private string _merchantType = "01";
        private string _merchantName = "BENH VIEN MAT";
        private string _terminalId = "110601686686";//104000769666
        private string _ccy = "704";
        private string _payType = "01";
        private string _countryCode = "VN";
        private string _merchantCity = "HANOI";
        private string _terminalName = "BVMAT";
        private string _merchantCC = "94098"; //12898

        public Frm_ThanhToan()
        {
            InitializeComponent();
            comboBoxECC.SelectedIndex = 0;
            lblNgayThanhToan.Text = _Ngay.ToShortDateString();
            
            //options = new QrCodeEncodingOptions
            //{
            //    DisableECI = true,
            //    CharacterSet = "UTF-8",
            //    Width = 255,
            //    Height = 255,
            //};
            //var writer = new BarcodeWriter();
            //writer.Format = BarcodeFormat.QR_CODE;
            //writer.Options = options;
            fload_HandInPut();
            //if(FrmMain.xGetPayTuHIS == 0)
            //{
            //    bt_tracuuthongtin.Enabled = true;
            //}    
            //else
            //{
            //    bt_tracuuthongtin.Enabled = false;
            //}    
        }

       private void fload_HandInPut()
        {
            if (FrmMain.xGetAdminHandInput == 1)
            {
                txtHoTen.ReadOnly = false;
                txtMaBenhNhan.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                txtTienThanhToan.ReadOnly = false;
                txttienchu.ReadOnly = false;
                txtNoiDungThu.ReadOnly = false;
            }
            else
            {
                txtHoTen.ReadOnly = true;
                txtMaBenhNhan.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtTienThanhToan.ReadOnly = true;
                txttienchu.ReadOnly = true;
                txtNoiDungThu.ReadOnly = true;
            }
        }

        private void hbt_dangnhap_Click(object sender, EventArgs e)
        {
            if (FrmMain.xGetLoginQR != 0)
            {
                this.Close();
                this.Dispose();
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void hButton16_Click(object sender, EventArgs e)
        {
            
        }

        public string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                            "đ",
                                            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                                            "í","ì","ỉ","ĩ","ị",
                                            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                                            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                            "d",
                                            "e","e","e","e","e","e","e","e","e","e","e",
                                            "i","i","i","i","i",
                                            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                            "u","u","u","u","u","u","u","u","u","u","u",
                                            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void RenderQrCode(string DataSign)
        {
            string level = comboBoxECC.SelectedItem.ToString();
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(DataSign, eccLevel))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, Color.Black, Color.White, null, 0);
                this.pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
                //Set the SizeMode to center the image.
                this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
                //bool lOk = false;
            //lOk = true;
            //Int32 prob2 = Convert.ToInt32(117000);  //100000;
            //_MaThanhToanQR = "22101812455401";//lmathanhtoanQR.ToString();//"22101812455401";//
            //txtTienThanhToanQR.Text = prob2.ToString();//"0";//
            //counter = Convert.ToInt32(FrmMain.xGetTimeWaiting);
            //timer1.Start();
            //return;

            //Checktime server
            _queryBuilder = "select LOCALTIMESTAMP";
            object obj_Time = _hdataulti.hgetObject(_loginID, _queryBuilder);
            _NgayServer = _hlib.hConvertDate2yyyymmdd(obj_Time.ToString());
            if (_NgayServer != _hlib.hConvertDate2yyyymmdd(_Ngay.ToShortDateString()))
            {
                FrmThongBao f = new FrmThongBao();
                f.txtNoiDung.Text = "Ngày thanh toán khác ngày làm việc hiện tại\n"+ "Ngày hệ thống:"+ _NgayServer +" ;\n"+ "Ngày đăng nhập: "+ _hlib.hConvertDate2yyyymmdd(_Ngay.ToShortDateString());
                f.ShowDialog();
                return;
            }

            _MaThanhToanQR = "";
            
            if (txtMaBenhNhan.Text != "")
            {
                _queryBuilder = "SELECT * FROM public.qrpay_d_thanhtoan where Status = true "+
                    " And bvrequest @? '$.thanhtoan[*] ? (@.mabenhnhan == \"" + txtMaBenhNhan.Text.Trim() + "\" && @.ngaythanhtoan == "+ _hlib.hConvertDate2yyyymmdd(_Ngay.ToShortDateString()) +")'";
                DataTable dt = _hdataulti.hgetDataTable(_loginID, _queryBuilder);
                if (dt.Rows.Count > 0)
                {
                    FrmThongBao f = new FrmThongBao();
                    f.txtNoiDung.Text = "Bệnh nhân đã đăng ký khám trong ngày !!!";
                    f.ShowDialog();
                    fclear();
                    return;
                }
                else
                {
                    bool lOk = false;
                

                    DataTable ldt_thanhtoan = new DataTable();
                    if (txtTienThanhToan.Text == "") txtTienThanhToan.Text = "0";
                    double TienThanhToan = Convert.ToDouble(txtTienThanhToan.Text);

                    double lmathanhtoan = Double.Parse(_hdataulti.hgetCodeTime_14(_loginID));
                    Dictionary<string, object> dic_Thongtinthanhtoan = _hlib.hGetDicData(this, "Master");
                    dic_Thongtinthanhtoan.Add("ngaythanhtoan", _hlib.hConvertDate2yyyymmdd(_Ngay.ToShortDateString()));
                    dic_Thongtinthanhtoan.Add("mathanhtoan", lmathanhtoan);
                    Dictionary<string, object> dicDuLieu = new Dictionary<string, object>();
                    dicDuLieu.Add("thanhtoan", dic_Thongtinthanhtoan);

                    Dictionary<string, hTbInfo> dic_qrpay_d_thanhtoan = new Dictionary<string, hTbInfo>(); // đưa các trường dữ liệu, kiểu và giá trị bảng cần lưu
                    dic_qrpay_d_thanhtoan.Add("thanhtoan_id", new hTbInfo(hKieuDL.Numeric, 0, true, true, true));
                    dic_qrpay_d_thanhtoan.Add("bvrequest", new hTbInfo(hKieuDL.Json, dicDuLieu));
                    dic_qrpay_d_thanhtoan.Add("mathanhtoan", new hTbInfo(hKieuDL.Numeric, lmathanhtoan, false, false, true));
                    string jsonData = JsonConvert.SerializeObject(dic_qrpay_d_thanhtoan, Formatting.Indented);
                    try
                    {
                        object obj = _hdataulti.hsaveData(_loginID, "qrpay_d_thanhtoan", jsonData);
                        _queryBuilder = "SELECT * FROM public.qrpay_d_thanhtoan WHERE thanhtoan_id = " + obj;
                        ldt_thanhtoan = _hdataulti.hgetDataTable(_loginID, _queryBuilder);
                        lOk = true;
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                        lOk = false;
                    }
                    Int32 prob2 = Convert.ToInt32(TienThanhToan);  //100000;

                    if (lOk)
                    {
                        try
                        {
                            #region Thông tin tao QRcode
                            /*
                                { 
                                    "requestId": "20330", 
                                    "providerId":"123", 
                                    "merchantId": "MERCHANTĐỐI TÁC", 
                                    "merchantName": "ĐỐI TÁC Viet Nam", 
                                    "terminalId": "00011A", 
                                    "productId": "", 
                                    "orderId": "20330", 
                                    "amount": 2000000, 
                                    "payMethod": "QR", 
                                    "transactionDate": "20190218172254", 
                                    "currencyCode": "VND", 
                                    "remark": "U906030556", 
                                    "transTime":"20210524173034", 
                                    "channel":"MOBILE", 
                                    "version":"1.0", 
                                    "language":"vi",
                                    "signature":"" 
                                }

                            -------------------------
                            Thông số môi trường test
                            1 Master Merchant Code: 970489
                            2. Merchant ID: 0301483745
                            3. terminal ID: 104000769666
                            3. Tài khoản hạch toán môi trường test: 104000769666
                            4. Branch ID: 12898
                            5
                            X-IBM-client-secret
                            X-IBM-client- ID
                            ( các thông tin gửi trong ngày 26/07)
                            Kèm code phần ký số
                            6. Provider ID: 600
                            ---------------------------
                             {"requestId":"220727000002","providerId":"BVND","merchantId":"0600142774","merchantName":"BV DA KHOA TINH NAM DINH",
                            "terminalId":"104003792833","productId":"","orderId":"220727000002","amount":"100000","payMethod":"QR",
                            "transactionDate":"20220727083655","currencyCode":"VND","remark":"TT vien phi","channel":"MOBILE","clientIP":"",
                            "version":"1.0.1","language":"vi",
                            "signature":"eVVkF5GmVkCNTEiAtwPTbNXiJsNTWE5yPGwKLQWR6pzvKx1vrLqm94zk2Mo/HD504xnMwbHiil8qQ83Mq/ZX30Gx1PTFpMAZRt+XGLAAWFlX9nsDgpWgQp3ijrqXD+Z59y85zf68XsFCvVid4pLpgthkPDNQ014+Op/n4vLW11o/I5r//cJOKbGR0Wy8gcvWJCx5Em6U4kvZXderWIlsSXSPeiM1vQb+SJ2eBJqGJg5S1ybzmhspZev3HRV7wX2Du1RpHoaU0fil2qW02YFojvky0xuvi+f2UheHNPKMnbeA9SeBM2hKfzgi3TMw46zftNT+YIu1KUdhVIx/fyyrPA=="}

                             */
                            #endregion

                            double lmathanhtoanQR = 0;
                            if (ldt_thanhtoan.Rows.Count > 0)
                            {
                                lmathanhtoanQR = double.Parse(ldt_thanhtoan.Rows[0]["mathanhtoan"].ToString());
                            }
                            else
                            {
                                lmathanhtoanQR = 0;
                            }
                            if (FrmMain.xGetQROnline == 1)
                            {
                                Dictionary<string, object> dicDuLieuAPI = new Dictionary<string, object>();
                                dicDuLieuAPI.Add("requestId", "220727000002");
                                dicDuLieuAPI.Add("providerId", "BVND");
                                dicDuLieuAPI.Add("merchantId", "0600142774");
                                dicDuLieuAPI.Add("merchantName", "BV DA KHOA TINH NAM DINH");
                                dicDuLieuAPI.Add("terminalId", "104003792833");
                                dicDuLieuAPI.Add("productId", "");
                                dicDuLieuAPI.Add("orderId", "220727000002"); // truyền sau
                                dicDuLieuAPI.Add("amount", "100000"); // sotien
                                dicDuLieuAPI.Add("payMethod", "QR");
                                dicDuLieuAPI.Add("transactionDate", "20220727083655");
                                dicDuLieuAPI.Add("currencyCode", "VND");
                                dicDuLieuAPI.Add("remark", "TT vien phi"); // noi dung thu
                                dicDuLieuAPI.Add("channel", "MOBILE");
                                dicDuLieuAPI.Add("clientIP", "");
                                dicDuLieuAPI.Add("version", "1.0.1");
                                dicDuLieuAPI.Add("language", "vi");
                                dicDuLieuAPI.Add("signature", "eVVkF5GmVkCNTEiAtwPTbNXiJsNTWE5yPGwKLQWR6pzvKx1vrLqm94zk2Mo/HD504xnMwbHiil8qQ83Mq/ZX30Gx1PTFpMAZRt+XGLAAWFlX9nsDgpWgQp3ijrqXD+Z59y85zf68XsFCvVid4pLpgthkPDNQ014+Op/n4vLW11o/I5r//cJOKbGR0Wy8gcvWJCx5Em6U4kvZXderWIlsSXSPeiM1vQb+SJ2eBJqGJg5S1ybzmhspZev3HRV7wX2Du1RpHoaU0fil2qW02YFojvky0xuvi+f2UheHNPKMnbeA9SeBM2hKfzgi3TMw46zftNT+YIu1KUdhVIx/fyyrPA==");

                                string jsonData_wl = JsonConvert.SerializeObject(dicDuLieuAPI, Formatting.Indented);
                                string url = "https://api-uat.vietinbank.vn/vtb-api-uat/development/qrcode/utilities/qrGenerator";
                                var lgenerator_qrData = PostAsync("9049dbd1-2f74-4df9-a0c6-4acb50bd3f01", "uS7pQ2cV4yQ4iK7mT2mF6jH0wU3kA7pQ0lX8mF7kX3jO7kC2wV", url, jsonData_wl);
                                JObject jo_data = JObject.Parse(lgenerator_qrData.ToString());
                                string QrData = jo_data["qrData"].ToString();
                                RenderQrCode(QrData);
                            }
                            else
                            {
                                #region CreateQrCode OLD
                                //CreateQrCode obj = new CreateQrCode("970489", "0301483745", "01", "BV MAT TPHCM", "104000769666", "704", "VN", "HANOI", "KHOA KHAM BENH", "12898");
                                //string text = obj.create(txtMaBenhNhan.Text, prob2, "XV_" + RemoveUnicode(txtHoTen.Text));
                                //if (String.IsNullOrWhiteSpace(lblthoigian.Text) || String.IsNullOrEmpty(lblthoigian.Text))
                                //{
                                //    picQRThanhToan.Image = null;
                                //    MessageBox.Show("Text not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //}
                                //else
                                //{
                                //    var qr = new ZXing.BarcodeWriter();
                                //    qr.Options = options;
                                //    qr.Format = ZXing.BarcodeFormat.QR_CODE;
                                //    var result = new Bitmap(qr.Write(text.Trim()));
                                //    picQRThanhToan.Image = result;

                                //}
                                #endregion

                                Dictionary<string, object> dicDuLieuAPI_QrData = new Dictionary<string, object>();
                                dicDuLieuAPI_QrData.Add("masterMerCode", _masterMerCode);
                                dicDuLieuAPI_QrData.Add("merchantCode", _merchantCode);
                                dicDuLieuAPI_QrData.Add("merchantType", _merchantType);
                                dicDuLieuAPI_QrData.Add("merchantName", _merchantName);
                                dicDuLieuAPI_QrData.Add("terminalId", _terminalId);
                                dicDuLieuAPI_QrData.Add("productId", "");
                                dicDuLieuAPI_QrData.Add("ccy", _ccy);
                                dicDuLieuAPI_QrData.Add("desc", RemoveDiacritics(txtNoiDungThu.Text));
                                dicDuLieuAPI_QrData.Add("txnId", lmathanhtoanQR.ToString());
                                dicDuLieuAPI_QrData.Add("amount", prob2.ToString());
                                dicDuLieuAPI_QrData.Add("payType", _payType);
                                dicDuLieuAPI_QrData.Add("countryCode", _countryCode);
                                dicDuLieuAPI_QrData.Add("merchantCity", _merchantCity);
                                dicDuLieuAPI_QrData.Add("terminalName", _terminalName);
                                dicDuLieuAPI_QrData.Add("merchantCC", _merchantCC);

                                string jsonData_wl = JsonConvert.SerializeObject(dicDuLieuAPI_QrData, Formatting.Indented);
                                string url = "http://27.65.194.106:7879/PhuongNam/MatAPI/qrdata";
                                var lgenerator_qrData = PostAsync_Qrdata(url, jsonData_wl);
                                JObject jo_data = JObject.Parse(lgenerator_qrData.ToString());
                                string QrData = jo_data["qrdata"].ToString();
                                RenderQrCode(QrData);

                                _MaThanhToanQR = lmathanhtoanQR.ToString();//"22101812455401";//
                                txtTienThanhToanQR.Text = prob2.ToString();//"0";//
                                lblPhieuThanhToan.Text = "Mã thanh toán: " + lmathanhtoanQR.ToString();
                                counter = Convert.ToInt32(FrmMain.xGetTimeWaiting);
                                timer1.Start();
                            }
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Kết nối api không thành công" + ex.ToString());
                            FrmThongBao f = new FrmThongBao();
                            f.txtNoiDung.Text = "Kết nối api không thành công" + ex.ToString();
                            f.ShowDialog();
                            return;
                        }
                    }
                }
            }
            else
            {
                FrmThongBao f = new FrmThongBao();
                f.txtNoiDung.Text = "Chưa có mã tra cứu người bệnh !!!";
                f.ShowDialog();
                btsoxoahet_Click(null, null);
                return;
            }    
        }


        public string ReadResponseFromUrl(string url)
        {
            var httpClientHandler = new HttpClientHandler();
            var httpClient = new HttpClient(httpClientHandler)
            {
                BaseAddress = new Uri(url)
            };
            using (var response = httpClient.GetAsync(url))
            {
                string responseBody = response.Result.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
        }

        public JObject PostAsync_Qrdata(string url, string content)
        {
            byte[] data = Encoding.UTF8.GetBytes(content);
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            //request.Headers.Add("x-ibm-client-id", clientid);
            //request.Headers.Add("x-ibm-client-secret", clientsecrect);
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                WebResponse response = request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseContent = reader.ReadToEnd();
                    JObject adResponse =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent);
                    return adResponse;
                }
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    using (StreamReader reader = new StreamReader(webException.Response.GetResponseStream()))
                    {
                        string responseContent = reader.ReadToEnd();
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent); ;
                    }
                }
            }

            return null;
        }
    
        private string RemoveDiacritics(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        
        public JObject PostAsync(string clientid,string clientsecrect, string url, string content)
        {
            byte[] data = Encoding.UTF8.GetBytes(content);
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("x-ibm-client-id", clientid);
            request.Headers.Add("x-ibm-client-secret", clientsecrect);
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                WebResponse response =  request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseContent = reader.ReadToEnd();
                    JObject adResponse =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent);
                    return adResponse;
                }
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    using (StreamReader reader = new StreamReader(webException.Response.GetResponseStream()))
                    {
                        string responseContent = reader.ReadToEnd();
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent); ;
                    }
                }
            }

            return null;
        }

        private void bt_Benhnhankhac_Click(object sender, EventArgs e)
        {
            
        }

        public void fclear()
        {
            txtMaXacDinh.Text = "";
            txtHoTen.Text = "";
            txtMaBenhNhan.Text = "";
            txtDiaChi.Text = "";
            txtTienThanhToan.Text = "";
            txttienchu.Text = "";
            txtNoiDungThu.Text = "";
            txtTienThanhToanQR.Text = "";
            txtphongkham.Text = "";
            txtmaphongkham.Text = "";
            txtsothutu.Text = "0";
            txtdoituong.Text = "";
            lbThanhCong.Visible = false;
            lbTimer.Text = "";
            lblPhieuThanhToan.Text = "";
            pictureBoxQRCode.Image = null;

            pictureBoxQRCode.Image = Image.FromFile(FrmMain.xPathConfigs + @"QRPAYTIME.PNG");
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            
            timer1.Stop();
        }

        private void btso1_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btso2_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btso3_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btso4_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btso5_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btso6_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btso7_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btso9_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btso0_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btsoxoa_Click(object sender, EventArgs e)
        {
            if (txtMaXacDinh.Text.Trim() != "")
            {
                txtMaXacDinh.Text = txtMaXacDinh.Text.Substring(0, txtMaXacDinh.Text.Length - 1);
            }
        }

        private void btsoxoahet_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = "";
            fclear();
            txtMaXacDinh.Focus();
        }

        private void btsogach_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btsoxec_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void bt_tracuuthongtin_Click(object sender, EventArgs e)
        {
            if (FrmMain.xGetPayTuHIS == 0)
            {
                pictureBoxQRCode.Image = null;
                txtTienThanhToanQR.Text = "";
                string lDuongDan = FrmMain.xPathConfigs + @"Thanhtoantien.json";
                if (System.IO.File.Exists(lDuongDan))
                {
                    string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"Thanhtoantien.json");
                    JObject jobj = JObject.Parse(jsondata);
                    string strfilethanhtoan = jobj["thanhtoan"].ToString();
                    JObject joTiepNhan = JObject.Parse(strfilethanhtoan);
                    _hlib.hFillMasterData(this, strfilethanhtoan, "Master");
                }
            }
            else
            {
                pictureBoxQRCode.Image = null;
                txtTienThanhToanQR.Text = "";
                lblPhieuThanhToan.Text = "";
                _MaThanhToanQR = "";
                string url_FindInfo = "";
                if (txtMaXacDinh.Text != "")
                {
                    if (txtMaXacDinh.Text.Trim().Length == 10)
                    {
                        string lNgayKham = _Ngay.ToShortDateString();
                        string lSoDienThoai = txtMaXacDinh.Text.Trim();
                        url_FindInfo = "http://hsoftapi.bvmat.com:9004/api/kiemtrahen?ngay=" + lNgayKham + "&mabn=&sodienthoai=" + lSoDienThoai;                        
                    }
                    else
                    {
                        string lNgayKham = FrmMain.xNgay;
                        string lMabn = txtMaXacDinh.Text.Trim();
                        url_FindInfo = "http://hsoftapi.bvmat.com:9004/api/kiemtrahen?ngay=" + lNgayKham + "&mabn=" + lMabn + "&sodienthoai=";
                    }
                    var lgenerator_qrData = ReadResponseFromUrl(url_FindInfo);
                    if (lgenerator_qrData != null && lgenerator_qrData != "null")
                    {
                        //JArray jarr = JArray.Parse(lgenerator_qrData.ToString());
                        JObject jobj = JObject.Parse(lgenerator_qrData.ToString());
                        string lData = jobj.ToString();
                        //MessageBox.Show(lData);
                        txtMaBenhNhan.Text = jobj["mabenhnhan"].ToString();
                        txtHoTen.Text = jobj["hotenbenhnhan"].ToString();
                        txtDiaChi.Text = jobj["diachi"].ToString();
                        txtdoituong.Text = jobj["doituong"].ToString();
                        txtsothutu.Text = "0";
                        if (jobj["maphongkham"].ToString() != "")
                        {
                            txtphongkham.Text = jobj["phongkham"].ToString();
                            txtmaphongkham.Text = jobj["maphongkham"].ToString();
                        }
                        else
                        {
                            string lPath_cf = FrmMain.xPathConfigs + @"Config.json";
                            if (System.IO.File.Exists(lPath_cf))
                            {
                                string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"Config.json");
                                JObject jobj_cf = JObject.Parse(jsondata);

                                string strkhuvuc = jobj_cf["cauhinhkhuvuc"].ToString();
                                JObject joKhuvuc = JObject.Parse(strkhuvuc);
                                txtphongkham.Text = joKhuvuc["tenphongkham"].ToString();
                                txtmaphongkham.Text = joKhuvuc["maphongkham"].ToString();
                            }                            
                        }    
                        txtTienThanhToan.Text = FrmMain.xGetCauHinhTienKhamBenh.ToString();
                        txtNoiDungThu.Text = "Thu tiền khám bệnh";
                        }
                    else
                    {
                        //MessageBox.Show("Không tìm thấy thông tin");
                        FrmThongBao f = new FrmThongBao();
                        f.txtNoiDung.Text = "Không tìm thấy thông tin !!!";
                        f.ShowDialog();
                        btsoxoahet_Click(null, null);
                        return;
                    }    
                }
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Int32 prob2 = 10000;
            //CreateQrCode obj = new CreateQrCode("970489", "0301483745", "01", "BV MAT TPHCM", "104000769666", "704", "VN", "HANOI", "KHOA KHAM BENH", "12898");
            //string text = obj.create(txtMaBenhNhan.Text, prob2, "XV_" + RemoveUnicode(txtHoTen.Text));
            //if (String.IsNullOrWhiteSpace(lblthoigian.Text) || String.IsNullOrEmpty(lblthoigian.Text))
            //{
            //    picQRThanhToan.Image = null;
            //    MessageBox.Show("Text not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    var qr = new ZXing.BarcodeWriter();
            //    qr.Options = options;
            //    qr.Format = ZXing.BarcodeFormat.QR_CODE;
            //    var result = new Bitmap(qr.Write(text.Trim()));
            //    picQRThanhToan.Image = result;

            //}
        }

        private void txtMaXacDinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btso8_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void txtMaXacDinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //fGetBarCode();
                bt_tracuuthongtin_Click(null, null);
                SendKeys.Send("{TAB}");               
            }
        }

        private void txtTienThanhToan_TextChanged(object sender, EventArgs e)
        {
            double lTien = 0;
            if (txtTienThanhToan.Text == "")
            {
                lTien = 0;
                txtTienThanhToan.Text = "0";
            }
            else
            {
                lTien = double.Parse(txtTienThanhToan.Text);
            }
            txttienchu.Text = dichso.Dich(lTien);
        }

        private void txtTienThanhToan_Validated(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pictureBoxQRCode.BackgroundImage.Save(@"D:\FUNA\barcode.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void Frm_ThanhToan_Shown(object sender, EventArgs e)
        {
            fclear();
            txtMaXacDinh.Focus();
            txtTienThanhToan.Text = FrmMain.xGetCauHinhTienKhamBenh.ToString();
            txtTienThanhToan_TextChanged(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                fclear();
                pictureBoxQRCode.Image = null;
                pictureBoxQRCode.Image = Image.FromFile(FrmMain.xPathConfigs + @"QRPAYTIME.PNG");
                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;               

                timer1.Stop();
            }
            lbTimer.Text = counter.ToString();
            if (fcheckdathanhtoan(_MaThanhToanQR))
            {
                if (fUpdatePay(_MaThanhToanQR))
                {
                    _queryBuilder = "SELECT bvrequest FROM public.qrpay_d_thanhtoan where Status = true And bvrequest @? '$.thanhtoan[*] ? (@.mathanhtoan == " + _MaThanhToanQR + ")'";
                    DataTable ldtThongTin = _hdataulti.hgetDataTable(_loginID, _queryBuilder);
                    if (ldtThongTin.Rows.Count > 0)
                    {
                        timer1.Stop();
                        bookingRom(ldtThongTin, _dt_Confirm, _MaThanhToanQR);
                        //fCallPrint(ldtThongTin, "0010", _MaThanhToanQR);
                        lbThanhCong.Visible = true;
                        timer2.Start();
                    }
                }
            }
        }

        private bool fUpdatePay(string MaThanhToanQR)
        {
            _queryBuilder = "Update public.qrpay_d_thanhtoan Set Status = true where mathanhtoan = "+ MaThanhToanQR;
            try
            {
                object obj = _hdataulti.hgetObject(_loginID, _queryBuilder);
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }


        private void bookingRom(DataTable dtRequest ,DataTable dtConfirm,string MaThanhToanQR)
        {
            if (txtMaXacDinh.ToString().Trim() !="")
            {
                string lRequest = dtRequest.Rows[0]["bvrequest"].ToString();
                JObject jobj = null;
                jobj = JObject.Parse(lRequest);
                string strthanhtoan = jobj["thanhtoan"].ToString();
                JObject jothanhtoan = JObject.Parse(strthanhtoan);

                string jsondata = dtConfirm.Rows[0]["dulieu"].ToString();
                JObject jobj_Confirm = null;
                jobj_Confirm = JObject.Parse(jsondata);
                string strRequest = jobj_Confirm["request"].ToString();
                JObject joRequest = JObject.Parse(strRequest);

                Dictionary<string, object> dicDuLieu_InsuranceDetail = new Dictionary<string, object>();
                dicDuLieu_InsuranceDetail.Add("insuranceNumber", "");
                dicDuLieu_InsuranceDetail.Add("checkInType", "");
                dicDuLieu_InsuranceDetail.Add("insuranceType", "");
                dicDuLieu_InsuranceDetail.Add("expiredDate", "");
                dicDuLieu_InsuranceDetail.Add("insuranceStatus", "");
                dicDuLieu_InsuranceDetail.Add("lastExamDate", "");
                dicDuLieu_InsuranceDetail.Add("hospitalId", "79025");
                dicDuLieu_InsuranceDetail.Add("detailUrl", "");

                Dictionary<string, object> dicDuLieu_payment = new Dictionary<string, object>();
                dicDuLieu_payment.Add("paymentId", MaThanhToanQR);
                dicDuLieu_payment.Add("amount", joRequest["amount"].ToString());
                dicDuLieu_payment.Add("paymentMethod", "QRPAY ONLINE");
                dicDuLieu_payment.Add("paymentGateway", "QRPAY");
                dicDuLieu_payment.Add("transactionId", dtConfirm.Rows[0]["qrconfirm_id"].ToString());
                
                DateTime paymentTime = DateTime.Parse(dtConfirm.Rows[0]["ngayud"].ToString());
                string lTime = paymentTime.ToString("HHmm");
                if (lTime == "")
                {
                    lTime = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
                }
                dicDuLieu_payment.Add("paymentTime", paymentTime.ToString("dd/MM/yyyy HH:mm"));// "21/10/2022 21:01"

                Dictionary<string, object> dicDuLieu_booking = new Dictionary<string, object>();
                dicDuLieu_booking.Add("bookingId", "0");
                dicDuLieu_booking.Add("patientId", jothanhtoan["mabenhnhan"].ToString());
                dicDuLieu_booking.Add("scheduleId", "");

                string lNgayThanhToan = jothanhtoan["ngaythanhtoan"].ToString() + lTime;
               
                dicDuLieu_booking.Add("date", DateTime.ParseExact(lNgayThanhToan, "yyyyMMddHHmm", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy HH:mm"));//"21/10/2022 21:01",
                dicDuLieu_booking.Add("subjectId", "");
                dicDuLieu_booking.Add("roomId", jothanhtoan["maphongkham"].ToString());
                dicDuLieu_booking.Add("doctorId", "");
                dicDuLieu_booking.Add("serviceId", "38594");
                dicDuLieu_booking.Add("doituongkham", 2);
                dicDuLieu_booking.Add("stt", "");
                dicDuLieu_booking.Add("mavaovien", "");
                dicDuLieu_booking.Add("type", "kios");
                dicDuLieu_booking.Add("payment", dicDuLieu_payment);
                dicDuLieu_booking.Add("InsuranceDetail", dicDuLieu_InsuranceDetail);

                string jsonData_wl = JsonConvert.SerializeObject(dicDuLieu_booking, Formatting.Indented);
                string url = "http://hsoftapi.bvmat.com:9004/api/createbooking?ip=&idbv=";
                var lgenerator_qrData = PostAsync_Qrdata(url, jsonData_wl);
                JObject jo_data = JObject.Parse(lgenerator_qrData.ToString());
                string QrData = jo_data.ToString();

                Dictionary<string, object> dicDuLieu_his = new Dictionary<string, object>();
                dicDuLieu_his.Add("createbooking", dicDuLieu_booking);
                dicDuLieu_his.Add("response", jo_data);

                Dictionary<string, hTbInfo> dic_vtb_qr_d_confirm = new Dictionary<string, hTbInfo>(); // đưa các trường dữ liệu, kiểu và giá trị bảng cần lưu
                dic_vtb_qr_d_confirm.Add("qrconfirm_id", new hTbInfo(hKieuDL.Numeric, dtConfirm.Rows[0]["qrconfirm_id"].ToString(), true, true, true));
                dic_vtb_qr_d_confirm.Add("dulieu_his", new hTbInfo(hKieuDL.Json, dicDuLieu_his));
                dic_vtb_qr_d_confirm.Add("ngayud_his", new hTbInfo(hKieuDL.Datetime, DateTime.Now, false, false, false));
                string jsonData = JsonConvert.SerializeObject(dic_vtb_qr_d_confirm, Formatting.Indented);
                try
                {
                    object obj = _hdataulti.hsaveData(_loginID, "vtb_qr_d_confirm", jsonData);
                    fCallPrint(dtRequest, jo_data["stt"].ToString(), _MaThanhToanQR);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }


        private bool fcheckdathanhtoan(string mathanhtoan)
        {
            _queryBuilder = "SELECT * FROM public.vtb_qr_d_confirm where dulieu @? '$.request[*] ? (@.orderId == \"" + mathanhtoan + "\")'";
            _dt_Confirm = _hdataulti.hgetDataTable(_loginID, _queryBuilder);
            if(_dt_Confirm.Rows.Count > 0)
            {
                return true;
            }  
            else
            {
                return false;
            }            
        }

        private void fCallPrint(DataTable ldtThongTin,string SoThuTu, string MaThanhToan)
        {
            if (ldtThongTin.Rows.Count > 0)
            {
                txtsothutu.Text = SoThuTu.ToString();
                string jsondata = ldtThongTin.Rows[0]["bvrequest"].ToString();
                fPrint_SoThuTu(ldtThongTin, "d_InSoThuTu", txtsothutu.Text);
            }
            else
            {

                //MessageBox.Show("Chưa có dữ liệu in trong hệ thống");
                FrmThongBao f = new FrmThongBao();
                f.txtNoiDung.Text = "Chưa có dữ liệu in trong hệ thống !!!";
                f.ShowDialog();
            }
        }

        private void fPrint_SoThuTu(DataTable dt, string NameReport, string SoThuTu)
        {
            string dataReport = dt.Rows[0]["bvrequest"].ToString();//JsonConvert.SerializeObject(jsondata);
            JObject ljobj = JObject.Parse(dataReport);
            string strchitiet = ljobj["thanhtoan"].ToString();
            Report report = new Report();
            report.Load(Application.StartupPath + @"\reports\" + NameReport + ".frx");            

            var txtsothutu = report.Report.FindObject("txtsothutu") as TextObject;
            txtsothutu.Text = SoThuTu;
            if (!hchkInSoThuTuKhongXem.Checked)
            {
                frmReportViewer frm = new frmReportViewer(NameReport, dataReport, report);
                frm.ShowDialog();
            }
            else
            {
                string jsondata = hJsonLib.hgetJsonJF(FrmMain.xPathConfigs + @"Config.json");
                JObject jobj = JObject.Parse(jsondata);
                string strPrint = jobj["cauhinhmayin"].ToString();
                JObject joPrint = JObject.Parse(strPrint);
                string lPrintNhan = joPrint["mayinsothutu"].ToString();
                report.PrintSettings.Printer = lPrintNhan;
                report.PrintSettings.ShowDialog = false;
                FastReport.Data.JsonConnectionStringBuilder con = new FastReport.Data.JsonConnectionStringBuilder();
                con.Json = dataReport;
                report.Report.Dictionary.Connections[0].ConnectionString = con.ToString();
                report.Print();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            hienthanhcong++;
            if (hienthanhcong % 2 == 0)
                lbThanhCong.ForeColor = Color.FromArgb(243, 99, 84);
            else
                lbThanhCong.ForeColor = Color.FromArgb(36, 103, 171);

            if (hienthanhcong == 15)
            {
                fclear();
                hienthanhcong = 0;
                timer2.Stop();
            }
        }

        private void btgachngang_Click(object sender, EventArgs e)
        {
            txtMaXacDinh.Text = txtMaXacDinh.Text + ((Button)sender).Text;
        }

        private void btnhacungcap5_Click(object sender, EventArgs e)
        {
            FrmCauHinhThongSo f = new FrmCauHinhThongSo();
            f.ShowDialog();
        }
    }
}
