using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdo_bacnhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_bacnhat.Checked == true)
            {
                txtC.Enabled = false;
            }
            else
                txtC.Enabled = true;
        }

        private void rdo_bachai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (rdo_bachai.Checked == true)
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float c = float.Parse(txtC.Text);
                float denta = b * b - 4 * a * c;
                if (denta < 0 && a != 0)
                {
                    rtb_ketqua.Text = "Phuong trinh vo nghiem";
                }
                else if (a != 0 && denta == 0)
                {
                    rtb_ketqua.Text = "Nghiem kep " + "X1 = X2 =" + (float)((-b) / 2 * a);
                }
                else if (a != 0)
                {
                    rtb_ketqua.Text = "PT co 2 nghiem phan biet " + "X1 = " + (float)(-b + (float)Math.Sqrt(denta)) / (2 * a) + " X2 = " + (float)(-b - (float)Math.Sqrt(denta)) / (2 * a);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            if (rdo_bacnhat.Checked ==true && rdo_bachai.Checked ==true)
            {
                btnGiai.Enabled = true;
            }
        }
    }
}
