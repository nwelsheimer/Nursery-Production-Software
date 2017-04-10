using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;

namespace Nursery_Production_Software.Class
{
    public partial class plAuth : plSlider
    {
        public event EventHandler SettingClosed;
        public event EventHandler LogInSuccess;

        public plAuth(Form owner)
                : base(owner)
        {
            InitializeComponent();

            for (int i = 3; i < 13; i++)
            {
                //create the color tiles in the theme selector
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flpSettings.Controls.Add(_tile);
            }
            dbSettings();
        }

        void _tile_Click(object sender, EventArgs e)
        {
            //if you click the tiles, change the selected color scheme then save to reg
            ((MetroForm)this.Parent).StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
            //Properties.Settings.Default.stylStyle = ((MetroTile)sender).Tag.ToString();
        }
        
        public void ShowSettings()
        {
            //display preferances, disable the login box
            plPrefs.Visible = true;
            plBanner.Enabled = false;
        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            //hide settings, enable login, raise the settingsclosed event
            plPrefs.Visible = false;
            plBanner.Enabled = true;

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Dark;
            }
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Light;
            }
        }

        #region Default settings
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
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
        #endregion

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //do work to verify username and password

            //raise loginsuccess if we won
            EventHandler handler = LogInSuccess;
            if (handler != null) handler(this, e);
        }
    }
}
