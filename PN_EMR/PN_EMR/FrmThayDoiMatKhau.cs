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
    public partial class FrmThayDoiMatKhau : Form
    {
        private string _queryBuilder = "";
        private static readonly hdataLib _hdataulti = FrmMain.xdataulti;
        private static readonly hLibrary _hlib = new hLibrary();
        private static readonly string _loginID = FrmMain.xLoginID;
        private DataTable _dtThongTin;
        public FrmThayDoiMatKhau(string taikhoan_dk, string hoten)
        {
            InitializeComponent();
            txttaikhoan_dk.Text = taikhoan_dk;
            txthoten_dk.Text = hoten;
        }

        private void txttaikhoan_dk_Leave(object sender, EventArgs e)
        {
            
        }

        private void hbt_boqua_Click(object sender, EventArgs e)
        {
            txttaikhoan_dk.Text = "";
            txthoten_dk.Text = "";
            txtmatkhau_dk.Text = "";
            txtxacnhanmatkhau_dk.Text = "";
            txtmatkhauhientai.Text = "";
        }

        private void hbt_dangky_Click(object sender, EventArgs e)
        {
            if(txtmatkhauhientai.Text != "")
            {
                if(txtmatkhauhientai.Text == _dtThongTin.Rows[0]["matkhau"].ToString())
                {
                    _queryBuilder= "Update l_sudungphanmem Set matkhau ='" + txtxacnhanmatkhau_dk.Text + "' Where manhanvien ='"+txttaikhoan_dk.Text +"' And matkhau = '" + txtmatkhauhientai.Text + "'";
                    _hdataulti.hrunQuery(_loginID, _queryBuilder);
                    MessageBox.Show("Cập nhật mật khẩu thành công", "Vui lòng kiểm tra lại");
                    this.Close();
                }   
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng", "Vui lòng kiểm tra lại");
                    return;
                }    
            }    
        }

        private void btthoattaonguoidung_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmatkhauhientai_Leave(object sender, EventArgs e)
        {
            if (txtmatkhauhientai.Text.Trim() != "" && txtmatkhauhientai.Text.Trim() != null)
            {
                _queryBuilder = "Select manhanvien,hoten,matkhau from l_sudungphanmem where manhanvien ='" + txttaikhoan_dk.Text + "'";
                _dtThongTin = _hdataulti.hgetDataTable(_loginID, _queryBuilder);
                if (_dtThongTin.Rows.Count > 0)
                {
                    txtmatkhau_dk.Enabled = true;
                    txtxacnhanmatkhau_dk.Enabled = true;
                    txtmatkhau_dk.Text = "";
                    txtxacnhanmatkhau_dk.Text = "";
                }
                else
                {
                    MessageBox.Show("Người dùng này chưa tồn tại", "Vui lòng kiểm tra lại");
                    txtmatkhau_dk.Enabled = false;
                    txtxacnhanmatkhau_dk.Enabled = false;
                    txtmatkhau_dk.Text = "";
                    txtxacnhanmatkhau_dk.Text = "";
                    return;
                }
            }
        }

        private void p_top_MouseMove(object sender, MouseEventArgs e)
        {
            //FrmMain.ReleaseCapture();
            //FrmMain.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void chk_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienmatkhau.Checked)
            {
                txtxacnhanmatkhau_dk.UseSystemPasswordChar = false;
                txtmatkhau_dk.UseSystemPasswordChar = false;
            }
            else
            {
                txtxacnhanmatkhau_dk.UseSystemPasswordChar = true;
                txtmatkhau_dk.UseSystemPasswordChar = true;
            }
        }
    }
}
