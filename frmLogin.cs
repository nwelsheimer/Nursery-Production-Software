using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Nursery_Production_Software
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StyleManager = stylMan;
            this.Text = "JANS Login - " + Application.ProductVersion;
            dbSettings();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            showHideSetup();
            //Properties.Settings.Default.style = stylMan;
        }

        private void showHideSetup()
        {
            if (txtDb.Visible)
            {
                lblDb.Visible = false;
                lblHost.Visible = false;
                lblPort.Visible = false;
                txtDb.Visible = false;
                txtHost.Visible = false;
                txtPort.Visible = false;
                this.Height = 245;
                btnSetup.Text = "Setup";
            } else
            {
                this.Height = 355;
                lblDb.Visible = true;
                lblHost.Visible = true;
                lblPort.Visible = true;
                txtDb.Visible = true;
                txtHost.Visible = true;
                txtPort.Visible = true;
                btnSetup.Text = "Hide";
            }
        }

        public void dbSettings(bool isSave = false)
        {
            //Code to handle the loading and saving of the dbtab in preferances
            if (isSave)
            {
                //Save the settings to the registry
                Properties.Settings.Default.dbAddress = txtHost.Text;
                Properties.Settings.Default.dbName = txtDb.Text;
                Properties.Settings.Default.dbPort = txtPort.Text;
                Properties.Settings.Default.dbUser = txtUsername.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                //Fill in the text boxes
                txtHost.Text = Properties.Settings.Default.dbAddress;
                txtDb.Text = Properties.Settings.Default.dbName;
                txtPort.Text = Properties.Settings.Default.dbPort;
                txtUsername.Text = Properties.Settings.Default.dbUser;
            }
        }

        private void txtHost_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        private void txtPort_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        private void txtDb_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dbio.ConnectToDB(txtHost.Text, txtDb.Text, txtUsername.Text, txtPassword.Text, txtPort.Text))
            {
                txtPassword.Text = "";
                frmParent f = new frmParent();
                this.Visible = false;
                f.StyleManager = stylMan;
                f.ShowDialog();
                this.Visible = true;
                this.Activate();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Activate();
            if (txtUsername.Text!="")
                this.ActiveControl = txtPassword;
        }
    }
}
