using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBelfray
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(128, 128, 128);
            lblForgotPW.ForeColor = Color.FromArgb(241, 218, 117);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.ToString() == "Username")
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.ToString() == "Username")
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
            }
        }
    }
}
