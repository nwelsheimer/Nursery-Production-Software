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
using System.Reflection;
using Nursery_Production_Software.Class;
using General;

namespace Nursery_Production_Software
{
    public partial class frmMain : MetroForm
    {
        plAuth _Auth = null;
        int userId = 0;
        
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
            lnkSettings.Visible = true;
        }

        void _AuthLoginSuccess(object sender, EventArgs e)
        {
            //Whole mess of things to build the menu system when you log in.
            
            //This table contains the complete menu system for this user
            DataTable menuSystem = Global.GetData("usp_SYS_MenuBuilder @userId=" + userId).Tables[0];

            //filter a distinct list of parent menus
            DataView temp = menuSystem.DefaultView;
            DataTable parents = temp.ToTable(true, "MenuName", "MenuTitle");

            //create one tab for each distinct menu
            foreach (DataRow dr in parents.Rows)
            {
                //build the tab control and a fancy title label
                MetroFramework.Controls.MetroTabPage menuPage = new MetroFramework.Controls.MetroTabPage();
                MetroFramework.Controls.MetroLabel menuTitle = new MetroFramework.Controls.MetroLabel();
                menuPage.Name = dr["MenuName"].ToString();
                menuPage.Text = dr["MenuName"].ToString();
                menuPage.StyleManager = stylMan;
                //apply some formating to the label
                menuTitle.Text = dr["MenuTitle"].ToString();
                menuTitle.Location = new System.Drawing.Point(15, 20);
                menuTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
                menuTitle.AutoSize = true;
                menuTitle.StyleManager = stylMan;
                menuPage.Controls.Add(menuTitle);
                //now fetch a list of the submenus from the orignal table that have the same name
                DataView subTemp = menuSystem.DefaultView;
                subTemp.RowFilter = "MenuName = '" + dr["MenuName"].ToString() +"'";
                //and add the tiles
                int x = 5;
                int y = 70;
                foreach (DataRow subdr in subTemp.ToTable().Rows)
                {
                    MetroFramework.Controls.MetroTile subtile = new MetroFramework.Controls.MetroTile();
                    subtile.Size = new System.Drawing.Size(150, 150);
                    subtile.Name = subdr["assmName"].ToString();
                    subtile.Text = subdr["formName"].ToString();
                    subtile.Tag = subdr["formCode"].ToString();
                    subtile.Location = new System.Drawing.Point(x, y);

                    subtile.Click += new EventHandler(DynamicButton_Click);
                    subtile.MouseEnter += new EventHandler(DynamicMouseOver);
                    subtile.MouseLeave += new EventHandler(DynamicMouseOut);

                    menuPage.Controls.Add(subtile);

                    x += 160;
                }

                this.mtcMainMenu.Controls.Add(menuPage);
            }
            lnkSettings.Visible = false;
            _Auth.swipe(false);
            userId = _Auth.userId;
        }

        private void DynamicMouseOver(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void DynamicMouseOut(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            string assemblyname = ((MetroFramework.Controls.MetroTile)sender).Name;
            string formname = ((MetroFramework.Controls.MetroTile)sender).Tag.ToString();
            try
            {
                Assembly myAssembly = Assembly.Load(assemblyname);
                Form myForm = myAssembly.CreateInstance(formname) as Form;
                myForm.Show();
            }
            catch (Exception x)
            {
                MessageBox.Show("There was an error loading the application. Please contact technical support.  " +x, "Error");
            }
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
