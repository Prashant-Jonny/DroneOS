using System;
using System.Windows.Forms;

namespace DroneOSClient
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            lblServerStatus.Text = "Offline";//Default setting.

            //REMOVE AT PRODUCTION
            this.Hide();//Hide this form, open the main form once login process is complete.
            mainForm f = new mainForm();
            f.ShowDialog();
        }

        private void loginShortcut(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(this, new EventArgs());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text.ToLower().Trim();//Trim the trailing spaces off both the inputs and convert to lowercase
            String password = txtPassword.Text.Trim();
            if (username == "owen" && password == "test")
            {
                this.Hide();//Hide this form, open the main form once login process is complete.
                mainForm f = new mainForm();
                f.ShowDialog();
            } else
                MessageBox.Show("Incorrect login info." + username + " " + password);
        }
    }
}
