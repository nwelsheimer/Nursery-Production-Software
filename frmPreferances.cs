using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace Nursery_Production_Software
{
    public partial class frmPreferances : Form
    {
        public frmPreferances()
        {
            InitializeComponent();
            dbTab();
        }

        public void dbTab(bool isSave = false)
        {
            //Code to handle the loading and saving of the dbtab in preferances
            if (isSave)
            {
                //Save the settings to the registry
                Properties.Settings.Default.dbAddress = txtdbAddress.Text;
                Properties.Settings.Default.dbName = txtdbName.Text;
                Properties.Settings.Default.dbPassword = txtPassword.Text;
                Properties.Settings.Default.dbPort = txtPort.Text;
                Properties.Settings.Default.dbUser = txtUsername.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                //Fill in the text boxes
                string dbAddress = Properties.Settings.Default.dbAddress;
                txtdbAddress.Text = dbAddress;
                txtdbName.Text = Properties.Settings.Default.dbName;
                txtPassword.Text = Properties.Settings.Default.dbPassword;
                txtPort.Text = Properties.Settings.Default.dbPort;
                txtUsername.Text = Properties.Settings.Default.dbUser;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbTab(true);
            MessageBox.Show("Successfully updated database settings");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (dbio.ConnectToDB(txtdbAddress.Text, txtdbName.Text, txtUsername.Text, txtPassword.Text, txtPort.Text))
                MessageBox.Show("The connection to the database was successful!");
            else
                MessageBox.Show("The connection to database failed!");
        }
    }
}
