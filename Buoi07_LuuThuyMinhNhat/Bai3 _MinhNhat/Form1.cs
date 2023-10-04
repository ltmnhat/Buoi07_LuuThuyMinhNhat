using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3__MinhNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdo_red_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_red.Checked == true)
            {
                label1.ForeColor = Color.Red;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdo_green_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_green.Checked == true)
            {
                label1.ForeColor = Color.Green;

            }
        }

        private void rdo_blue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_blue.Checked == true)
            {
                label1.ForeColor = Color.Blue;

            }
        }

        private void rdo_autocolor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_autocolor.Checked == true)
            {
                label1.ForeColor = Color.DarkOrange;
            }
        }

        private void chkRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegular.Checked == true)
            {
                label1.Font = new Font(label1.Font, FontStyle.Regular);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked == true)
            {
                label1.Font = new Font(label1.Font, FontStyle.Bold);
            }
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked == true)
            {
                label1.Font = new Font(label1.Font, FontStyle.Italic);
            }
        }

        private void chkBoldnItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoldnItalic.Checked== true)
            {
                label1.Font = new Font(label1.Font, (FontStyle)(FontStyle.Bold|FontStyle.Italic));
            }
        }
    }
}
