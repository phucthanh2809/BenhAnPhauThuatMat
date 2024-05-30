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
    public partial class Frm_Login_V2 : Form
    {
        public Frm_Login_V2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (FrmMain_V2 fd = new FrmMain_V2())
            //{
            //    fd.ShowDialog();
            //}
            if (txtMaNhanVien.Text.Length == 0)
            {
                FrmMain_V2._Main.fShowAlert("Đăng nhập không thành công", Form_Alert.enmType.Warning);
                return;
            }
            else
            {
                this.Close();
                FrmMain_V2._Main.fShowAlert("Đăng nhập thành công", Form_Alert.enmType.Success);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_V2_Load(object sender, EventArgs e)
        {

        }
    }
}
