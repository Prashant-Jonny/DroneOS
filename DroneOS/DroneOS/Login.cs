using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneOSClient
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            lblServerStatus.Text = "Offline";//Default setting.
        }

        private void loginShortcut(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(this, new EventArgs());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text.Trim();//Trim the trailing spaces off both the inputs.
            String password = txtPassword.Text.Trim();
            if (username == "owen" && password == "test")
            {
                //MessageBox.Show("Login successfull!"); // For debugging

                this.Hide();//Hide this form, open the main form once login process is complete.

                Main mainForm = new Main();
                mainForm.ShowDialog();
            } else
                MessageBox.Show("Incorrect login info." + username + " " + password);

        }
    }
}
