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
    public partial class UC_Dashboard_Xuat : UserControl
    {
        public UC_Dashboard_Xuat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain_V2._Main.fShowAlert("Bán Thuốc", Form_Alert.enmType.Info);
            FrmMain_V2._Main.fLoadFrom<Frm_PhieuXuatBan>(0);
        }
    }
}
