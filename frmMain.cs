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
using Nursery_Production_Software.Class;

namespace Nursery_Production_Software
{
    public partial class frmMain : MetroForm
    {
        plAuth _Auth = null;

        public frmMain()
        {
            InitializeComponent();
            this.StyleManager = stylMan;
            this.Text = "JANS Login - " + Application.ProductVersion;
            this.Shown += frmMain_Shown;

            showLogin();
        }

        private void showLogin()
        {
            _Auth = new plAuth(this);
            _Auth.SettingClosed += _AuthSettingsClose;
            _Auth.LogInSuccess += _AuthLoginSuccess;
            _Auth.swipe();
        }

        void _AuthLoginSuccess(object sender, EventArgs e)
        {
            _Auth.swipe(false);
        }

        void _AuthSettingsClose(object sender, EventArgs e)
        {
            lnkSettings.Visible = true;
            lnkSystem.Visible = true;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            lnkSettings.Visible = false;
            lnkSystem.Visible = false;

            _Auth.ShowSettings();
        }

        private void lnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkSystem_Click(object sender, EventArgs e)
        {
            plSystem.Visible = true;
            plSystem.BringToFront();
            plSystem.Select();
        }

        private void plSystem_Leave(object sender, EventArgs e)
        {
            plSystem.Visible = false;
        }

        private void lnLogout_Click(object sender, EventArgs e)
        {
            showLogin();
        }
    }
}
