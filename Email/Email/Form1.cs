using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool check(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void btnEmail_Click(object sender, EventArgs e)
        {
            if(check(txtEmail.Text))
            {
                MessageBox.Show("Xin chao! Ban da nhap dung dinh dang email");
            }
            if(!check(txtEmail.Text))
            {
                MessageBox.Show("Sai dinh dang email");
            }
        }
    }
}
