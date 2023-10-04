using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_MinhNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            TinhToan tt = new TinhToan(a,b);
            string s="Ket Qua La :";
            if (rdo_cong.Checked)
            {
                MessageBox.Show(s + tt.TinhTong());                
            }
            else if (rdo_tru.Checked)
            {
                MessageBox.Show(s + tt.TinhHieu());
            }
            else if (rdo_nhan.Checked)
            {
                MessageBox.Show(s + tt.TinhTich());
            }
            else if (b != 0)
            {
                MessageBox.Show(s + tt.TinhThuong());
            }
            else
                MessageBox.Show("Phep chia bi loi!!!");
                
                
        }
    }
}
