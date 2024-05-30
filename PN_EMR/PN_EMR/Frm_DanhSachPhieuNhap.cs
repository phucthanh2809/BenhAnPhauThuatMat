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
    public partial class Frm_DanhSachPhieuNhap : Form
    {
        public Frm_DanhSachPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            FrmMain_V2._Main.fShowAlert("Thêm phiếu nhập", Form_Alert.enmType.Info);
            FrmMain_V2._Main.fShowNhapThuoc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMain_V2._Main.fShowAlert("Xoá phiếu lỗi", Form_Alert.enmType.Error);
        }
    }
}
